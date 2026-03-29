
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum AgentToolsRouteListSortBy
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
    public static class AgentToolsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolsRouteListSortBy value)
        {
            return value switch
            {
                AgentToolsRouteListSortBy.CreatedAt => "created_at",
                AgentToolsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentToolsRouteListSortBy.CreatedAt,
                "updated_at" => AgentToolsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}