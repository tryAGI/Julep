
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: get_live_urls
    /// </summary>
    public enum ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GetLiveUrls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod value)
        {
            return value switch
            {
                ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod.GetLiveUrls => "get_live_urls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod? ToEnum(string value)
        {
            return value switch
            {
                "get_live_urls" => ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod.GetLiveUrls,
                _ => null,
            };
        }
    }
}