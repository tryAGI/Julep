
#nullable enable

namespace Julep
{
    /// <summary>
    /// How dates, times, and durations should be represented<br/>
    /// Default Value: FORMATTED_STRING
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption
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
    public static class ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption.FormattedString => "FORMATTED_STRING",
                ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption.SerialNumber => "SERIAL_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_STRING" => ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption.FormattedString,
                "SERIAL_NUMBER" => ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption.SerialNumber,
                _ => null,
            };
        }
    }
}