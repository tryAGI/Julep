
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for MCP integration
    /// </summary>
    public sealed partial class ToolsMcpSetup
    {
        /// <summary>
        /// Transport used to connect to the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsMcpSetupTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsMcpSetupTransport Transport { get; set; }

        /// <summary>
        /// (stdio) Executable or command to launch the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// (stdio) Arguments for the server command<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// (stdio) Working directory for the server process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// (stdio) Environment variables for the server process<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// (http) Base URL for the MCP server (usually ends with /mcp)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_url")]
        public string? HttpUrl { get; set; }

        /// <summary>
        /// (http) Optional HTTP headers to include (e.g., Authorization)<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? HttpHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpSetup" /> class.
        /// </summary>
        /// <param name="transport">
        /// Transport used to connect to the MCP server
        /// </param>
        /// <param name="command">
        /// (stdio) Executable or command to launch the server
        /// </param>
        /// <param name="args">
        /// (stdio) Arguments for the server command<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cwd">
        /// (stdio) Working directory for the server process
        /// </param>
        /// <param name="env">
        /// (stdio) Environment variables for the server process<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="httpUrl">
        /// (http) Base URL for the MCP server (usually ends with /mcp)
        /// </param>
        /// <param name="httpHeaders">
        /// (http) Optional HTTP headers to include (e.g., Authorization)<br/>
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMcpSetup(
            global::Julep.ToolsMcpSetupTransport transport,
            string? command,
            global::System.Collections.Generic.IList<string>? args,
            string? cwd,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            string? httpUrl,
            global::System.Collections.Generic.Dictionary<string, string>? httpHeaders)
        {
            this.Transport = transport;
            this.Command = command;
            this.Args = args;
            this.Cwd = cwd;
            this.Env = env;
            this.HttpUrl = httpUrl;
            this.HttpHeaders = httpHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMcpSetup" /> class.
        /// </summary>
        public ToolsMcpSetup()
        {
        }

    }
}