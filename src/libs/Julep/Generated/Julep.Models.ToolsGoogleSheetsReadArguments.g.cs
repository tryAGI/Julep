
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for reading values from a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsReadArguments
    {
        /// <summary>
        /// The ID of the spreadsheet to read from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// The major dimension that results should use<br/>
        /// Default Value: ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsMajorDimensionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? MajorDimension { get; set; }

        /// <summary>
        /// How values should be represented in the output<br/>
        /// Default Value: FORMATTED_VALUE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsValueRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? ValueRenderOption { get; set; }

        /// <summary>
        /// How dates, times, and durations should be represented<br/>
        /// Default Value: FORMATTED_STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_time_render_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsReadArgumentsDateTimeRenderOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption? DateTimeRenderOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsReadArguments" /> class.
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
        public ToolsGoogleSheetsReadArguments(
            string spreadsheetId,
            string range,
            global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? majorDimension,
            global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? valueRenderOption,
            global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption? dateTimeRenderOption)
        {
            this.SpreadsheetId = spreadsheetId ?? throw new global::System.ArgumentNullException(nameof(spreadsheetId));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
            this.MajorDimension = majorDimension;
            this.ValueRenderOption = valueRenderOption;
            this.DateTimeRenderOption = dateTimeRenderOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsReadArguments" /> class.
        /// </summary>
        public ToolsGoogleSheetsReadArguments()
        {
        }
    }
}