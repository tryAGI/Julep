
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum ExecutionTransitionsRouteListSortBy
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
    public static class ExecutionTransitionsRouteListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionTransitionsRouteListSortBy value)
        {
            return value switch
            {
                ExecutionTransitionsRouteListSortBy.CreatedAt => "created_at",
                ExecutionTransitionsRouteListSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionTransitionsRouteListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ExecutionTransitionsRouteListSortBy.CreatedAt,
                "updated_at" => ExecutionTransitionsRouteListSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}