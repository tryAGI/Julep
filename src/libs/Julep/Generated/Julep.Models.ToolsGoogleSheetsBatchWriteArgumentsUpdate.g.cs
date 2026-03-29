
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for batch updating values in multiple ranges
    /// </summary>
    public sealed partial class ToolsGoogleSheetsBatchWriteArgumentsUpdate
    {
        /// <summary>
        /// The ID of the spreadsheet to write to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        public string? SpreadsheetId { get; set; }

        /// <summary>
        /// The data to write to each range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Julep.ToolsGoogleSheetsValueRange>? Data { get; set; }

        /// <summary>
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_input_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption? ValueInputOption { get; set; }

        /// <summary>
        /// Whether to include the values in the response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_values_in_response")]
        public bool? IncludeValuesInResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchWriteArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to write to
        /// </param>
        /// <param name="data">
        /// The data to write to each range
        /// </param>
        /// <param name="valueInputOption">
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </param>
        /// <param name="includeValuesInResponse">
        /// Whether to include the values in the response<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsBatchWriteArgumentsUpdate(
            string? spreadsheetId,
            global::System.Collections.Generic.IList<global::Julep.ToolsGoogleSheetsValueRange>? data,
            global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption? valueInputOption,
            bool? includeValuesInResponse)
        {
            this.SpreadsheetId = spreadsheetId;
            this.Data = data;
            this.ValueInputOption = valueInputOption;
            this.IncludeValuesInResponse = includeValuesInResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsBatchWriteArgumentsUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsBatchWriteArgumentsUpdate()
        {
        }
    }
}