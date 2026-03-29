
#nullable enable

namespace Julep
{
    /// <summary>
    /// The integration definition for the remote browser
    /// </summary>
    public sealed partial class ToolsRemoteBrowserIntegrationDef
    {
        /// <summary>
        /// Default Value: remote_browser
        /// </summary>
        /// <default>global::Julep.ToolsRemoteBrowserIntegrationDefProvider.RemoteBrowser</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsRemoteBrowserIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsRemoteBrowserIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsRemoteBrowserIntegrationDefProvider.RemoteBrowser;

        /// <summary>
        /// The setup parameters for the remote browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsRemoteBrowserSetup Setup { get; set; }

        /// <summary>
        /// Default Value: perform_action
        /// </summary>
        /// <default>global::Julep.ToolsRemoteBrowserIntegrationDefMethod.PerformAction</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsRemoteBrowserIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsRemoteBrowserIntegrationDefMethod Method { get; set; } = global::Julep.ToolsRemoteBrowserIntegrationDefMethod.PerformAction;

        /// <summary>
        /// The arguments for the remote browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsRemoteBrowserArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserIntegrationDef" /> class.
        /// </summary>
        /// <param name="setup">
        /// The setup parameters for the remote browser
        /// </param>
        /// <param name="arguments">
        /// The arguments for the remote browser
        /// </param>
        /// <param name="provider">
        /// Default Value: remote_browser
        /// </param>
        /// <param name="method">
        /// Default Value: perform_action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsRemoteBrowserIntegrationDef(
            global::Julep.ToolsRemoteBrowserSetup setup,
            global::Julep.ToolsRemoteBrowserArguments? arguments,
            global::Julep.ToolsRemoteBrowserIntegrationDefProvider provider = global::Julep.ToolsRemoteBrowserIntegrationDefProvider.RemoteBrowser,
            global::Julep.ToolsRemoteBrowserIntegrationDefMethod method = global::Julep.ToolsRemoteBrowserIntegrationDefMethod.PerformAction)
        {
            this.Provider = provider;
            this.Setup = setup ?? throw new global::System.ArgumentNullException(nameof(setup));
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserIntegrationDef" /> class.
        /// </summary>
        public ToolsRemoteBrowserIntegrationDef()
        {
        }
    }
}