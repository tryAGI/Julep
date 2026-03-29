
#nullable enable

namespace Julep
{
    /// <summary>
    /// The status of the sessions to list (Available options: RUNNING, ERROR, TIMED_OUT, COMPLETED)
    /// </summary>
    public enum ToolsBrowserbaseListSessionsArgumentsStatus
    {
        /// <summary>
        /// RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </summary>
        Completed,
        /// <summary>
        /// RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </summary>
        Error,
        /// <summary>
        /// RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </summary>
        Running,
        /// <summary>
        /// RUNNING, ERROR, TIMED_OUT, COMPLETED)
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsBrowserbaseListSessionsArgumentsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsBrowserbaseListSessionsArgumentsStatus value)
        {
            return value switch
            {
                ToolsBrowserbaseListSessionsArgumentsStatus.Completed => "COMPLETED",
                ToolsBrowserbaseListSessionsArgumentsStatus.Error => "ERROR",
                ToolsBrowserbaseListSessionsArgumentsStatus.Running => "RUNNING",
                ToolsBrowserbaseListSessionsArgumentsStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsBrowserbaseListSessionsArgumentsStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ToolsBrowserbaseListSessionsArgumentsStatus.Completed,
                "ERROR" => ToolsBrowserbaseListSessionsArgumentsStatus.Error,
                "RUNNING" => ToolsBrowserbaseListSessionsArgumentsStatus.Running,
                "TIMED_OUT" => ToolsBrowserbaseListSessionsArgumentsStatus.TimedOut,
                _ => null,
            };
        }
    }
}