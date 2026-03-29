
#nullable enable

namespace Julep
{
    /// <summary>
    /// The mode to use for the search.<br/>
    /// Default Value: vector
    /// </summary>
    public enum SessionsVectorDocSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsVectorDocSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsVectorDocSearchMode value)
        {
            return value switch
            {
                SessionsVectorDocSearchMode.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsVectorDocSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "vector" => SessionsVectorDocSearchMode.Vector,
                _ => null,
            };
        }
    }
}