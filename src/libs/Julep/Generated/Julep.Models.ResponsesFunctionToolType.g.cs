
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesFunctionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionToolType value)
        {
            return value switch
            {
                ResponsesFunctionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ResponsesFunctionToolType.Function,
                _ => null,
            };
        }
    }
}