
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: sleep<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksSleepStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Sleep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksSleepStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksSleepStepKind value)
        {
            return value switch
            {
                TasksSleepStepKind.Sleep => "sleep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksSleepStepKind? ToEnum(string value)
        {
            return value switch
            {
                "sleep" => TasksSleepStepKind.Sleep,
                _ => null,
            };
        }
    }
}