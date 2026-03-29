
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be inserted<br/>
    /// Default Value: OVERWRITE
    /// </summary>
    public enum ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption
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
    public static class ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption.InsertRows => "INSERT_ROWS",
                ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption.Overwrite => "OVERWRITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption? ToEnum(string value)
        {
            return value switch
            {
                "INSERT_ROWS" => ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption.InsertRows,
                "OVERWRITE" => ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption.Overwrite,
                _ => null,
            };
        }
    }
}