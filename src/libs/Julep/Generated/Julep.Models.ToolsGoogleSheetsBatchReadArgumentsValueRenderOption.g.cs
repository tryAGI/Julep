
#nullable enable

namespace Julep
{
    /// <summary>
    /// How values should be represented in the output<br/>
    /// Default Value: FORMATTED_VALUE
    /// </summary>
    public enum ToolsGoogleSheetsBatchReadArgumentsValueRenderOption
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
    public static class ToolsGoogleSheetsBatchReadArgumentsValueRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsBatchReadArgumentsValueRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.FormattedValue => "FORMATTED_VALUE",
                ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.Formula => "FORMULA",
                ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.UnformattedValue => "UNFORMATTED_VALUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsBatchReadArgumentsValueRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_VALUE" => ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.FormattedValue,
                "FORMULA" => ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.Formula,
                "UNFORMATTED_VALUE" => ToolsGoogleSheetsBatchReadArgumentsValueRenderOption.UnformattedValue,
                _ => null,
            };
        }
    }
}