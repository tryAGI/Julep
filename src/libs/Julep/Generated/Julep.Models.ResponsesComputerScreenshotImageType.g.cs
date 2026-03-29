
#nullable enable

namespace Julep
{
    /// <summary>
    /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.
    /// </summary>
    public enum ResponsesComputerScreenshotImageType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerScreenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesComputerScreenshotImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesComputerScreenshotImageType value)
        {
            return value switch
            {
                ResponsesComputerScreenshotImageType.ComputerScreenshot => "computer_screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesComputerScreenshotImageType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => ResponsesComputerScreenshotImageType.ComputerScreenshot,
                _ => null,
            };
        }
    }
}