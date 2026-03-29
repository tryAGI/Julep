
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: cancelled
    /// </summary>
    public enum ExecutionsStopExecutionRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsStopExecutionRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsStopExecutionRequestStatus value)
        {
            return value switch
            {
                ExecutionsStopExecutionRequestStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsStopExecutionRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExecutionsStopExecutionRequestStatus.Cancelled,
                _ => null,
            };
        }
    }
}