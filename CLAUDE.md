# CLAUDE.md — Julep SDK

## Overview

Auto-generated C# SDK for [Julep](https://julep.ai/) — a stateful AI agent workflow platform with persistent memory, multi-step tasks, and tool integrations ("Firebase for AI agents").
OpenAPI spec from `https://raw.githubusercontent.com/julep-ai/julep/dev/src/typespec/tsp-output/@typespec/openapi3/openapi-1.0.0.yaml` (TypeSpec-generated, OpenAPI 3.0.0).

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
