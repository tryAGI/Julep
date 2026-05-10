
#nullable enable

namespace Julep
{
    /// <summary>
    /// Google Sheets integration definition
    /// </summary>
    public sealed partial class ToolsGoogleSheetsIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "google_sheets"<br/>
        /// Default Value: google_sheets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Google Sheets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsGoogleSheetsSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsGoogleSheetsReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsWriteArgumentsUpdate, global::Julep.ToolsGoogleSheetsAppendArgumentsUpdate, global::Julep.ToolsGoogleSheetsClearArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdate>))]
        public global::Julep.AnyOf<global::Julep.ToolsGoogleSheetsReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsWriteArgumentsUpdate, global::Julep.ToolsGoogleSheetsAppendArgumentsUpdate, global::Julep.ToolsGoogleSheetsClearArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdate>? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "google_sheets"<br/>
        /// Default Value: google_sheets
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Google Sheets
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsIntegrationDefUpdate(
            global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsGoogleSheetsIntegrationDefUpdateMethod? method,
            global::Julep.ToolsGoogleSheetsSetupUpdate? setup,
            global::Julep.AnyOf<global::Julep.ToolsGoogleSheetsReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsWriteArgumentsUpdate, global::Julep.ToolsGoogleSheetsAppendArgumentsUpdate, global::Julep.ToolsGoogleSheetsClearArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdate, global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdate>? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsIntegrationDefUpdate()
        {
        }

    }
}