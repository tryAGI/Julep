
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum TasksRouteListDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksRouteListDirection value)
        {
            return value switch
            {
                TasksRouteListDirection.Asc => "asc",
                TasksRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => TasksRouteListDirection.Asc,
                "desc" => TasksRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}