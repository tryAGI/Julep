
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesWebSearchToolSearchContextSize
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchToolSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchToolSearchContextSize value)
        {
            return value switch
            {
                ResponsesWebSearchToolSearchContextSize.Large => "large",
                ResponsesWebSearchToolSearchContextSize.Medium => "medium",
                ResponsesWebSearchToolSearchContextSize.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchToolSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => ResponsesWebSearchToolSearchContextSize.Large,
                "medium" => ResponsesWebSearchToolSearchContextSize.Medium,
                "small" => ResponsesWebSearchToolSearchContextSize.Small,
                _ => null,
            };
        }
    }
}