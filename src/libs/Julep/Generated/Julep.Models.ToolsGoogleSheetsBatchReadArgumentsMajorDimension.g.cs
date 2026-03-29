
#nullable enable

namespace Julep
{
    /// <summary>
    /// The major dimension that results should use<br/>
    /// Default Value: ROWS
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsMajorDimension
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
    public static class ToolsGoogleSheetsBatchReadArgumentsMajorDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsMajorDimension value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsMajorDimension.Columns => "COLUMNS",
                ToolsGoogleSheetsBatchReadArgumentsMajorDimension.Rows => "ROWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsMajorDimension? ToEnum(string value)
        {
            return value switch
            {
                "COLUMNS" => ToolsGoogleSheetsBatchReadArgumentsMajorDimension.Columns,
                "ROWS" => ToolsGoogleSheetsBatchReadArgumentsMajorDimension.Rows,
                _ => null,
            };
        }
    }
}