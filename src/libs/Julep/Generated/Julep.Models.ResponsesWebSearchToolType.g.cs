
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesWebSearchToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchToolType value)
        {
            return value switch
            {
                ResponsesWebSearchToolType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => ResponsesWebSearchToolType.WebSearchPreview,
                _ => null,
            };
        }
    }
}