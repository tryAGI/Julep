
#nullable enable

namespace Julep
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop`<br/>
    /// if the model hit a natural stop point or a provided stop sequence,<br/>
    /// `length` if the maximum number of tokens specified in the request<br/>
    /// was reached, `content_filter` if content was omitted due to a flag<br/>
    /// from our content filters, `tool_calls` if the model called a tool.
    /// </summary>
    public enum ChatFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReason value)
        {
            return value switch
            {
                ChatFinishReason.ContentFilter => "content_filter",
                ChatFinishReason.Length => "length",
                ChatFinishReason.Stop => "stop",
                ChatFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatFinishReason.ContentFilter,
                "length" => ChatFinishReason.Length,
                "stop" => ChatFinishReason.Stop,
                "tool_calls" => ChatFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}