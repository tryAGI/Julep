
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum AgentsRouteListDirection
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
    public static class AgentsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsRouteListDirection value)
        {
            return value switch
            {
                AgentsRouteListDirection.Asc => "asc",
                AgentsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentsRouteListDirection.Asc,
                "desc" => AgentsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}