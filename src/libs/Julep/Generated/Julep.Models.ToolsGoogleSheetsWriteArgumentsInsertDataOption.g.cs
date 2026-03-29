
#nullable enable

namespace Julep
{
    /// <summary>
    /// How the input data should be inserted<br/>
    /// Default Value: OVERWRITE
    /// </summary>
    public enum ToolsGoogleSheetsWriteArgumentsInsertDataOption
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
    public static class ToolsGoogleSheetsWriteArgumentsInsertDataOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsWriteArgumentsInsertDataOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsWriteArgumentsInsertDataOption.InsertRows => "INSERT_ROWS",
                ToolsGoogleSheetsWriteArgumentsInsertDataOption.Overwrite => "OVERWRITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsWriteArgumentsInsertDataOption? ToEnum(string value)
        {
            return value switch
            {
                "INSERT_ROWS" => ToolsGoogleSheetsWriteArgumentsInsertDataOption.InsertRows,
                "OVERWRITE" => ToolsGoogleSheetsWriteArgumentsInsertDataOption.Overwrite,
                _ => null,
            };
        }
    }
}