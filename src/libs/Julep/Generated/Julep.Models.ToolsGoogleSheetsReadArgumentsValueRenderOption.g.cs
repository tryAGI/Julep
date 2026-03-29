
#nullable enable

namespace Julep
{
    /// <summary>
    /// How values should be represented in the output<br/>
    /// Default Value: FORMATTED_VALUE
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsValueRenderOption
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
    public static class ToolsGoogleSheetsReadArgumentsValueRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsValueRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsValueRenderOption.FormattedValue => "FORMATTED_VALUE",
                ToolsGoogleSheetsReadArgumentsValueRenderOption.Formula => "FORMULA",
                ToolsGoogleSheetsReadArgumentsValueRenderOption.UnformattedValue => "UNFORMATTED_VALUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsValueRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_VALUE" => ToolsGoogleSheetsReadArgumentsValueRenderOption.FormattedValue,
                "FORMULA" => ToolsGoogleSheetsReadArgumentsValueRenderOption.Formula,
                "UNFORMATTED_VALUE" => ToolsGoogleSheetsReadArgumentsValueRenderOption.UnformattedValue,
                _ => null,
            };
        }
    }
}