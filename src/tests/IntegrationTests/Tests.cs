namespace Julep.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static JulepClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JULEP_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("JULEP_API_KEY environment variable is not found.");

        var client = new JulepClient(apiKey);
        
        return client;
    }
}
