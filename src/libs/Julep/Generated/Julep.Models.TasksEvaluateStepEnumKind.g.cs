
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksEvaluateStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksEvaluateStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksEvaluateStepEnumKind value)
        {
            return value switch
            {
                TasksEvaluateStepEnumKind.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksEvaluateStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "evaluate" => TasksEvaluateStepEnumKind.Evaluate,
                _ => null,
            };
        }
    }
}