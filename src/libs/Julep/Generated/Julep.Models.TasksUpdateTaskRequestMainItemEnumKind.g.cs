
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksUpdateTaskRequestMainItemEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksUpdateTaskRequestMainItemEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksUpdateTaskRequestMainItemEnumKind value)
        {
            return value switch
            {
                TasksUpdateTaskRequestMainItemEnumKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksUpdateTaskRequestMainItemEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksUpdateTaskRequestMainItemEnumKind.MapReduce,
                _ => null,
            };
        }
    }
}