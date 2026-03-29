
#nullable enable

namespace Julep
{
    /// <summary>
    /// Algolia integration definition
    /// </summary>
    public sealed partial class ToolsAlgoliaIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "algolia"<br/>
        /// Default Value: algolia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsAlgoliaIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsAlgoliaIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Algolia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsAlgoliaSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Algolia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsAlgoliaSearchArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "algolia"<br/>
        /// Default Value: algolia
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Algolia
        /// </param>
        /// <param name="arguments">
        /// The arguments for Algolia
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsAlgoliaIntegrationDefUpdate(
            global::Julep.ToolsAlgoliaIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsAlgoliaSetupUpdate? setup,
            global::Julep.ToolsAlgoliaSearchArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsAlgoliaIntegrationDefUpdate()
        {
        }
    }
}