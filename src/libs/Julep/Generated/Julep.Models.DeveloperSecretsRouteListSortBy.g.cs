
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum DeveloperSecretsRouteListSortBy
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
    public static class DeveloperSecretsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeveloperSecretsRouteListSortBy value)
        {
            return value switch
            {
                DeveloperSecretsRouteListSortBy.CreatedAt => "created_at",
                DeveloperSecretsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeveloperSecretsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => DeveloperSecretsRouteListSortBy.CreatedAt,
                "updated_at" => DeveloperSecretsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}