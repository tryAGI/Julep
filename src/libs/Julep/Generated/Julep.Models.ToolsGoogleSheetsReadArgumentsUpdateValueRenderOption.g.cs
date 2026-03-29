
#nullable enable

namespace Julep
{
    /// <summary>
    /// How values should be represented in the output<br/>
    /// Default Value: FORMATTED_VALUE
    /// </summary>
    public enum ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption
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
    public static class ToolsGoogleSheetsReadArgumentsUpdateValueRenderOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption value)
        {
            return value switch
            {
                ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.FormattedValue => "FORMATTED_VALUE",
                ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.Formula => "FORMULA",
                ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.UnformattedValue => "UNFORMATTED_VALUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption? ToEnum(string value)
        {
            return value switch
            {
                "FORMATTED_VALUE" => ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.FormattedValue,
                "FORMULA" => ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.Formula,
                "UNFORMATTED_VALUE" => ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption.UnformattedValue,
                _ => null,
            };
        }
    }
}