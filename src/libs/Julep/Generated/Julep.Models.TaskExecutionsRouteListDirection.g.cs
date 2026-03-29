
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum TaskExecutionsRouteListDirection
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
    public static class TaskExecutionsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskExecutionsRouteListDirection value)
        {
            return value switch
            {
                TaskExecutionsRouteListDirection.Asc => "asc",
                TaskExecutionsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskExecutionsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => TaskExecutionsRouteListDirection.Asc,
                "desc" => TaskExecutionsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}