
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for appending values to a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsAppendArguments
    {
        /// <summary>
        /// The ID of the spreadsheet to append to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to start appending from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// The values to append (2D array)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> Values { get; set; }

        /// <summary>
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_input_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsAppendArgumentsValueInputOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsAppendArgumentsValueInputOption? ValueInputOption { get; set; }

        /// <summary>
        /// How the input data should be inserted<br/>
        /// Default Value: INSERT_ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_data_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsAppendArgumentsInsertDataOptionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsAppendArgumentsInsertDataOption? InsertDataOption { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsAppendArguments" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to append to
        /// </param>
        /// <param name="range">
        /// The A1 notation of the range to start appending from
        /// </param>
        /// <param name="values">
        /// The values to append (2D array)
        /// </param>
        /// <param name="valueInputOption">
        /// How the input data should be interpreted<br/>
        /// Default Value: USER_ENTERED
        /// </param>
        /// <param name="insertDataOption">
        /// How the input data should be inserted<br/>
        /// Default Value: INSERT_ROWS
        /// </param>
        /// <param name="includeValuesInResponse">
        /// Whether to include the values in the response<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsAppendArguments(
            string spreadsheetId,
            string range,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> values,
            global::Julep.ToolsGoogleSheetsAppendArgumentsValueInputOption? valueInputOption,
            global::Julep.ToolsGoogleSheetsAppendArgumentsInsertDataOption? insertDataOption,
            bool? includeValuesInResponse)
        {
            this.SpreadsheetId = spreadsheetId ?? throw new global::System.ArgumentNullException(nameof(spreadsheetId));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.ValueInputOption = valueInputOption;
            this.InsertDataOption = insertDataOption;
            this.IncludeValuesInResponse = includeValuesInResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsAppendArguments" /> class.
        /// </summary>
        public ToolsGoogleSheetsAppendArguments()
        {
        }

    }
}