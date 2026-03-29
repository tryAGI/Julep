/*
order: 10
title: Agents
slug: agents

Basic example showing how to create and list AI agents.
*/

namespace Julep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAgents()
    {
        //// List all agents on the Julep platform.

        using var client = GetAuthenticatedClient();

        var response = await client.AgentsRouteListAsync(
            limit: 10,
            offset: 0,
            metadataFilter: new object());

        response.Should().NotBeNull();
        response.Items.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_CreateAgent()
    {
        //// Create a new AI agent with a model and instructions.

        using var client = GetAuthenticatedClient();

        var agent = await client.AgentsRouteCreateAsync(
            request: new AgentsCreateAgentRequest
            {
                Name = "Test Agent",
                About = "A test agent for integration testing",
                Model = "gpt-4o-mini",
                Instructions = "You are a helpful assistant.",
                DefaultSystemTemplate = string.Empty,
            });

        agent.Should().NotBeNull();
        agent.Id.Should().NotBeEmpty();
        agent.Name.Should().Be("Test Agent");
    }
}
