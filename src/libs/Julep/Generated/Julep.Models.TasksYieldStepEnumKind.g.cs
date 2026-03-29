
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksYieldStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Yield,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksYieldStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksYieldStepEnumKind value)
        {
            return value switch
            {
                TasksYieldStepEnumKind.Yield => "yield",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksYieldStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "yield" => TasksYieldStepEnumKind.Yield,
                _ => null,
            };
        }
    }
}