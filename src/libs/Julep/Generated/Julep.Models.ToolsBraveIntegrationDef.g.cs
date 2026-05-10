
#nullable enable

namespace Julep
{
    /// <summary>
    /// Brave integration definition
    /// </summary>
    public sealed partial class ToolsBraveIntegrationDef
    {
        /// <summary>
        /// The provider must be "brave"<br/>
        /// Default Value: brave
        /// </summary>
        /// <default>global::Julep.ToolsBraveIntegrationDefProvider.Brave</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBraveIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsBraveIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsBraveIntegrationDefProvider.Brave;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Brave
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsBraveSearchSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Brave Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBraveSearchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Brave
        /// </param>
        /// <param name="arguments">
        /// The arguments for Brave Search
        /// </param>
        /// <param name="provider">
        /// The provider must be "brave"<br/>
        /// Default Value: brave
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBraveIntegrationDef(
            string? method,
            global::Julep.ToolsBraveSearchSetup? setup,
            global::Julep.ToolsBraveSearchArguments? arguments,
            global::Julep.ToolsBraveIntegrationDefProvider provider = global::Julep.ToolsBraveIntegrationDefProvider.Brave)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveIntegrationDef" /> class.
        /// </summary>
        public ToolsBraveIntegrationDef()
        {
        }

    }
}