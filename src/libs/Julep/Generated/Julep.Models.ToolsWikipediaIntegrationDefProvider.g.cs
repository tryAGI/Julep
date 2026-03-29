
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "wikipedia"<br/>
    /// Default Value: wikipedia
    /// </summary>
    public enum ToolsWikipediaIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Wikipedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsWikipediaIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsWikipediaIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsWikipediaIntegrationDefProvider.Wikipedia => "wikipedia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsWikipediaIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "wikipedia" => ToolsWikipediaIntegrationDefProvider.Wikipedia,
                _ => null,
            };
        }
    }
}