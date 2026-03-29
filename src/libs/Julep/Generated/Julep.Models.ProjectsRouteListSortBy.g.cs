
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum ProjectsRouteListSortBy
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
    public static class ProjectsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsRouteListSortBy value)
        {
            return value switch
            {
                ProjectsRouteListSortBy.CreatedAt => "created_at",
                ProjectsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ProjectsRouteListSortBy.CreatedAt,
                "updated_at" => ProjectsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}