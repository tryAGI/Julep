#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Julep;

public static class JulepClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists agents.
    /// </summary>
    public static AIFunction AsListAgentsTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of agents to return (default 100)")] int limit = 100,
                   [Description("Offset for pagination (default 0)")] int offset = 0,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.AgentsRouteListAsync(
                    limit: limit,
                    offset: offset,
                    metadataFilter: new object(),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_ListAgents",
            description: "List AI agents from the Julep platform with pagination support.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets an agent by ID.
    /// </summary>
    public static AIFunction AsGetAgentTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The agent ID (GUID)")] string agentId,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.AgentsRouteGetAsync(
                    id: Guid.Parse(agentId),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_GetAgent",
            description: "Get details of a specific AI agent by its ID from the Julep platform.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a new agent.
    /// </summary>
    public static AIFunction AsCreateAgentTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Name of the agent")] string name,
                   [Description("Description/about text for the agent")] string about,
                   [Description("Model name to use (e.g., gpt-4-turbo, claude-3.5-sonnet)")] string model,
                   [Description("Instructions for the agent")] string instructions = "",
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.AgentsRouteCreateAsync(
                    request: new AgentsCreateAgentRequest
                    {
                        Name = name,
                        About = about,
                        Model = model,
                        Instructions = instructions,
                        DefaultSystemTemplate = string.Empty,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_CreateAgent",
            description: "Create a new AI agent on the Julep platform with specified name, description, model, and instructions.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists sessions.
    /// </summary>
    public static AIFunction AsListSessionsTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of sessions to return (default 100)")] int limit = 100,
                   [Description("Offset for pagination (default 0)")] int offset = 0,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.SessionsRouteListAsync(
                    limit: limit,
                    offset: offset,
                    metadataFilter: new object(),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_ListSessions",
            description: "List chat sessions from the Julep platform with pagination support.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a new session.
    /// </summary>
    public static AIFunction AsCreateSessionTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The agent ID (GUID) to associate with this session")] string agentId,
                   [Description("Optional situation/context for the session")] string? situation = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.SessionsRouteCreateAsync(
                    request: new SessionsCreateSessionRequest
                    {
                        Agent = Guid.Parse(agentId),
                        Situation = situation,
                        RenderTemplates = true,
                        AutoRunTools = false,
                        ForwardToolCalls = false,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_CreateSession",
            description: "Create a new chat session associated with an AI agent on the Julep platform.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists tasks for an agent.
    /// </summary>
    public static AIFunction AsListTasksTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The agent ID (GUID) to list tasks for")] string agentId,
                   [Description("Maximum number of tasks to return (default 100)")] int limit = 100,
                   [Description("Offset for pagination (default 0)")] int offset = 0,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.TasksRouteListAsync(
                    id: Guid.Parse(agentId),
                    limit: limit,
                    offset: offset,
                    metadataFilter: new object(),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_ListTasks",
            description: "List workflow tasks for a specific AI agent on the Julep platform.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets an execution by ID.
    /// </summary>
    public static AIFunction AsGetExecutionTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The execution ID (GUID) to get")] string executionId,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.ExecutionsRouteGetAsync(
                    id: Guid.Parse(executionId),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_GetExecution",
            description: "Get the status and details of a task execution on the Julep platform.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists agent tools.
    /// </summary>
    public static AIFunction AsListAgentToolsTool(this JulepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The agent ID (GUID) to list tools for")] string agentId,
                   [Description("Maximum number of tools to return (default 100)")] int limit = 100,
                   [Description("Offset for pagination (default 0)")] int offset = 0,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.AgentToolsRouteListAsync(
                    id: Guid.Parse(agentId),
                    limit: limit,
                    offset: offset,
                    metadataFilter: new object(),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Julep_ListAgentTools",
            description: "List tools configured for a specific AI agent on the Julep platform.");
    }
}
