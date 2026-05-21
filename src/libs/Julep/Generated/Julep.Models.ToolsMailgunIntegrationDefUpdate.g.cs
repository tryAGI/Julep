
#nullable enable

namespace Julep
{
    /// <summary>
    /// Mailgun integration definition
    /// </summary>
    public sealed partial class ToolsMailgunIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "mailgun"<br/>
        /// Default Value: mailgun
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMailgunIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsMailgunIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMailgunIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsMailgunIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Mailgun
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsMailgunSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for mailgun methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsMailgunSendEmailArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "mailgun"<br/>
        /// Default Value: mailgun
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Mailgun
        /// </param>
        /// <param name="arguments">
        /// The arguments for mailgun methods
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMailgunIntegrationDefUpdate(
            global::Julep.ToolsMailgunIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsMailgunIntegrationDefUpdateMethod? method,
            global::Julep.ToolsMailgunSetupUpdate? setup,
            global::Julep.ToolsMailgunSendEmailArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsMailgunIntegrationDefUpdate()
        {
        }

    }
}