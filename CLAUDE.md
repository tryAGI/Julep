# CLAUDE.md — Julep SDK

## Overview

Auto-generated C# SDK for [Julep](https://julep.ai/) — a stateful AI agent workflow platform with persistent memory, multi-step tasks, and tool integrations ("Firebase for AI agents").
OpenAPI spec from `https://raw.githubusercontent.com/julep-ai/julep/v1/src/typespec/tsp-output/@typespec/openapi3/openapi-1.0.0.yaml` (TypeSpec-generated, OpenAPI 3.0.0).

## Never point the spec fetch at the default branch

`main` is **Julep 3**, which upstream's own README calls "a ground-up rewrite; there is no migration
path - v1 and v3 are different products", and it carries no OpenAPI document anywhere in the
repository. Switching the fetch there would not update this SDK, it would replace it with a
different API's. This SDK is for **Julep v1**, preserved on the `v1` branch - the same commit the
fetch used to read as `dev`, with a byte-identical document, under a name that states the intent.
The workspace audit (`scripts/audit_spec_source_branches.py`) carries that reason in its
`DELIBERATE` table, so it does not flag this ref.

Also worth knowing: `api.julep.ai` is retired. Every path, existing or not, answers with an HTML
redirect to `memory.store`, so this SDK's remaining use is against a self-hosted v1.

## Build & Test

```bash
dotnet build Julep.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key via HTTP Bearer token:

```csharp
var client = new JulepClient(apiKey); // JULEP_API_KEY env var
```

## Key Files

- `src/libs/Julep/openapi.yaml` — Transformed OpenAPI 3 spec (auth + multiline defaults fixed)
- `src/libs/Julep/generate.sh` — Downloads spec, fixes auth/defaults/enum responses, runs autosdk
- `src/libs/Julep/Generated/` — **Never edit** — auto-generated code (2718 files)
- `src/libs/Julep/Extensions/JulepClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## API Endpoints (78 operations across 41 paths)

### Core Resources
- **Agents** — Create, list, get, update, patch, delete AI agents
- **Sessions** — Manage stateful chat sessions with agents
- **Tasks** — Define multi-step workflows for agents
- **Executions** — Run and monitor task executions
- **Tools** — Configure tools for agents (function calling, API integrations, browser, etc.)

### Additional Resources
- **Users** — Manage users associated with sessions
- **Docs** — Agent and user document storage with search
- **Files** — File management
- **Projects** — Organize resources into projects
- **Secrets** — Manage API keys and secrets
- **Chat** — Direct chat with agents (including streaming)
- **Jobs** — Background job management

## Spec Fixes in generate.sh

1. **Auth**: Converts `apiKey` header schemes to `http/bearer`; adds top-level `security` array
2. **Servers**: Replaces templated server URL with fixed `https://api.julep.ai/api`
3. **Multiline defaults**: Removes multiline Jinja template default values that break C# string constants
4. **Enum responses**: Converts string enum response schemas to plain string type (avoids missing `FromJson` on enum types)
5. **`format: int8`**: Dropped on three fields, leaving `type: integer` and an `int`. AutoSDK maps
   `int8` faithfully to `sbyte`, which is not CLS-compliant, and `src/libs/Directory.Build.props`
   declares this assembly `[CLSCompliant(true)]` - so the library stopped compiling with three
   `CS3001`s. The declared `minimum`/`maximum` (1..10 on `k_multiplier`) survive the widening.
   `uint8` needs nothing: AutoSDK widens every unsigned format into a signed type on purpose, so it
   maps to `byte`, which is also why the 46 `format: uint16` fields here generate a plain `int`.
   `Tests.SpecFixContract.cs` asserts no `sbyte` reaches a public signature, because this broke on a
   *released* generator change with the spec byte-identical - nothing in the repository had moved.

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListAgentsTool()` — List AI agents with pagination
- `AsGetAgentTool()` — Get agent details by ID
- `AsCreateAgentTool()` — Create a new AI agent
- `AsListSessionsTool()` — List chat sessions with pagination
- `AsCreateSessionTool()` — Create a new chat session for an agent
- `AsListTasksTool()` — List workflow tasks for an agent
- `AsGetExecutionTool()` — Get task execution status and details
- `AsListAgentToolsTool()` — List tools configured for an agent
