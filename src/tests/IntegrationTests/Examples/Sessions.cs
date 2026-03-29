/*
order: 20
title: Sessions
slug: sessions

Example showing how to create and manage chat sessions.
*/

namespace Julep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListSessions()
    {
        //// List all chat sessions on the Julep platform.

        using var client = GetAuthenticatedClient();

        var response = await client.SessionsRouteListAsync(
            limit: 10,
            offset: 0,
            metadataFilter: new object());

        response.Should().NotBeNull();
        response.Items.Should().NotBeNull();
    }
}
