
#nullable enable

namespace Julep
{
    /// <summary>
    /// The integration definition for the remote browser
    /// </summary>
    public sealed partial class ToolsRemoteBrowserIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: remote_browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsRemoteBrowserIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The setup parameters for the remote browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsRemoteBrowserSetup? Setup { get; set; }

        /// <summary>
        /// Default Value: perform_action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsRemoteBrowserIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The arguments for the remote browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsRemoteBrowserArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// Default Value: remote_browser
        /// </param>
        /// <param name="setup">
        /// The setup parameters for the remote browser
        /// </param>
        /// <param name="method">
        /// Default Value: perform_action
        /// </param>
        /// <param name="arguments">
        /// The arguments for the remote browser
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsRemoteBrowserIntegrationDefUpdate(
            global::Julep.ToolsRemoteBrowserIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsRemoteBrowserSetup? setup,
            global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? method,
            global::Julep.ToolsRemoteBrowserArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Setup = setup;
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsRemoteBrowserIntegrationDefUpdate()
        {
        }
    }
}