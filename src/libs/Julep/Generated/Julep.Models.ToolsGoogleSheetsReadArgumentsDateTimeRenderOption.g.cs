
#nullable enable

namespace Julep
{
    /// <summary>
    /// How dates, times, and durations should be represented<br/>
    /// Default Value: FORMATTED_STRING
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsDateTimeRenderOption
    {
        /// <summary>
        /// 
        /// </summary>
        FormattedString,
        /// <summary>
        /// 
        /// </summary>
        SerialNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsReadArgumentsDateTimeRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsDateTimeRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsDateTimeRenderOption.FormattedString => "FORMATTED_STRING",
                ToolsGoogleSheetsReadArgumentsDateTimeRenderOption.SerialNumber => "SERIAL_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsDateTimeRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_STRING" => ToolsGoogleSheetsReadArgumentsDateTimeRenderOption.FormattedString,
                "SERIAL_NUMBER" => ToolsGoogleSheetsReadArgumentsDateTimeRenderOption.SerialNumber,
                _ => null,
            };
        }
    }
}