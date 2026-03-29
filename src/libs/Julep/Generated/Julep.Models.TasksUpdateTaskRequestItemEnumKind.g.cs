
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksUpdateTaskRequestItemEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksUpdateTaskRequestItemEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksUpdateTaskRequestItemEnumKind value)
        {
            return value switch
            {
                TasksUpdateTaskRequestItemEnumKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksUpdateTaskRequestItemEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksUpdateTaskRequestItemEnumKind.MapReduce,
                _ => null,
            };
        }
    }
}