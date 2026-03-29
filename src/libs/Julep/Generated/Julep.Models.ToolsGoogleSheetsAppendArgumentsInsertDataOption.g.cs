
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be inserted<br/>
    /// Default Value: INSERT_ROWS
    /// </summary>
    public enum ToolsGoogleSheetsAppendArgumentsInsertDataOption
    {
        /// <summary>
        /// 
        /// </summary>
        InsertRows,
        /// <summary>
        /// 
        /// </summary>
        Overwrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsAppendArgumentsInsertDataOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsAppendArgumentsInsertDataOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsAppendArgumentsInsertDataOption.InsertRows => "INSERT_ROWS",
                ToolsGoogleSheetsAppendArgumentsInsertDataOption.Overwrite => "OVERWRITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsAppendArgumentsInsertDataOption? ToEnum(string value)
        {
            return value switch
            {
                "INSERT_ROWS" => ToolsGoogleSheetsAppendArgumentsInsertDataOption.InsertRows,
                "OVERWRITE" => ToolsGoogleSheetsAppendArgumentsInsertDataOption.Overwrite,
                _ => null,
            };
        }
    }
}