
#nullable enable

namespace Julep
{
    /// <summary>
    /// The base definition for a browserbase integration
    /// </summary>
    public sealed partial class ToolsBaseBrowserbaseIntegrationDef
    {
        /// <summary>
        /// Default Value: browserbase
        /// </summary>
        /// <default>global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider.Browserbase</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseBrowserbaseIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider.Browserbase;

        /// <summary>
        /// The setup parameters for the browserbase integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsBrowserbaseSetup? Setup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseBrowserbaseIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefMethod? Method { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolsBaseBrowserbaseIntegrationDef" /> class.
        /// </summary>
        /// <param name="setup">
        /// The setup parameters for the browserbase integration
        /// </param>
        /// <param name="method"></param>
        /// <param name="arguments"></param>
        /// <param name="provider">
        /// Default Value: browserbase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBaseBrowserbaseIntegrationDef(
            global::Julep.ToolsBrowserbaseSetup? setup,
            global::Julep.ToolsBaseBrowserbaseIntegrationDefMethod? method,
            object? arguments,
            global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider provider = global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider.Browserbase)
        {
            this.Provider = provider;
            this.Setup = setup;
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseBrowserbaseIntegrationDef" /> class.
        /// </summary>
        public ToolsBaseBrowserbaseIntegrationDef()
        {
        }

    }
}