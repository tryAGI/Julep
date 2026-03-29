
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "algolia"<br/>
    /// Default Value: algolia
    /// </summary>
    public enum ToolsAlgoliaIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Algolia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsAlgoliaIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsAlgoliaIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsAlgoliaIntegrationDefUpdateProvider.Algolia => "algolia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsAlgoliaIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsAlgoliaIntegrationDefUpdateProvider.Algolia,
                _ => null,
            };
        }
    }
}