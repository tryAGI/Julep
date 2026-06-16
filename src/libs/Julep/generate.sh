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
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/julep-ai/julep/dev/src/typespec/tsp-output/@typespec/openapi3/openapi-1.0.0.yaml

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

autosdk generate openapi.yaml \
  --namespace Julep \
  --clientClassName JulepClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
