
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the computer call. Always `computer_call`.
    /// </summary>
    public enum ResponsesComputerToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesComputerToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerToolCallType value)
        {
            return value switch
            {
                ResponsesComputerToolCallType.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => ResponsesComputerToolCallType.ComputerCall,
                _ => null,
            };
        }
    }
}