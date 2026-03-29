
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionsUpdateExecutionRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AwaitingInput,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsUpdateExecutionRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsUpdateExecutionRequestStatus value)
        {
            return value switch
            {
                ExecutionsUpdateExecutionRequestStatus.AwaitingInput => "awaiting_input",
                ExecutionsUpdateExecutionRequestStatus.Cancelled => "cancelled",
                ExecutionsUpdateExecutionRequestStatus.Failed => "failed",
                ExecutionsUpdateExecutionRequestStatus.Queued => "queued",
                ExecutionsUpdateExecutionRequestStatus.Running => "running",
                ExecutionsUpdateExecutionRequestStatus.Starting => "starting",
                ExecutionsUpdateExecutionRequestStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsUpdateExecutionRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_input" => ExecutionsUpdateExecutionRequestStatus.AwaitingInput,
                "cancelled" => ExecutionsUpdateExecutionRequestStatus.Cancelled,
                "failed" => ExecutionsUpdateExecutionRequestStatus.Failed,
                "queued" => ExecutionsUpdateExecutionRequestStatus.Queued,
                "running" => ExecutionsUpdateExecutionRequestStatus.Running,
                "starting" => ExecutionsUpdateExecutionRequestStatus.Starting,
                "succeeded" => ExecutionsUpdateExecutionRequestStatus.Succeeded,
                _ => null,
            };
        }
    }
}