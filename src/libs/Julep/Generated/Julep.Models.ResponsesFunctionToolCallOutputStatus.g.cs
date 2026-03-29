
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum ResponsesFunctionToolCallOutputStatus
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
    public static class ResponsesFunctionToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionToolCallOutputStatus value)
        {
            return value switch
            {
                ResponsesFunctionToolCallOutputStatus.Completed => "completed",
                ResponsesFunctionToolCallOutputStatus.InProgress => "in_progress",
                ResponsesFunctionToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponsesFunctionToolCallOutputStatus.Completed,
                "in_progress" => ResponsesFunctionToolCallOutputStatus.InProgress,
                "incomplete" => ResponsesFunctionToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}