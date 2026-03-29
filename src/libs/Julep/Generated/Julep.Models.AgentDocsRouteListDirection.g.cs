
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum AgentDocsRouteListDirection
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
    public static class AgentDocsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDocsRouteListDirection value)
        {
            return value switch
            {
                AgentDocsRouteListDirection.Asc => "asc",
                AgentDocsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDocsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentDocsRouteListDirection.Asc,
                "desc" => AgentDocsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}