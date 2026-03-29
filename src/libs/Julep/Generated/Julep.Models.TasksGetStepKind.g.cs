
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: get<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksGetStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksGetStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksGetStepKind value)
        {
            return value switch
            {
                TasksGetStepKind.Get => "get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksGetStepKind? ToEnum(string value)
        {
            return value switch
            {
                "get" => TasksGetStepKind.Get,
                _ => null,
            };
        }
    }
}