
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: yield<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksYieldStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Yield,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksYieldStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksYieldStepKind value)
        {
            return value switch
            {
                TasksYieldStepKind.Yield => "yield",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksYieldStepKind? ToEnum(string value)
        {
            return value switch
            {
                "yield" => TasksYieldStepKind.Yield,
                _ => null,
            };
        }
    }
}