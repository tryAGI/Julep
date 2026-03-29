
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum UsersRouteListSortBy
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
    public static class UsersRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersRouteListSortBy value)
        {
            return value switch
            {
                UsersRouteListSortBy.CreatedAt => "created_at",
                UsersRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => UsersRouteListSortBy.CreatedAt,
                "updated_at" => UsersRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}