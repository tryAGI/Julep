
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for batch reading values from multiple ranges
    /// </summary>
    public sealed partial class ToolsGoogleSheetsBatchReadArgumentsUpdate
    {
        /// <summary>
        /// The ID of the spreadsheet to read from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        public string? SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the ranges to read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        public global::System.Collections.Generic.IList<string>? Ranges { get; set; }

        /// <summary>
        /// The major dimension that results should use<br/>
        /// Default Value: ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimensionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension? MajorDimension { get; set; }

        /// <summary>
        /// How values should be represented in the output<br/>
        /// Default Value: FORMATTED_VALUE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? ValueRenderOption { get; set; }

        /// <summary>
        /// How dates, times, and durations should be represented<br/>
        /// Default Value: FORMATTED_STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_time_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption? DateTimeRenderOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchReadArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to read from
        /// </param>
        /// <param name="ranges">
        /// The A1 notation of the ranges to read
        /// </param>
        /// <param name="majorDimension">
        /// The major dimension that results should use<br/>
        /// Default Value: ROWS
        /// </param>
        /// <param name="valueRenderOption">
        /// How values should be represented in the output<br/>
        /// Default Value: FORMATTED_VALUE
        /// </param>
        /// <param name="dateTimeRenderOption">
        /// How dates, times, and durations should be represented<br/>
        /// Default Value: FORMATTED_STRING
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsBatchReadArgumentsUpdate(
            string? spreadsheetId,
            global::System.Collections.Generic.IList<string>? ranges,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension? majorDimension,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? valueRenderOption,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption? dateTimeRenderOption)
        {
            this.SpreadsheetId = spreadsheetId;
            this.Ranges = ranges;
            this.MajorDimension = majorDimension;
            this.ValueRenderOption = valueRenderOption;
            this.DateTimeRenderOption = dateTimeRenderOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchReadArgumentsUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsBatchReadArgumentsUpdate()
        {
        }

    }
}