
#nullable enable

namespace Julep
{
    /// <summary>
    /// Algolia integration definition
    /// </summary>
    public sealed partial class ToolsAlgoliaIntegrationDef
    {
        /// <summary>
        /// The provider must be "algolia"<br/>
        /// Default Value: algolia
        /// </summary>
        /// <default>global::Julep.ToolsAlgoliaIntegrationDefProvider.Algolia</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsAlgoliaIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsAlgoliaIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsAlgoliaIntegrationDefProvider.Algolia;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Algolia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsAlgoliaSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Algolia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsAlgoliaSearchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Algolia
        /// </param>
        /// <param name="arguments">
        /// The arguments for Algolia
        /// </param>
        /// <param name="provider">
        /// The provider must be "algolia"<br/>
        /// Default Value: algolia
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsAlgoliaIntegrationDef(
            string? method,
            global::Julep.ToolsAlgoliaSetup? setup,
            global::Julep.ToolsAlgoliaSearchArguments? arguments,
            global::Julep.ToolsAlgoliaIntegrationDefProvider provider = global::Julep.ToolsAlgoliaIntegrationDefProvider.Algolia)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaIntegrationDef" /> class.
        /// </summary>
        public ToolsAlgoliaIntegrationDef()
        {
        }

    }
}