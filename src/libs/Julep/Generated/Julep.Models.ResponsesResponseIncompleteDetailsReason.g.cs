
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesResponseIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesResponseIncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponseIncompleteDetailsReason value)
        {
            return value switch
            {
                ResponsesResponseIncompleteDetailsReason.ContentFilter => "content_filter",
                ResponsesResponseIncompleteDetailsReason.MaxOutputTokens => "max_output_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponseIncompleteDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ResponsesResponseIncompleteDetailsReason.ContentFilter,
                "max_output_tokens" => ResponsesResponseIncompleteDetailsReason.MaxOutputTokens,
                _ => null,
            };
        }
    }
}