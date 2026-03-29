
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum AgentToolsRouteListDirection
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
    public static class AgentToolsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolsRouteListDirection value)
        {
            return value switch
            {
                AgentToolsRouteListDirection.Asc => "asc",
                AgentToolsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentToolsRouteListDirection.Asc,
                "desc" => AgentToolsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}