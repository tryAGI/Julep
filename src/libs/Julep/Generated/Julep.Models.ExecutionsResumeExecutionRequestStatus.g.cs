
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: running
    /// </summary>
    public enum ExecutionsResumeExecutionRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsResumeExecutionRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsResumeExecutionRequestStatus value)
        {
            return value switch
            {
                ExecutionsResumeExecutionRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsResumeExecutionRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => ExecutionsResumeExecutionRequestStatus.Running,
                _ => null,
            };
        }
    }
}