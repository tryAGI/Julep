install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
# This SDK is for Julep **v1**, and `v1` is the ref that says so. `main` is Julep 3, a ground-up
# rewrite that upstream states has no migration path from v1 - a different product, with no OpenAPI
# document in the repository at all - so pointing this fetch at the default branch would not update
# the SDK, it would replace it with another API's. `v1` and the `dev` branch this used to fetch are
# the same commit (2026-03-13) and serve byte-identical documents; `v1` is preferred only because
# the name states the intent, where `dev` reads like a branch that fell behind.
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/julep-ai/julep/v1/src/typespec/tsp-output/@typespec/openapi3/openapi-1.0.0.yaml

# Fix auth: convert apiKey schemes to http/bearer and add top-level security
python3 -c "
import json, yaml, sys

with open('openapi.yaml') as f:
    spec = yaml.safe_load(f)

# Replace securitySchemes with http/bearer
spec['components']['securitySchemes'] = {
    'BearerAuth': {
        'type': 'http',
        'scheme': 'bearer'
    }
}

# Replace top-level security
spec['security'] = [{'BearerAuth': []}]

# Fix servers to use a fixed base URL (remove templated variable)
spec['servers'] = [{'url': 'https://api.julep.ai/api'}]

# Remove multiline default values that break C# string constants
schemas = spec.get('components', {}).get('schemas', {})
for schema_name, schema in schemas.items():
    props = schema.get('properties', {})
    for prop_name, prop in props.items():
        if 'default' in prop and isinstance(prop['default'], str) and '\n' in prop['default']:
            del prop['default']

# Fix tool route responses: replace string enum responses with simple string type
# These endpoints return acknowledgment strings but AutoSDK can't handle enum-as-response
for path, methods in spec.get('paths', {}).items():
    for method, data in methods.items():
        if method not in ('get','post','put','patch','delete'):
            continue
        for code, resp in data.get('responses', {}).items():
            schema = resp.get('content', {}).get('application/json', {}).get('schema', {})
            if schema.get('type') == 'string' and 'enum' in schema:
                resp['content']['application/json']['schema'] = {'type': 'string'}

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, sort_keys=False, allow_unicode=True)
"

# The spec declares `format: int8` on three fields, and AutoSDK maps that faithfully to `sbyte` -
# which is not CLS-compliant, while `src/libs/Directory.Build.props` declares this assembly
# `[CLSCompliant(true)]`, so the library stopped compiling with three `CS3001`s. Dropping the format
# leaves `type: integer` and an `int`, which still carries the declared `minimum`/`maximum` (1..10 on
# `k_multiplier`) and loses nothing a caller could use. `uint8` is left alone: it maps to `byte`,
# which is CLS-compliant.
python3 -I - openapi.yaml <<'INT8_EOF'
import sys
import yaml

path = sys.argv[1]
document = yaml.safe_load(open(path, encoding="utf-8").read())
patched = 0


def widen(node):
    global patched
    if isinstance(node, dict):
        if node.get("type") == "integer" and node.get("format") == "int8":
            del node["format"]
            patched += 1
        for value in node.values():
            widen(value)
    elif isinstance(node, list):
        for value in node:
            widen(value)


widen(document)
if patched == 0:
    raise SystemExit("no `format: int8` left to widen -- upstream changed it, drop this step")
open(path, "w", encoding="utf-8").write(yaml.safe_dump(document, sort_keys=False, allow_unicode=True))
print(f"widened {patched} `format: int8` field(s) so no sbyte reaches a CLS-compliant assembly")
INT8_EOF

autosdk generate openapi.yaml \
  --namespace Julep \
  --clientClassName JulepClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
