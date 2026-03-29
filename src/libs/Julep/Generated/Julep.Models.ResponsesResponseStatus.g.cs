
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
    public static class ResponsesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesResponseStatus value)
        {
            return value switch
            {
                ResponsesResponseStatus.Completed => "completed",
                ResponsesResponseStatus.Failed => "failed",
                ResponsesResponseStatus.InProgress => "in_progress",
                ResponsesResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesResponseStatus.Completed,
                "failed" => ResponsesResponseStatus.Failed,
                "in_progress" => ResponsesResponseStatus.InProgress,
                "incomplete" => ResponsesResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}