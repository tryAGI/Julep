
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksCreateTaskRequestMainItemEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksCreateTaskRequestMainItemEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateTaskRequestMainItemEnumKind value)
        {
            return value switch
            {
                TasksCreateTaskRequestMainItemEnumKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateTaskRequestMainItemEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksCreateTaskRequestMainItemEnumKind.MapReduce,
                _ => null,
            };
        }
    }
}