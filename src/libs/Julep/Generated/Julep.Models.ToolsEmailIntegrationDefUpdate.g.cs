
#nullable enable

namespace Julep
{
    /// <summary>
    /// Email integration definition
    /// </summary>
    public sealed partial class ToolsEmailIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "email"<br/>
        /// Default Value: email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsEmailIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsEmailIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsEmailSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Email sending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsEmailArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "email"<br/>
        /// Default Value: email
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Email
        /// </param>
        /// <param name="arguments">
        /// The arguments for Email sending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsEmailIntegrationDefUpdate(
            global::Julep.ToolsEmailIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsEmailSetupUpdate? setup,
            global::Julep.ToolsEmailArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsEmailIntegrationDefUpdate()
        {
        }
    }
}