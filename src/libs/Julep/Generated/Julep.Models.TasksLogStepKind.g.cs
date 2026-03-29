
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: log<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksLogStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Log,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksLogStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksLogStepKind value)
        {
            return value switch
            {
                TasksLogStepKind.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksLogStepKind? ToEnum(string value)
        {
            return value switch
            {
                "log" => TasksLogStepKind.Log,
                _ => null,
            };
        }
    }
}