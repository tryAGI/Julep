
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for clearing values from a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsClearArguments
    {
        /// <summary>
        /// The ID of the spreadsheet to clear values from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to clear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsClearArguments" /> class.
        /// </summary>
        /// <param name="spreadsheetId">
        /// The ID of the spreadsheet to clear values from
        /// </param>
        /// <param name="range">
        /// The A1 notation of the range to clear
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsClearArguments(
            string spreadsheetId,
            string range)
        {
            this.SpreadsheetId = spreadsheetId ?? throw new global::System.ArgumentNullException(nameof(spreadsheetId));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsClearArguments" /> class.
        /// </summary>
        public ToolsGoogleSheetsClearArguments()
        {
        }
    }
}