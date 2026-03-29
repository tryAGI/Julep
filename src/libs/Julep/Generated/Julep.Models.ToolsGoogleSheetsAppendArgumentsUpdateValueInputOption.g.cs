
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        UserEntered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsAppendArgumentsUpdateValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}