
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.
    /// </summary>
    public enum ResponsesUrlCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesUrlCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesUrlCitationType value)
        {
            return value switch
            {
                ResponsesUrlCitationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesUrlCitationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => ResponsesUrlCitationType.UrlCitation,
                _ => null,
            };
        }
    }
}