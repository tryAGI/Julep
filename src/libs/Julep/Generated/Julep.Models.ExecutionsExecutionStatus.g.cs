
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the execution<br/>
    /// Included only in responses
    /// </summary>
    public enum ExecutionsExecutionStatus
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
    public static class ExecutionsExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsExecutionStatus value)
        {
            return value switch
            {
                ExecutionsExecutionStatus.AwaitingInput => "awaiting_input",
                ExecutionsExecutionStatus.Cancelled => "cancelled",
                ExecutionsExecutionStatus.Failed => "failed",
                ExecutionsExecutionStatus.Queued => "queued",
                ExecutionsExecutionStatus.Running => "running",
                ExecutionsExecutionStatus.Starting => "starting",
                ExecutionsExecutionStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_input" => ExecutionsExecutionStatus.AwaitingInput,
                "cancelled" => ExecutionsExecutionStatus.Cancelled,
                "failed" => ExecutionsExecutionStatus.Failed,
                "queued" => ExecutionsExecutionStatus.Queued,
                "running" => ExecutionsExecutionStatus.Running,
                "starting" => ExecutionsExecutionStatus.Starting,
                "succeeded" => ExecutionsExecutionStatus.Succeeded,
                _ => null,
            };
        }
    }
}