
#nullable enable

namespace Julep
{
    /// <summary>
    /// How dates, times, and durations should be represented<br/>
    /// Default Value: FORMATTED_STRING
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption
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
    public static class ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption.FormattedString => "FORMATTED_STRING",
                ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption.SerialNumber => "SERIAL_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_STRING" => ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption.FormattedString,
                "SERIAL_NUMBER" => ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption.SerialNumber,
                _ => null,
            };
        }
    }
}