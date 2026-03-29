
#nullable enable

namespace Julep
{
    /// <summary>
    /// The major dimension that results should use<br/>
    /// Default Value: ROWS
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension
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
    public static class ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension.Columns => "COLUMNS",
                ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension.Rows => "ROWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension? ToEnum(string value)
        {
            return value switch
            {
                "COLUMNS" => ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension.Columns,
                "ROWS" => ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension.Rows,
                _ => null,
            };
        }
    }
}