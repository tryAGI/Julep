
#nullable enable

namespace Julep
{
    /// <summary>
    /// Email integration definition
    /// </summary>
    public sealed partial class ToolsEmailIntegrationDef
    {
        /// <summary>
        /// The provider must be "email"<br/>
        /// Default Value: email
        /// </summary>
        /// <default>global::Julep.ToolsEmailIntegrationDefProvider.Email</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsEmailIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsEmailIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsEmailIntegrationDefProvider.Email;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsEmailSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Email sending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsEmailArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Email
        /// </param>
        /// <param name="arguments">
        /// The arguments for Email sending
        /// </param>
        /// <param name="provider">
        /// The provider must be "email"<br/>
        /// Default Value: email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsEmailIntegrationDef(
            string? method,
            global::Julep.ToolsEmailSetup? setup,
            global::Julep.ToolsEmailArguments? arguments,
            global::Julep.ToolsEmailIntegrationDefProvider provider = global::Julep.ToolsEmailIntegrationDefProvider.Email)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailIntegrationDef" /> class.
        /// </summary>
        public ToolsEmailIntegrationDef()
        {
        }
    }
}