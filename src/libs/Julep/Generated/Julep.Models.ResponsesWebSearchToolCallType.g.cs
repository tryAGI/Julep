
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the web search tool call. Always `web_search_call`.
    /// </summary>
    public enum ResponsesWebSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchToolCallType value)
        {
            return value switch
            {
                ResponsesWebSearchToolCallType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => ResponsesWebSearchToolCallType.WebSearchCall,
                _ => null,
            };
        }
    }
}