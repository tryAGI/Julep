
#nullable enable

namespace Julep
{
    /// <summary>
    /// LlamaParse integration definition
    /// </summary>
    public sealed partial class ToolsLlamaParseIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "LlamaParseSetup"<br/>
        /// Default Value: llama_parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsLlamaParseIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsLlamaParseIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for LlamaParse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsLlamaParseSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for LlamaParse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsLlamaParseFetchArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "LlamaParseSetup"<br/>
        /// Default Value: llama_parse
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for LlamaParse
        /// </param>
        /// <param name="arguments">
        /// The arguments for LlamaParse
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsLlamaParseIntegrationDefUpdate(
            global::Julep.ToolsLlamaParseIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsLlamaParseSetupUpdate? setup,
            global::Julep.ToolsLlamaParseFetchArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsLlamaParseIntegrationDefUpdate()
        {
        }
    }
}