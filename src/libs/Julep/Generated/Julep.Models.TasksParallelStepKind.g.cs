
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: parallel<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksParallelStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksParallelStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksParallelStepKind value)
        {
            return value switch
            {
                TasksParallelStepKind.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksParallelStepKind? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => TasksParallelStepKind.Parallel,
                _ => null,
            };
        }
    }
}