
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: set<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksSetStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksSetStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksSetStepKind value)
        {
            return value switch
            {
                TasksSetStepKind.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksSetStepKind? ToEnum(string value)
        {
            return value switch
            {
                "set" => TasksSetStepKind.Set,
                _ => null,
            };
        }
    }
}