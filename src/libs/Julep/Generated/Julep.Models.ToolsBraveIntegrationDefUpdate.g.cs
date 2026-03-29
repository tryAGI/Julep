
#nullable enable

namespace Julep
{
    /// <summary>
    /// Brave integration definition
    /// </summary>
    public sealed partial class ToolsBraveIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "brave"<br/>
        /// Default Value: brave
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBraveIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsBraveIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Brave
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsBraveSearchSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Brave Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBraveSearchArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "brave"<br/>
        /// Default Value: brave
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Brave
        /// </param>
        /// <param name="arguments">
        /// The arguments for Brave Search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBraveIntegrationDefUpdate(
            global::Julep.ToolsBraveIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsBraveSearchSetupUpdate? setup,
            global::Julep.ToolsBraveSearchArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBraveIntegrationDefUpdate()
        {
        }
    }
}