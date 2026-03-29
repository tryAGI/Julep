
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum ResponsesFunctionToolCallStatus
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
    public static class ResponsesFunctionToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionToolCallStatus value)
        {
            return value switch
            {
                ResponsesFunctionToolCallStatus.Completed => "completed",
                ResponsesFunctionToolCallStatus.InProgress => "in_progress",
                ResponsesFunctionToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesFunctionToolCallStatus.Completed,
                "in_progress" => ResponsesFunctionToolCallStatus.InProgress,
                "incomplete" => ResponsesFunctionToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}