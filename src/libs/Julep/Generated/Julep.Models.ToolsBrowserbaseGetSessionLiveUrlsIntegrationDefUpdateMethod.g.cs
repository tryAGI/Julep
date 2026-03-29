
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: get_live_urls
    /// </summary>
    public enum ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GetLiveUrls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod.GetLiveUrls => "get_live_urls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod? ToEnum(string value)
        {
            return value switch
            {
                "get_live_urls" => ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod.GetLiveUrls,
                _ => null,
            };
        }
    }
}