
#nullable enable

namespace Julep
{
    /// <summary>
    /// The specific method of the integration to call
    /// </summary>
    public enum ToolsSpiderIntegrationDefUpdateMethod
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
    public static class ToolsSpiderIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsSpiderIntegrationDefUpdateMethod.Crawl => "crawl",
                ToolsSpiderIntegrationDefUpdateMethod.Links => "links",
                ToolsSpiderIntegrationDefUpdateMethod.Screenshot => "screenshot",
                ToolsSpiderIntegrationDefUpdateMethod.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ToolsSpiderIntegrationDefUpdateMethod.Crawl,
                "links" => ToolsSpiderIntegrationDefUpdateMethod.Links,
                "screenshot" => ToolsSpiderIntegrationDefUpdateMethod.Screenshot,
                "search" => ToolsSpiderIntegrationDefUpdateMethod.Search,
                _ => null,
            };
        }
    }
}