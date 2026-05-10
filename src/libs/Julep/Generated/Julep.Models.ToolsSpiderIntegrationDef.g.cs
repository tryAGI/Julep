
#nullable enable

namespace Julep
{
    /// <summary>
    /// Spider integration definition
    /// </summary>
    public sealed partial class ToolsSpiderIntegrationDef
    {
        /// <summary>
        /// The provider must be "spider"<br/>
        /// Default Value: spider
        /// </summary>
        /// <default>global::Julep.ToolsSpiderIntegrationDefProvider.Spider</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsSpiderIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsSpiderIntegrationDefProvider.Spider;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsSpiderIntegrationDefMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsSpiderSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsSpiderFetchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Spider
        /// </param>
        /// <param name="arguments">
        /// The arguments for Spider
        /// </param>
        /// <param name="provider">
        /// The provider must be "spider"<br/>
        /// Default Value: spider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSpiderIntegrationDef(
            global::Julep.ToolsSpiderIntegrationDefMethod? method,
            global::Julep.ToolsSpiderSetup? setup,
            global::Julep.ToolsSpiderFetchArguments? arguments,
            global::Julep.ToolsSpiderIntegrationDefProvider provider = global::Julep.ToolsSpiderIntegrationDefProvider.Spider)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderIntegrationDef" /> class.
        /// </summary>
        public ToolsSpiderIntegrationDef()
        {
        }

    }
}