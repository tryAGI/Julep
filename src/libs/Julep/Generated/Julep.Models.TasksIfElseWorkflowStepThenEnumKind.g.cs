
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksIfElseWorkflowStepThenEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksIfElseWorkflowStepThenEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksIfElseWorkflowStepThenEnumKind value)
        {
            return value switch
            {
                TasksIfElseWorkflowStepThenEnumKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksIfElseWorkflowStepThenEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksIfElseWorkflowStepThenEnumKind.MapReduce,
                _ => null,
            };
        }
    }
}