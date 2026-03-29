
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: running
    /// </summary>
    public enum ExecutionsTaskTokenResumeExecutionRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsTaskTokenResumeExecutionRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsTaskTokenResumeExecutionRequestStatus value)
        {
            return value switch
            {
                ExecutionsTaskTokenResumeExecutionRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsTaskTokenResumeExecutionRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => ExecutionsTaskTokenResumeExecutionRequestStatus.Running,
                _ => null,
            };
        }
    }
}