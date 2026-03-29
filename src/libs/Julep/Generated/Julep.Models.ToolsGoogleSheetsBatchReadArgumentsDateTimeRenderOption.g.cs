
#nullable enable

namespace Julep
{
    /// <summary>
    /// How dates, times, and durations should be represented<br/>
    /// Default Value: FORMATTED_STRING
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption
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
    public static class ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption.FormattedString => "FORMATTED_STRING",
                ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption.SerialNumber => "SERIAL_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_STRING" => ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption.FormattedString,
                "SERIAL_NUMBER" => ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption.SerialNumber,
                _ => null,
            };
        }
    }
}