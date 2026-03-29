
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ExecutionTransitionsRouteListDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionTransitionsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionTransitionsRouteListDirection value)
        {
            return value switch
            {
                ExecutionTransitionsRouteListDirection.Asc => "asc",
                ExecutionTransitionsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionTransitionsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ExecutionTransitionsRouteListDirection.Asc,
                "desc" => ExecutionTransitionsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}