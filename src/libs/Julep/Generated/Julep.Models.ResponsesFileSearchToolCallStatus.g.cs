
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the file search tool call. One of `in_progress`, `searching`, `incomplete` or `failed`
    /// </summary>
    public enum ResponsesFileSearchToolCallStatus
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
        /// <summary>
        /// 
        /// </summary>
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFileSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFileSearchToolCallStatus value)
        {
            return value switch
            {
                ResponsesFileSearchToolCallStatus.Completed => "completed",
                ResponsesFileSearchToolCallStatus.Failed => "failed",
                ResponsesFileSearchToolCallStatus.InProgress => "in_progress",
                ResponsesFileSearchToolCallStatus.Incomplete => "incomplete",
                ResponsesFileSearchToolCallStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFileSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesFileSearchToolCallStatus.Completed,
                "failed" => ResponsesFileSearchToolCallStatus.Failed,
                "in_progress" => ResponsesFileSearchToolCallStatus.InProgress,
                "incomplete" => ResponsesFileSearchToolCallStatus.Incomplete,
                "searching" => ResponsesFileSearchToolCallStatus.Searching,
                _ => null,
            };
        }
    }
}