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

    [TestMethod]
    public void NoSbyteReachesThisClsCompliantAssembly()
    {
        // The spec declares `format: int8` on three fields and AutoSDK maps that faithfully to
        // `sbyte`, which is not CLS-compliant - and `src/libs/Directory.Build.props` declares this
        // assembly `[CLSCompliant(true)]`, so the library stopped compiling with three `CS3001`s.
        // generate.sh drops the format, leaving `type: integer` and an `int`.
        //
        // This is worth a test rather than trusting the build, because the build only broke after a
        // *released* generator changed the mapping with the spec byte-identical. The same can
        // happen again on a field this fix does not reach.
        var offenders = typeof(global::Julep.JulepClient).Assembly
            .GetTypes()
            .Where(static type => type.IsPublic)
            .SelectMany(static type => type.GetProperties()
                .Select(property => (Type: type, Member: property.Name, property.PropertyType)))
            .Where(static x =>
                x.PropertyType == typeof(sbyte) || x.PropertyType == typeof(sbyte?))
            .Select(static x => $"{x.Type.Name}.{x.Member}")
            .ToList();

        Assert.AreEqual(
            0,
            offenders.Count,
            $"sbyte in a public signature is CS3001 here: {string.Join(", ", offenders)}. " +
            "A `format: int8` reached the generator - widen it in generate.sh.");
    }
}
