
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum DeveloperSecretsRouteListDirection
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
    public static class DeveloperSecretsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeveloperSecretsRouteListDirection value)
        {
            return value switch
            {
                DeveloperSecretsRouteListDirection.Asc => "asc",
                DeveloperSecretsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeveloperSecretsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => DeveloperSecretsRouteListDirection.Asc,
                "desc" => DeveloperSecretsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}