
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksParallelStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksParallelStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksParallelStepEnumKind value)
        {
            return value switch
            {
                TasksParallelStepEnumKind.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksParallelStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => TasksParallelStepEnumKind.Parallel,
                _ => null,
            };
        }
    }
}