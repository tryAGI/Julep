
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionsUpdateExecutionRequestDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsUpdateExecutionRequestDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsUpdateExecutionRequestDiscriminatorStatus value)
        {
            return value switch
            {
                ExecutionsUpdateExecutionRequestDiscriminatorStatus.Cancelled => "cancelled",
                ExecutionsUpdateExecutionRequestDiscriminatorStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsUpdateExecutionRequestDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExecutionsUpdateExecutionRequestDiscriminatorStatus.Cancelled,
                "running" => ExecutionsUpdateExecutionRequestDiscriminatorStatus.Running,
                _ => null,
            };
        }
    }
}