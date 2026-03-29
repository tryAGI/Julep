
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: return<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksReturnStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Return,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksReturnStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksReturnStepKind value)
        {
            return value switch
            {
                TasksReturnStepKind.Return => "return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksReturnStepKind? ToEnum(string value)
        {
            return value switch
            {
                "return" => TasksReturnStepKind.Return,
                _ => null,
            };
        }
    }
}