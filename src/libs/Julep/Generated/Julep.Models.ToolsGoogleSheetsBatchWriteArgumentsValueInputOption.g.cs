
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsBatchWriteArgumentsValueInputOption
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
    public static class ToolsGoogleSheetsBatchWriteArgumentsValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchWriteArgumentsValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchWriteArgumentsValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsBatchWriteArgumentsValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchWriteArgumentsValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsBatchWriteArgumentsValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsBatchWriteArgumentsValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}