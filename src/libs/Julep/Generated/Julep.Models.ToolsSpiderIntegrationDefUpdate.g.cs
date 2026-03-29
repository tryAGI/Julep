
#nullable enable

namespace Julep
{
    /// <summary>
    /// Spider integration definition
    /// </summary>
    public sealed partial class ToolsSpiderIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "spider"<br/>
        /// Default Value: spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsSpiderIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsSpiderIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsSpiderSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsSpiderFetchArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "spider"<br/>
        /// Default Value: spider
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Spider
        /// </param>
        /// <param name="arguments">
        /// The arguments for Spider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSpiderIntegrationDefUpdate(
            global::Julep.ToolsSpiderIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsSpiderIntegrationDefUpdateMethod? method,
            global::Julep.ToolsSpiderSetupUpdate? setup,
            global::Julep.ToolsSpiderFetchArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsSpiderIntegrationDefUpdate()
        {
        }
    }
}