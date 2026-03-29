
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum TasksRouteListSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksRouteListSortBy value)
        {
            return value switch
            {
                TasksRouteListSortBy.CreatedAt => "created_at",
                TasksRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => TasksRouteListSortBy.CreatedAt,
                "updated_at" => TasksRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}