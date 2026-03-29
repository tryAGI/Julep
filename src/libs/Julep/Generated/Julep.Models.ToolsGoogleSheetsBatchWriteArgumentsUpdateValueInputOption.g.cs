
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be interpreted<br/>
    /// Default Value: USER_ENTERED
    /// </summary>
    public enum ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption
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
    public static class ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption.Raw => "RAW",
                ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption.UserEntered => "USER_ENTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption? ToEnum(string value)
        {
            return value switch
            {
                "RAW" => ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption.Raw,
                "USER_ENTERED" => ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption.UserEntered,
                _ => null,
            };
        }
    }
}