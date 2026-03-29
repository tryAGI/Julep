
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksReturnStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Return,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksReturnStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksReturnStepEnumKind value)
        {
            return value switch
            {
                TasksReturnStepEnumKind.Return => "return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksReturnStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "return" => TasksReturnStepEnumKind.Return,
                _ => null,
            };
        }
    }
}