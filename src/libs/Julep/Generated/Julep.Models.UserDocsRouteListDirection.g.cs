
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum UserDocsRouteListDirection
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
    public static class UserDocsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserDocsRouteListDirection value)
        {
            return value switch
            {
                UserDocsRouteListDirection.Asc => "asc",
                UserDocsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserDocsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => UserDocsRouteListDirection.Asc,
                "desc" => UserDocsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}