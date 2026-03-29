
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum AgentSecretsRouteListSortBy
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
    public static class AgentSecretsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSecretsRouteListSortBy value)
        {
            return value switch
            {
                AgentSecretsRouteListSortBy.CreatedAt => "created_at",
                AgentSecretsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSecretsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentSecretsRouteListSortBy.CreatedAt,
                "updated_at" => AgentSecretsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}