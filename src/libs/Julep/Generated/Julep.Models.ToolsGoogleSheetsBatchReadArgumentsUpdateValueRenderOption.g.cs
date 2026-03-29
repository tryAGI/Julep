
#nullable enable

namespace Julep
{
    /// <summary>
    /// How values should be represented in the output<br/>
    /// Default Value: FORMATTED_VALUE
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption
    {
        /// <summary>
        /// 
        /// </summary>
        FormattedValue,
        /// <summary>
        /// 
        /// </summary>
        Formula,
        /// <summary>
        /// 
        /// </summary>
        UnformattedValue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.FormattedValue => "FORMATTED_VALUE",
                ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.Formula => "FORMULA",
                ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.UnformattedValue => "UNFORMATTED_VALUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_VALUE" => ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.FormattedValue,
                "FORMULA" => ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.Formula,
                "UNFORMATTED_VALUE" => ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption.UnformattedValue,
                _ => null,
            };
        }
    }
}