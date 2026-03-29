
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: if_else<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksIfElseWorkflowStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        IfElse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksIfElseWorkflowStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksIfElseWorkflowStepKind value)
        {
            return value switch
            {
                TasksIfElseWorkflowStepKind.IfElse => "if_else",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksIfElseWorkflowStepKind? ToEnum(string value)
        {
            return value switch
            {
                "if_else" => TasksIfElseWorkflowStepKind.IfElse,
                _ => null,
            };
        }
    }
}