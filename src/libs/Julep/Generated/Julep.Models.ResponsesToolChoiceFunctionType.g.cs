
#nullable enable

namespace Julep
{
    /// <summary>
    /// For function calling, the type is always `function`.
    /// </summary>
    public enum ResponsesToolChoiceFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesToolChoiceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesToolChoiceFunctionType value)
        {
            return value switch
            {
                ResponsesToolChoiceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesToolChoiceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ResponsesToolChoiceFunctionType.Function,
                _ => null,
            };
        }
    }
}