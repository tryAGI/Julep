
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesWebSearchStatus
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
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesWebSearchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesWebSearchStatus value)
        {
            return value switch
            {
                ResponsesWebSearchStatus.Completed => "completed",
                ResponsesWebSearchStatus.Failed => "failed",
                ResponsesWebSearchStatus.InProgress => "in_progress",
                ResponsesWebSearchStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesWebSearchStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesWebSearchStatus.Completed,
                "failed" => ResponsesWebSearchStatus.Failed,
                "in_progress" => ResponsesWebSearchStatus.InProgress,
                "searching" => ResponsesWebSearchStatus.Searching,
                _ => null,
            };
        }
    }
}