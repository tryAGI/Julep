
#nullable enable

namespace Julep
{
    /// <summary>
    /// Google Sheets integration definition
    /// </summary>
    public sealed partial class ToolsGoogleSheetsIntegrationDef
    {
        /// <summary>
        /// The provider must be "google_sheets"<br/>
        /// Default Value: google_sheets
        /// </summary>
        /// <default>global::Julep.ToolsGoogleSheetsIntegrationDefProvider.GoogleSheets</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsGoogleSheetsIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsGoogleSheetsIntegrationDefProvider.GoogleSheets;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsGoogleSheetsIntegrationDefMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Google Sheets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsGoogleSheetsSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsGoogleSheetsReadArguments, global::Julep.ToolsGoogleSheetsWriteArguments, global::Julep.ToolsGoogleSheetsAppendArguments, global::Julep.ToolsGoogleSheetsClearArguments, global::Julep.ToolsGoogleSheetsBatchReadArguments, global::Julep.ToolsGoogleSheetsBatchWriteArguments>))]
        public global::Julep.AnyOf<global::Julep.ToolsGoogleSheetsReadArguments, global::Julep.ToolsGoogleSheetsWriteArguments, global::Julep.ToolsGoogleSheetsAppendArguments, global::Julep.ToolsGoogleSheetsClearArguments, global::Julep.ToolsGoogleSheetsBatchReadArguments, global::Julep.ToolsGoogleSheetsBatchWriteArguments>? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Google Sheets
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
        /// <param name="provider">
        /// The provider must be "google_sheets"<br/>
        /// Default Value: google_sheets
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsIntegrationDef(
            global::Julep.ToolsGoogleSheetsIntegrationDefMethod? method,
            global::Julep.ToolsGoogleSheetsSetup? setup,
            global::Julep.AnyOf<global::Julep.ToolsGoogleSheetsReadArguments, global::Julep.ToolsGoogleSheetsWriteArguments, global::Julep.ToolsGoogleSheetsAppendArguments, global::Julep.ToolsGoogleSheetsClearArguments, global::Julep.ToolsGoogleSheetsBatchReadArguments, global::Julep.ToolsGoogleSheetsBatchWriteArguments>? arguments,
            global::Julep.ToolsGoogleSheetsIntegrationDefProvider provider = global::Julep.ToolsGoogleSheetsIntegrationDefProvider.GoogleSheets)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsIntegrationDef" /> class.
        /// </summary>
        public ToolsGoogleSheetsIntegrationDef()
        {
        }

    }
}