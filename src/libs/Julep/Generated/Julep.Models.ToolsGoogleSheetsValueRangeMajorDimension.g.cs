
#nullable enable

namespace Julep
{
    /// <summary>
    /// The major dimension of the values<br/>
    /// Default Value: ROWS
    /// </summary>
    public enum ToolsGoogleSheetsValueRangeMajorDimension
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
    public static class ToolsGoogleSheetsValueRangeMajorDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsValueRangeMajorDimension value)
        {
            return value switch
            {
                ToolsGoogleSheetsValueRangeMajorDimension.Columns => "COLUMNS",
                ToolsGoogleSheetsValueRangeMajorDimension.Rows => "ROWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsValueRangeMajorDimension? ToEnum(string value)
        {
            return value switch
            {
                "COLUMNS" => ToolsGoogleSheetsValueRangeMajorDimension.Columns,
                "ROWS" => ToolsGoogleSheetsValueRangeMajorDimension.Rows,
                _ => null,
            };
        }
    }
}