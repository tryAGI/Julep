
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Unstructured integration
    /// </summary>
    public sealed partial class ToolsUnstructuredSetup
    {
        /// <summary>
        /// The API key for Unstructured.io
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unstructured_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnstructuredApiKey { get; set; }

        /// <summary>
        /// Optional server endpoint URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// The server by name to use for all methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public string? Server { get; set; }

        /// <summary>
        /// Parameters to optionally template the server URL with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_params")]
        public object? UrlParams { get; set; }

        /// <summary>
        /// The retry configuration to use for all supported methods
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_config")]
        public object? RetryConfig { get; set; }

        /// <summary>
        /// Optional request timeout applied to each operation in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public short? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredSetup" /> class.
        /// </summary>
        /// <param name="unstructuredApiKey">
        /// The API key for Unstructured.io
        /// </param>
        /// <param name="serverUrl">
        /// Optional server endpoint URL
        /// </param>
        /// <param name="server">
        /// The server by name to use for all methods
        /// </param>
        /// <param name="urlParams">
        /// Parameters to optionally template the server URL with
        /// </param>
        /// <param name="retryConfig">
        /// The retry configuration to use for all supported methods
        /// </param>
        /// <param name="timeoutMs">
        /// Optional request timeout applied to each operation in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsUnstructuredSetup(
            string unstructuredApiKey,
            string? serverUrl,
            string? server,
            object? urlParams,
            object? retryConfig,
            short? timeoutMs)
        {
            this.UnstructuredApiKey = unstructuredApiKey ?? throw new global::System.ArgumentNullException(nameof(unstructuredApiKey));
            this.ServerUrl = serverUrl;
            this.Server = server;
            this.UrlParams = urlParams;
            this.RetryConfig = retryConfig;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredSetup" /> class.
        /// </summary>
        public ToolsUnstructuredSetup()
        {
        }
    }
}