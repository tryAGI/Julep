
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the computer tool call output. Always `computer_call_output`.
    /// </summary>
    public enum ResponsesComputerToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesComputerToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerToolCallOutputType value)
        {
            return value switch
            {
                ResponsesComputerToolCallOutputType.ComputerCallOutput => "computer_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output" => ResponsesComputerToolCallOutputType.ComputerCallOutput,
                _ => null,
            };
        }
    }
}