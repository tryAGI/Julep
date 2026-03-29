
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum SessionsRouteListSortBy
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
    public static class SessionsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsRouteListSortBy value)
        {
            return value switch
            {
                SessionsRouteListSortBy.CreatedAt => "created_at",
                SessionsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => SessionsRouteListSortBy.CreatedAt,
                "updated_at" => SessionsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}