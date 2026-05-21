
#nullable enable

namespace Julep
{
    /// <summary>
    /// Mailgun integration definition
    /// </summary>
    public sealed partial class ToolsMailgunIntegrationDef
    {
        /// <summary>
        /// The provider must be "mailgun"<br/>
        /// Default Value: mailgun
        /// </summary>
        /// <default>global::Julep.ToolsMailgunIntegrationDefProvider.Mailgun</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMailgunIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsMailgunIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsMailgunIntegrationDefProvider.Mailgun;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMailgunIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsMailgunIntegrationDefMethod? Method { get; set; }

        /// <summary>
        /// The setup parameters for Mailgun
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsMailgunSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for mailgun methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsMailgunSendEmailArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Mailgun
        /// </param>
        /// <param name="arguments">
        /// The arguments for mailgun methods
        /// </param>
        /// <param name="provider">
        /// The provider must be "mailgun"<br/>
        /// Default Value: mailgun
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMailgunIntegrationDef(
            global::Julep.ToolsMailgunIntegrationDefMethod? method,
            global::Julep.ToolsMailgunSetup? setup,
            global::Julep.ToolsMailgunSendEmailArguments? arguments,
            global::Julep.ToolsMailgunIntegrationDefProvider provider = global::Julep.ToolsMailgunIntegrationDefProvider.Mailgun)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunIntegrationDef" /> class.
        /// </summary>
        public ToolsMailgunIntegrationDef()
        {
        }

    }
}