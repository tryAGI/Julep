
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum ResponsesComputerToolCallStatus
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
    public static class ResponsesComputerToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerToolCallStatus value)
        {
            return value switch
            {
                ResponsesComputerToolCallStatus.Completed => "completed",
                ResponsesComputerToolCallStatus.InProgress => "in_progress",
                ResponsesComputerToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesComputerToolCallStatus.Completed,
                "in_progress" => ResponsesComputerToolCallStatus.InProgress,
                "incomplete" => ResponsesComputerToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}