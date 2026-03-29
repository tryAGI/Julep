# Microsoft.Extensions.AI Integration

The Julep SDK provides `AIFunction` tools that integrate with any `IChatClient` via the [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) abstractions.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsListAgentsTool()` | List AI agents with pagination |
| `AsGetAgentTool()` | Get agent details by ID |
| `AsCreateAgentTool()` | Create a new AI agent with model and instructions |
| `AsListSessionsTool()` | List chat sessions with pagination |
| `AsCreateSessionTool()` | Create a new chat session for an agent |
| `AsListTasksTool()` | List workflow tasks for an agent |
| `AsGetExecutionTool()` | Get task execution status and details |
| `AsListAgentToolsTool()` | List tools configured for an agent |

## Usage

```csharp
using Julep;
using Microsoft.Extensions.AI;

// Create Julep client
var julepClient = new JulepClient(apiKey);

// Get AIFunction tools for use with any IChatClient
var tools = new[]
{
    julepClient.AsListAgentsTool(),
    julepClient.AsGetAgentTool(),
    julepClient.AsCreateAgentTool(),
    julepClient.AsListSessionsTool(),
    julepClient.AsCreateSessionTool(),
    julepClient.AsListTasksTool(),
    julepClient.AsGetExecutionTool(),
    julepClient.AsListAgentToolsTool(),
};

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
var response = await chatClient.GetResponseAsync(
    "List all my Julep agents",
    new ChatOptions { Tools = [.. tools] });
```
