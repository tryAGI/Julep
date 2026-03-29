
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the function tool call. Always `function_call`.
    /// </summary>
    public enum ResponsesFunctionToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionToolCallType value)
        {
            return value switch
            {
                ResponsesFunctionToolCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponsesFunctionToolCallType.FunctionCall,
                _ => null,
            };
        }
    }
}