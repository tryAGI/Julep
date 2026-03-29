
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum ResponsesReasoningItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningItemStatus value)
        {
            return value switch
            {
                ResponsesReasoningItemStatus.Completed => "completed",
                ResponsesReasoningItemStatus.InProgress => "in_progress",
                ResponsesReasoningItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesReasoningItemStatus.Completed,
                "in_progress" => ResponsesReasoningItemStatus.InProgress,
                "incomplete" => ResponsesReasoningItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}