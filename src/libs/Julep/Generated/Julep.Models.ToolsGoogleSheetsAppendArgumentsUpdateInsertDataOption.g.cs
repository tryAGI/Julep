
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be inserted<br/>
    /// Default Value: INSERT_ROWS
    /// </summary>
    public enum ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption
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
    public static class ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption.InsertRows => "INSERT_ROWS",
                ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption.Overwrite => "OVERWRITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption? ToEnum(string value)
        {
            return value switch
            {
                "INSERT_ROWS" => ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption.InsertRows,
                "OVERWRITE" => ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption.Overwrite,
                _ => null,
            };
        }
    }
}