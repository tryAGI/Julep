
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsSpiderIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
        /// <summary>
        /// 
        /// </summary>
        Links,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSpiderIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsSpiderIntegrationDefMethod.Crawl => "crawl",
                ToolsSpiderIntegrationDefMethod.Links => "links",
                ToolsSpiderIntegrationDefMethod.Screenshot => "screenshot",
                ToolsSpiderIntegrationDefMethod.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ToolsSpiderIntegrationDefMethod.Crawl,
                "links" => ToolsSpiderIntegrationDefMethod.Links,
                "screenshot" => ToolsSpiderIntegrationDefMethod.Screenshot,
                "search" => ToolsSpiderIntegrationDefMethod.Search,
                _ => null,
            };
        }
    }
}