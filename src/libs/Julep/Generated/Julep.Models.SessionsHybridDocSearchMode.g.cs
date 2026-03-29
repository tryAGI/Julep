
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum SessionsHybridDocSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsHybridDocSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsHybridDocSearchMode value)
        {
            return value switch
            {
                SessionsHybridDocSearchMode.Hybrid => "hybrid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsHybridDocSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => SessionsHybridDocSearchMode.Hybrid,
                _ => null,
            };
        }
    }
}