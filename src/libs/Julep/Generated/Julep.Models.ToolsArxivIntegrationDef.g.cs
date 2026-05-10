
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arxiv integration definition
    /// </summary>
    public sealed partial class ToolsArxivIntegrationDef
    {
        /// <summary>
        /// The provider must be "arxiv"<br/>
        /// Default Value: arxiv
        /// </summary>
        /// <default>global::Julep.ToolsArxivIntegrationDefProvider.Arxiv</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsArxivIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsArxivIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsArxivIntegrationDefProvider.Arxiv;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Arxiv<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public object? Setup { get; set; }

        /// <summary>
        /// The arguments for Arxiv Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsArxivSearchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsArxivIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Arxiv<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="arguments">
        /// The arguments for Arxiv Search
        /// </param>
        /// <param name="provider">
        /// The provider must be "arxiv"<br/>
        /// Default Value: arxiv
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsArxivIntegrationDef(
            string? method,
            object? setup,
            global::Julep.ToolsArxivSearchArguments? arguments,
            global::Julep.ToolsArxivIntegrationDefProvider provider = global::Julep.ToolsArxivIntegrationDefProvider.Arxiv)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsArxivIntegrationDef" /> class.
        /// </summary>
        public ToolsArxivIntegrationDef()
        {
        }

    }
}