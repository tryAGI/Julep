
#nullable enable

namespace Julep
{
    /// <summary>
    /// Wikipedia integration definition
    /// </summary>
    public sealed partial class ToolsWikipediaIntegrationDef
    {
        /// <summary>
        /// The provider must be "wikipedia"<br/>
        /// Default Value: wikipedia
        /// </summary>
        /// <default>global::Julep.ToolsWikipediaIntegrationDefProvider.Wikipedia</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsWikipediaIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsWikipediaIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsWikipediaIntegrationDefProvider.Wikipedia;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Wikipedia<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public object? Setup { get; set; }

        /// <summary>
        /// The arguments for Wikipedia Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsWikipediaSearchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWikipediaIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Wikipedia<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="arguments">
        /// The arguments for Wikipedia Search
        /// </param>
        /// <param name="provider">
        /// The provider must be "wikipedia"<br/>
        /// Default Value: wikipedia
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWikipediaIntegrationDef(
            string? method,
            object? setup,
            global::Julep.ToolsWikipediaSearchArguments? arguments,
            global::Julep.ToolsWikipediaIntegrationDefProvider provider = global::Julep.ToolsWikipediaIntegrationDefProvider.Wikipedia)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWikipediaIntegrationDef" /> class.
        /// </summary>
        public ToolsWikipediaIntegrationDef()
        {
        }

    }
}