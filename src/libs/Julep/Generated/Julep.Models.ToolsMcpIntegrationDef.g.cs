
#nullable enable

namespace Julep
{
    /// <summary>
    /// MCP integration definition
    /// </summary>
    public sealed partial class ToolsMcpIntegrationDef
    {
        /// <summary>
        /// The provider must be "mcp"<br/>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::Julep.ToolsMcpIntegrationDefProvider.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMcpIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsMcpIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsMcpIntegrationDefProvider.Mcp;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for MCP
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsMcpSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for MCP methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsMcpCallToolArguments, global::Julep.ToolsMcpListToolsArguments>))]
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArguments, global::Julep.ToolsMcpListToolsArguments>? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for MCP
        /// </param>
        /// <param name="arguments">
        /// The arguments for MCP methods
        /// </param>
        /// <param name="provider">
        /// The provider must be "mcp"<br/>
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpIntegrationDef(
            string? method,
            global::Julep.ToolsMcpSetup? setup,
            global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArguments, global::Julep.ToolsMcpListToolsArguments>? arguments,
            global::Julep.ToolsMcpIntegrationDefProvider provider = global::Julep.ToolsMcpIntegrationDefProvider.Mcp)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpIntegrationDef" /> class.
        /// </summary>
        public ToolsMcpIntegrationDef()
        {
        }

    }
}