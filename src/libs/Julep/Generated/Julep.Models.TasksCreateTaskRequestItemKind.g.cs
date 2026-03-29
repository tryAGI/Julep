
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: map_reduce<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksCreateTaskRequestItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        MapReduce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksCreateTaskRequestItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateTaskRequestItemKind value)
        {
            return value switch
            {
                TasksCreateTaskRequestItemKind.MapReduce => "map_reduce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateTaskRequestItemKind? ToEnum(string value)
        {
            return value switch
            {
                "map_reduce" => TasksCreateTaskRequestItemKind.MapReduce,
                _ => null,
            };
        }
    }
}