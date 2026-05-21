
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for clearing values from a spreadsheet
    /// </summary>
    public sealed partial class ToolsGoogleSheetsClearArgumentsUpdate
    {
        /// <summary>
        /// The ID of the spreadsheet to clear values from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_id")]
        public string? SpreadsheetId { get; set; }

        /// <summary>
        /// The A1 notation of the range to clear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsClearArgumentsUpdate" /> class.
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
        public ToolsGoogleSheetsClearArgumentsUpdate(
            string? spreadsheetId,
            string? range)
        {
            this.SpreadsheetId = spreadsheetId;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsClearArgumentsUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsClearArgumentsUpdate()
        {
        }

    }
}