
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksSleepStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Sleep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksSleepStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksSleepStepEnumKind value)
        {
            return value switch
            {
                TasksSleepStepEnumKind.Sleep => "sleep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksSleepStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "sleep" => TasksSleepStepEnumKind.Sleep,
                _ => null,
            };
        }
    }
}