
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: map_reduce<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksUpdateTaskRequestItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksUpdateTaskRequestItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksUpdateTaskRequestItemKind value)
        {
            return value switch
            {
                TasksUpdateTaskRequestItemKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksUpdateTaskRequestItemKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksUpdateTaskRequestItemKind.MapReduce,
                _ => null,
            };
        }
    }
}