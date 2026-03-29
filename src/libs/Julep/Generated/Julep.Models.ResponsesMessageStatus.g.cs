
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesMessageStatus
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
    public static class ResponsesMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesMessageStatus value)
        {
            return value switch
            {
                ResponsesMessageStatus.Completed => "completed",
                ResponsesMessageStatus.InProgress => "in_progress",
                ResponsesMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesMessageStatus.Completed,
                "in_progress" => ResponsesMessageStatus.InProgress,
                "incomplete" => ResponsesMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}