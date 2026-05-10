
#nullable enable

namespace Julep
{
    /// <summary>
    /// Unstructured integration definition
    /// </summary>
    public sealed partial class ToolsUnstructuredIntegrationDef
    {
        /// <summary>
        /// The provider must be "unstructured"<br/>
        /// Default Value: unstructured
        /// </summary>
        /// <default>global::Julep.ToolsUnstructuredIntegrationDefProvider.Unstructured</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsUnstructuredIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsUnstructuredIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsUnstructuredIntegrationDefProvider.Unstructured;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Unstructured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsUnstructuredSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Unstructured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsUnstructuredPartitionArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Unstructured
        /// </param>
        /// <param name="arguments">
        /// The arguments for Unstructured
        /// </param>
        /// <param name="provider">
        /// The provider must be "unstructured"<br/>
        /// Default Value: unstructured
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsUnstructuredIntegrationDef(
            string? method,
            global::Julep.ToolsUnstructuredSetup? setup,
            global::Julep.ToolsUnstructuredPartitionArguments? arguments,
            global::Julep.ToolsUnstructuredIntegrationDefProvider provider = global::Julep.ToolsUnstructuredIntegrationDefProvider.Unstructured)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredIntegrationDef" /> class.
        /// </summary>
        public ToolsUnstructuredIntegrationDef()
        {
        }

    }
}