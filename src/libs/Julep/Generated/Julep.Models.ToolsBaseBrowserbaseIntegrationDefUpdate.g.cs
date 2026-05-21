
#nullable enable

namespace Julep
{
    /// <summary>
    /// The base definition for a browserbase integration
    /// </summary>
    public sealed partial class ToolsBaseBrowserbaseIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: browserbase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseBrowserbaseIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The setup parameters for the browserbase integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsBrowserbaseSetupUpdate? Setup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseBrowserbaseIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseBrowserbaseIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// Default Value: browserbase
        /// </param>
        /// <param name="setup">
        /// The setup parameters for the browserbase integration
        /// </param>
        /// <param name="method"></param>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBaseBrowserbaseIntegrationDefUpdate(
            global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsBrowserbaseSetupUpdate? setup,
            global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateMethod? method,
            object? arguments)
        {
            this.Provider = provider;
            this.Setup = setup;
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseBrowserbaseIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBaseBrowserbaseIntegrationDefUpdate()
        {
        }

    }
}