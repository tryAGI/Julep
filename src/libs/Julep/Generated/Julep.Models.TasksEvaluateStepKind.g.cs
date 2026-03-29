
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: evaluate<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksEvaluateStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksEvaluateStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksEvaluateStepKind value)
        {
            return value switch
            {
                TasksEvaluateStepKind.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksEvaluateStepKind? ToEnum(string value)
        {
            return value switch
            {
                "evaluate" => TasksEvaluateStepKind.Evaluate,
                _ => null,
            };
        }
    }
}