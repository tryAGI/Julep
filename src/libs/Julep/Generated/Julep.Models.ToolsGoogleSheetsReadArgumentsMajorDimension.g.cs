
#nullable enable

namespace Julep
{
    /// <summary>
    /// The major dimension that results should use<br/>
    /// Default Value: ROWS
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsMajorDimension
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
    public static class ToolsGoogleSheetsReadArgumentsMajorDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsMajorDimension value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsMajorDimension.Columns => "COLUMNS",
                ToolsGoogleSheetsReadArgumentsMajorDimension.Rows => "ROWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsMajorDimension? ToEnum(string value)
        {
            return value switch
            {
                "COLUMNS" => ToolsGoogleSheetsReadArgumentsMajorDimension.Columns,
                "ROWS" => ToolsGoogleSheetsReadArgumentsMajorDimension.Rows,
                _ => null,
            };
        }
    }
}