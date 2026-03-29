/*
order: 30
title: MEAI Tools
slug: meai-tools

Example showing how to use AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Julep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiListAgentsTool()
    {
        //// Use the Julep ListAgents tool with any IChatClient via
        //// Microsoft.Extensions.AI abstractions.

        using var client = GetAuthenticatedClient();

        var tool = client.AsListAgentsTool();
        tool.Should().NotBeNull();
        tool.Name.Should().Be("Julep_ListAgents");
    }

    [TestMethod]
    public async Task Example_MeaiCreateAgentTool()
    {
        //// Use the Julep CreateAgent tool with any IChatClient.

        using var client = GetAuthenticatedClient();

        var tool = client.AsCreateAgentTool();
        tool.Should().NotBeNull();
        tool.Name.Should().Be("Julep_CreateAgent");
    }

    [TestMethod]
    public async Task Example_MeaiGetExecutionTool()
    {
        //// Use the Julep GetExecution tool to check task execution status.

        using var client = GetAuthenticatedClient();

        var tool = client.AsGetExecutionTool();
        tool.Should().NotBeNull();
        tool.Name.Should().Be("Julep_GetExecution");
    }

    [TestMethod]
    public async Task Example_AllMeaiTools()
    {
        //// Create all available AIFunction tools for use with any IChatClient.

        using var client = GetAuthenticatedClient();

        var tools = new[]
        {
            client.AsListAgentsTool(),
            client.AsGetAgentTool(),
            client.AsCreateAgentTool(),
            client.AsListSessionsTool(),
            client.AsCreateSessionTool(),
            client.AsListTasksTool(),
            client.AsGetExecutionTool(),
            client.AsListAgentToolsTool(),
        };

        tools.Should().HaveCount(8);
        tools.Should().AllSatisfy(t => t.Should().NotBeNull());
    }
}
