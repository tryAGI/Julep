
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsAppendArgumentsValueInputOption
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
    public static class ToolsGoogleSheetsAppendArgumentsValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsAppendArgumentsValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsAppendArgumentsValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsAppendArgumentsValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsAppendArgumentsValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsAppendArgumentsValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsAppendArgumentsValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}