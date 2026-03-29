
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "spider"<br/>
    /// Default Value: spider
    /// </summary>
    public enum ToolsSpiderIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Spider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSpiderIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSpiderIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsSpiderIntegrationDefUpdateProvider.Spider => "spider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSpiderIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "spider" => ToolsSpiderIntegrationDefUpdateProvider.Spider,
                _ => null,
            };
        }
    }
}