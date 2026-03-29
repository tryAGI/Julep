
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "algolia"<br/>
    /// Default Value: algolia
    /// </summary>
    public enum ToolsAlgoliaIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Algolia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsAlgoliaIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsAlgoliaIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsAlgoliaIntegrationDefProvider.Algolia => "algolia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsAlgoliaIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "algolia" => ToolsAlgoliaIntegrationDefProvider.Algolia,
                _ => null,
            };
        }
    }
}