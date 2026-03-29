
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: map_reduce<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksIfElseWorkflowStepThenKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksIfElseWorkflowStepThenKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksIfElseWorkflowStepThenKind value)
        {
            return value switch
            {
                TasksIfElseWorkflowStepThenKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksIfElseWorkflowStepThenKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksIfElseWorkflowStepThenKind.MapReduce,
                _ => null,
            };
        }
    }
}