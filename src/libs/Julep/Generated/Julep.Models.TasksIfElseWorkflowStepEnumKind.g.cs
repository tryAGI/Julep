
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksIfElseWorkflowStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        IfElse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksIfElseWorkflowStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksIfElseWorkflowStepEnumKind value)
        {
            return value switch
            {
                TasksIfElseWorkflowStepEnumKind.IfElse => "if_else",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksIfElseWorkflowStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "if_else" => TasksIfElseWorkflowStepEnumKind.IfElse,
                _ => null,
            };
        }
    }
}