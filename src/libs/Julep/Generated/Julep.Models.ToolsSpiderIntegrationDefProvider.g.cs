
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "spider"<br/>
    /// Default Value: spider
    /// </summary>
    public enum ToolsSpiderIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Spider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSpiderIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsSpiderIntegrationDefProvider.Spider => "spider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "spider" => ToolsSpiderIntegrationDefProvider.Spider,
                _ => null,
            };
        }
    }
}