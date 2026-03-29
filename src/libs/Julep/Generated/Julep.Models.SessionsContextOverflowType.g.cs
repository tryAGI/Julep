
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionsContextOverflowType
    {
        /// <summary>
        /// 
        /// </summary>
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        Truncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsContextOverflowTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsContextOverflowType value)
        {
            return value switch
            {
                SessionsContextOverflowType.Adaptive => "adaptive",
                SessionsContextOverflowType.Truncate => "truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsContextOverflowType? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => SessionsContextOverflowType.Adaptive,
                "truncate" => SessionsContextOverflowType.Truncate,
                _ => null,
            };
        }
    }
}