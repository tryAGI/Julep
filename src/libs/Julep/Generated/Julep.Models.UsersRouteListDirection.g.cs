
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum UsersRouteListDirection
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
    public static class UsersRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersRouteListDirection value)
        {
            return value switch
            {
                UsersRouteListDirection.Asc => "asc",
                UsersRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => UsersRouteListDirection.Asc,
                "desc" => UsersRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}