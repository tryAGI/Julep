
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the file search tool call. Always `file_search_call`.
    /// </summary>
    public enum ResponsesFileSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFileSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFileSearchToolCallType value)
        {
            return value switch
            {
                ResponsesFileSearchToolCallType.FileSearchCall => "file_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFileSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call" => ResponsesFileSearchToolCallType.FileSearchCall,
                _ => null,
            };
        }
    }
}