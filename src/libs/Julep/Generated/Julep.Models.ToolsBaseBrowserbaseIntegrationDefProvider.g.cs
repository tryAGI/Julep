
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: browserbase
    /// </summary>
    public enum ToolsBaseBrowserbaseIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Browserbase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseBrowserbaseIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseBrowserbaseIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsBaseBrowserbaseIntegrationDefProvider.Browserbase => "browserbase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseBrowserbaseIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "browserbase" => ToolsBaseBrowserbaseIntegrationDefProvider.Browserbase,
                _ => null,
            };
        }
    }
}