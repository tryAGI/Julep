
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: error<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksErrorWorkflowStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksErrorWorkflowStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksErrorWorkflowStepKind value)
        {
            return value switch
            {
                TasksErrorWorkflowStepKind.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksErrorWorkflowStepKind? ToEnum(string value)
        {
            return value switch
            {
                "error" => TasksErrorWorkflowStepKind.Error,
                _ => null,
            };
        }
    }
}