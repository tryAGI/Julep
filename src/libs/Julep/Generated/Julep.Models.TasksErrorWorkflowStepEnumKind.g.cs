
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksErrorWorkflowStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksErrorWorkflowStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksErrorWorkflowStepEnumKind value)
        {
            return value switch
            {
                TasksErrorWorkflowStepEnumKind.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksErrorWorkflowStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "error" => TasksErrorWorkflowStepEnumKind.Error,
                _ => null,
            };
        }
    }
}