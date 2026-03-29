
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of hosted tool the model should to use. Learn more about<br/>
    /// [built-in tools](/docs/guides/tools).<br/>
    /// Allowed values are:<br/>
    /// - `file_search`<br/>
    /// - `web_search_preview` <br/>
    /// - `computer_use_preview`
    /// </summary>
    public enum ResponsesToolChoiceTypesType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesToolChoiceTypesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesToolChoiceTypesType value)
        {
            return value switch
            {
                ResponsesToolChoiceTypesType.ComputerUsePreview => "computer_use_preview",
                ResponsesToolChoiceTypesType.FileSearch => "file_search",
                ResponsesToolChoiceTypesType.WebSearchPreview => "web_search_preview",
                ResponsesToolChoiceTypesType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesToolChoiceTypesType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => ResponsesToolChoiceTypesType.ComputerUsePreview,
                "file_search" => ResponsesToolChoiceTypesType.FileSearch,
                "web_search_preview" => ResponsesToolChoiceTypesType.WebSearchPreview,
                "web_search_preview_2025_03_11" => ResponsesToolChoiceTypesType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}