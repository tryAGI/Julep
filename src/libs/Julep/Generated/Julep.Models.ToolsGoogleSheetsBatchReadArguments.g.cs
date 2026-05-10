
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for batch reading values from multiple ranges
    /// </summary>
    public sealed partial class ToolsGoogleSheetsBatchReadArguments
    {
        /// <summary>
        /// The ID of the spreadsheet to read from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the ranges to read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ranges { get; set; }

        /// <summary>
        /// The major dimension that results should use<br/>
        /// Default Value: ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsMajorDimensionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsMajorDimension? MajorDimension { get; set; }

        /// <summary>
        /// How values should be represented in the output<br/>
        /// Default Value: FORMATTED_VALUE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsValueRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsValueRenderOption? ValueRenderOption { get; set; }

        /// <summary>
        /// How dates, times, and durations should be represented<br/>
        /// Default Value: FORMATTED_STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_time_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption? DateTimeRenderOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchReadArguments" /> class.
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
        public ToolsGoogleSheetsBatchReadArguments(
            string spreadsheetId,
            global::System.Collections.Generic.IList<string> ranges,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsMajorDimension? majorDimension,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsValueRenderOption? valueRenderOption,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption? dateTimeRenderOption)
        {
            this.SpreadsheetId = spreadsheetId ?? throw new global::System.ArgumentNullException(nameof(spreadsheetId));
            this.Ranges = ranges ?? throw new global::System.ArgumentNullException(nameof(ranges));
            this.MajorDimension = majorDimension;
            this.ValueRenderOption = valueRenderOption;
            this.DateTimeRenderOption = dateTimeRenderOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchReadArguments" /> class.
        /// </summary>
        public ToolsGoogleSheetsBatchReadArguments()
        {
        }

    }
}