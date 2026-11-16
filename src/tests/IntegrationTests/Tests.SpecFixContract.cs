namespace Julep.IntegrationTests;

/// <summary>
/// What generate.sh does to the spec, checked without an API key.
///
/// generate.sh patches the document in python3 before generating.
///
/// This SDK passes no `--security-scheme`, so there is no credential to assert; what can be checked
/// is that the fix still produces the surface it exists to produce. Every other test here needs an
/// API key and reports inconclusive without one, so the suite printed `Skipped!` and exited 0 —
/// which reads exactly like a passing run.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheSurfaceTheSpecFixProducesIsStillThere()
    {
        var method = typeof(global::Julep.IJulepClient)
            .GetMethods()
            .FirstOrDefault(x => x.Name == "AgentDocsRouteCreateAsync");

        Assert.IsNotNull(
            method,
            "Julep.IJulepClient.AgentDocsRouteCreateAsync is gone. It is generated from the document " +
            "generate.sh produces; if a spec refresh removed it, look at the fix rather than at " +
            "this test.");
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://api.julep.ai/api", global::Julep.JulepClient.DefaultBaseUrl);
    }
}
