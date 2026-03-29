
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "wikipedia"<br/>
    /// Default Value: wikipedia
    /// </summary>
    public enum ToolsWikipediaIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Wikipedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsWikipediaIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsWikipediaIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsWikipediaIntegrationDefUpdateProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsWikipediaIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "wikipedia" => ToolsWikipediaIntegrationDefUpdateProvider.Wikipedia,
                _ => null,
            };
        }
    }
}