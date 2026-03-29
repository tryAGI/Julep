
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum SessionsRouteListDirection
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
    public static class SessionsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsRouteListDirection value)
        {
            return value switch
            {
                SessionsRouteListDirection.Asc => "asc",
                SessionsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SessionsRouteListDirection.Asc,
                "desc" => SessionsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}