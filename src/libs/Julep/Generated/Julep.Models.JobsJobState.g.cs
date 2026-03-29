
#nullable enable

namespace Julep
{
    /// <summary>
    /// Current state (one of: pending, in_progress, retrying, succeeded, aborted, failed)
    /// </summary>
    public enum JobsJobState
    {
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        Aborted,
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        Failed,
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        InProgress,
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        Pending,
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        Retrying,
        /// <summary>
        /// pending, in_progress, retrying, succeeded, aborted, failed)
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsJobStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsJobState value)
        {
            return value switch
            {
                JobsJobState.Aborted => "aborted",
                JobsJobState.Failed => "failed",
                JobsJobState.InProgress => "in_progress",
                JobsJobState.Pending => "pending",
                JobsJobState.Retrying => "retrying",
                JobsJobState.Succeeded => "succeeded",
                JobsJobState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsJobState? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => JobsJobState.Aborted,
                "failed" => JobsJobState.Failed,
                "in_progress" => JobsJobState.InProgress,
                "pending" => JobsJobState.Pending,
                "retrying" => JobsJobState.Retrying,
                "succeeded" => JobsJobState.Succeeded,
                "unknown" => JobsJobState.Unknown,
                _ => null,
            };
        }
    }
}