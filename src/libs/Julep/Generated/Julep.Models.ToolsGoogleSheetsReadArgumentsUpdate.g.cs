
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for reading values from a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsReadArgumentsUpdate
    {
        /// <summary>
        /// The ID of the spreadsheet to read from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        public string? SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// The major dimension that results should use<br/>
        /// Default Value: ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsUpdateMajorDimensionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateMajorDimension? MajorDimension { get; set; }

        /// <summary>
        /// How values should be represented in the output<br/>
        /// Default Value: FORMATTED_VALUE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsUpdateValueRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption? ValueRenderOption { get; set; }

        /// <summary>
        /// How dates, times, and durations should be represented<br/>
        /// Default Value: FORMATTED_STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_time_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption? DateTimeRenderOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsReadArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to read from
        /// </param>
        /// <param name="range">
        /// The A1 notation of the range to read
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
        public ToolsGoogleSheetsReadArgumentsUpdate(
            string? spreadsheetId,
            string? range,
            global::Julep.ToolsGoogleSheetsReadArgumentsUpdateMajorDimension? majorDimension,
            global::Julep.ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption? valueRenderOption,
            global::Julep.ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption? dateTimeRenderOption)
        {
            this.SpreadsheetId = spreadsheetId;
            this.Range = range;
            this.MajorDimension = majorDimension;
            this.ValueRenderOption = valueRenderOption;
            this.DateTimeRenderOption = dateTimeRenderOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsReadArgumentsUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsReadArgumentsUpdate()
        {
        }
    }
}