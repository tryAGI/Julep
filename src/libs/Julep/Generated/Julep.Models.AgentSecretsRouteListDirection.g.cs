
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum AgentSecretsRouteListDirection
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
    public static class AgentSecretsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSecretsRouteListDirection value)
        {
            return value switch
            {
                AgentSecretsRouteListDirection.Asc => "asc",
                AgentSecretsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSecretsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentSecretsRouteListDirection.Asc,
                "desc" => AgentSecretsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}