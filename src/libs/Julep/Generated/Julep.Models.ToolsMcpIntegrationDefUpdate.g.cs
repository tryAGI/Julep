
#nullable enable

namespace Julep
{
    /// <summary>
    /// MCP integration definition
    /// </summary>
    public sealed partial class ToolsMcpIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "mcp"<br/>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMcpIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsMcpIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for MCP
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsMcpSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for MCP methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsMcpCallToolArgumentsUpdate, global::Julep.ToolsMcpListToolsArgumentsUpdate>))]
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArgumentsUpdate, global::Julep.ToolsMcpListToolsArgumentsUpdate>? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "mcp"<br/>
        /// Default Value: mcp
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for MCP
        /// </param>
        /// <param name="arguments">
        /// The arguments for MCP methods
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpIntegrationDefUpdate(
            global::Julep.ToolsMcpIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsMcpSetupUpdate? setup,
            global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArgumentsUpdate, global::Julep.ToolsMcpListToolsArgumentsUpdate>? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsMcpIntegrationDefUpdate()
        {
        }
    }
}