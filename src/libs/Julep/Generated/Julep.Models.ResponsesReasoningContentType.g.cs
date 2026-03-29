
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the object. Always `text`.
    /// </summary>
    public enum ResponsesReasoningContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningContentType value)
        {
            return value switch
            {
                ResponsesReasoningContentType.ReasoningSummary => "reasoning_summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningContentType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_summary" => ResponsesReasoningContentType.ReasoningSummary,
                _ => null,
            };
        }
    }
}