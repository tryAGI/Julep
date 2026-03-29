
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: vector
    /// </summary>
    public enum SessionsVectorDocSearchUpdateMode
    {
        /// <summary>
        /// 
        /// </summary>
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsVectorDocSearchUpdateModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsVectorDocSearchUpdateMode value)
        {
            return value switch
            {
                SessionsVectorDocSearchUpdateMode.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsVectorDocSearchUpdateMode? ToEnum(string value)
        {
            return value switch
            {
                "vector" => SessionsVectorDocSearchUpdateMode.Vector,
                _ => null,
            };
        }
    }
}