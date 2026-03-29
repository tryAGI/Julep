
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum SessionsHybridDocSearchUpdateMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsHybridDocSearchUpdateModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsHybridDocSearchUpdateMode value)
        {
            return value switch
            {
                SessionsHybridDocSearchUpdateMode.Hybrid => "hybrid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsHybridDocSearchUpdateMode? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => SessionsHybridDocSearchUpdateMode.Hybrid,
                _ => null,
            };
        }
    }
}