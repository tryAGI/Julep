
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: browserbase
    /// </summary>
    public enum ToolsBaseBrowserbaseIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Browserbase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBaseBrowserbaseIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBaseBrowserbaseIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsBaseBrowserbaseIntegrationDefUpdateProvider.Browserbase => "browserbase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBaseBrowserbaseIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "browserbase" => ToolsBaseBrowserbaseIntegrationDefUpdateProvider.Browserbase,
                _ => null,
            };
        }
    }
}