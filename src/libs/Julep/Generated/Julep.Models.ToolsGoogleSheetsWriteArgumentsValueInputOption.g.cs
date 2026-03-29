
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsWriteArgumentsValueInputOption
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
    public static class ToolsGoogleSheetsWriteArgumentsValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsWriteArgumentsValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsWriteArgumentsValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsWriteArgumentsValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsWriteArgumentsValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsWriteArgumentsValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsWriteArgumentsValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}