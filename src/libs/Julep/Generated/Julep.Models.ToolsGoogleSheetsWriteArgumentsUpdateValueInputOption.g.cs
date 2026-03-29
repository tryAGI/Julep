
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption
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
    public static class ToolsGoogleSheetsWriteArgumentsUpdateValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}