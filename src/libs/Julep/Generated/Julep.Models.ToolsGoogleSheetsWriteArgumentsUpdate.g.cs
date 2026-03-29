
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for writing values to a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsWriteArgumentsUpdate
    {
        /// <summary>
        /// The ID of the spreadsheet to write to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        public string? SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to write to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// The values to write (2D array)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Values { get; set; }

        /// <summary>
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_input_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsWriteArgumentsUpdateValueInputOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption? ValueInputOption { get; set; }

        /// <summary>
        /// How the input data should be inserted<br/>
        /// Default Value: OVERWRITE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_data_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption? InsertDataOption { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsWriteArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to write to
        /// </param>
        /// <param name="range">
        /// The A1 notation of the range to write to
        /// </param>
        /// <param name="values">
        /// The values to write (2D array)
        /// </param>
        /// <param name="valueInputOption">
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </param>
        /// <param name="insertDataOption">
        /// How the input data should be inserted<br/>
        /// Default Value: OVERWRITE
        /// </param>
        /// <param name="includeValuesInResponse">
        /// Whether to include the values in the response<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsWriteArgumentsUpdate(
            string? spreadsheetId,
            string? range,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? values,
            global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption? valueInputOption,
            global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption? insertDataOption,
            bool? includeValuesInResponse)
        {
            this.SpreadsheetId = spreadsheetId;
            this.Range = range;
            this.Values = values;
            this.ValueInputOption = valueInputOption;
            this.InsertDataOption = insertDataOption;
            this.IncludeValuesInResponse = includeValuesInResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsWriteArgumentsUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsWriteArgumentsUpdate()
        {
        }
    }
}