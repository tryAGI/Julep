
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the computer use tool. Always `computer_use_preview`.
    /// </summary>
    public enum ResponsesComputerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesComputerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerToolType value)
        {
            return value switch
            {
                ResponsesComputerToolType.ComputerUsePreview => "computer_use_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => ResponsesComputerToolType.ComputerUsePreview,
                _ => null,
            };
        }
    }
}