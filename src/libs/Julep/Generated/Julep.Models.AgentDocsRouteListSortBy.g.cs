
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum AgentDocsRouteListSortBy
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
    public static class AgentDocsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDocsRouteListSortBy value)
        {
            return value switch
            {
                AgentDocsRouteListSortBy.CreatedAt => "created_at",
                AgentDocsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDocsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentDocsRouteListSortBy.CreatedAt,
                "updated_at" => AgentDocsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}