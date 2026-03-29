
#nullable enable

namespace Julep
{
    /// <summary>
    /// The major dimension that results should use<br/>
    /// Default Value: ROWS
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsUpdateMajorDimension
    {
        /// <summary>
        /// 
        /// </summary>
        Columns,
        /// <summary>
        /// 
        /// </summary>
        Rows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsReadArgumentsUpdateMajorDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsUpdateMajorDimension value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsUpdateMajorDimension.Columns => "COLUMNS",
                ToolsGoogleSheetsReadArgumentsUpdateMajorDimension.Rows => "ROWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsUpdateMajorDimension? ToEnum(string value)
        {
            return value switch
            {
                "COLUMNS" => ToolsGoogleSheetsReadArgumentsUpdateMajorDimension.Columns,
                "ROWS" => ToolsGoogleSheetsReadArgumentsUpdateMajorDimension.Rows,
                _ => null,
            };
        }
    }
}