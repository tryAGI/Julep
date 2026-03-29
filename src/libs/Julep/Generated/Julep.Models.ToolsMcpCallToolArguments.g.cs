
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments to call a named tool on the MCP server
    /// </summary>
    public sealed partial class ToolsMcpCallToolArguments
    {
        /// <summary>
        /// The MCP tool name to invoke
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// JSON-serializable arguments to pass to the MCP tool<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Optional per-call timeout in seconds<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpCallToolArguments" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The MCP tool name to invoke
        /// </param>
        /// <param name="arguments">
        /// JSON-serializable arguments to pass to the MCP tool<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Optional per-call timeout in seconds<br/>
        /// Default Value: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpCallToolArguments(
            string toolName,
            object? arguments,
            int? timeoutSeconds)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Arguments = arguments;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpCallToolArguments" /> class.
        /// </summary>
        public ToolsMcpCallToolArguments()
        {
        }
    }
}