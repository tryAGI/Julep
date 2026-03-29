
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the function tool call output. Always `function_call_output`.
    /// </summary>
    public enum ResponsesFunctionToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFunctionToolCallOutputType value)
        {
            return value switch
            {
                ResponsesFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => ResponsesFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}