
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum AgentsRouteListSortBy
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
    public static class AgentsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsRouteListSortBy value)
        {
            return value switch
            {
                AgentsRouteListSortBy.CreatedAt => "created_at",
                AgentsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentsRouteListSortBy.CreatedAt,
                "updated_at" => AgentsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}