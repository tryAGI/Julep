
#nullable enable

namespace Julep
{
    /// <summary>
    /// Unstructured integration definition
    /// </summary>
    public sealed partial class ToolsUnstructuredIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "unstructured"<br/>
        /// Default Value: unstructured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsUnstructuredIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsUnstructuredIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Unstructured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsUnstructuredSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Unstructured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsUnstructuredPartitionArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "unstructured"<br/>
        /// Default Value: unstructured
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Unstructured
        /// </param>
        /// <param name="arguments">
        /// The arguments for Unstructured
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsUnstructuredIntegrationDefUpdate(
            global::Julep.ToolsUnstructuredIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsUnstructuredSetupUpdate? setup,
            global::Julep.ToolsUnstructuredPartitionArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsUnstructuredIntegrationDefUpdate()
        {
        }
    }
}