
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum TaskExecutionsRouteListSortBy
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
    public static class TaskExecutionsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskExecutionsRouteListSortBy value)
        {
            return value switch
            {
                TaskExecutionsRouteListSortBy.CreatedAt => "created_at",
                TaskExecutionsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskExecutionsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => TaskExecutionsRouteListSortBy.CreatedAt,
                "updated_at" => TaskExecutionsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}