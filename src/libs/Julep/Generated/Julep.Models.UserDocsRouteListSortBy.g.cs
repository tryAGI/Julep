
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum UserDocsRouteListSortBy
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
    public static class UserDocsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserDocsRouteListSortBy value)
        {
            return value switch
            {
                UserDocsRouteListSortBy.CreatedAt => "created_at",
                UserDocsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserDocsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => UserDocsRouteListSortBy.CreatedAt,
                "updated_at" => UserDocsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}