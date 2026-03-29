
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ProjectsRouteListDirection
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
    public static class ProjectsRouteListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsRouteListDirection value)
        {
            return value switch
            {
                ProjectsRouteListDirection.Asc => "asc",
                ProjectsRouteListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsRouteListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ProjectsRouteListDirection.Asc,
                "desc" => ProjectsRouteListDirection.Desc,
                _ => null,
            };
        }
    }
}