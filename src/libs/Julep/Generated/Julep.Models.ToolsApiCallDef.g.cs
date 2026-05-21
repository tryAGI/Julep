
#nullable enable

namespace Julep
{
    /// <summary>
    /// API call definition
    /// </summary>
    public sealed partial class ToolsApiCallDef
    {
        /// <summary>
        /// The HTTP method to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsApiCallDefMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsApiCallDefMethod Method { get; set; }

        /// <summary>
        /// The URL to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The schema of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The headers to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Secret references to use in templates (available only at setup time, not during execution)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRef>? Secrets { get; set; }

        /// <summary>
        /// The content as base64 to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The data to send as form data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The data to send as files data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public object? Files { get; set; }

        /// <summary>
        /// JSON body to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public object? Json { get; set; }

        /// <summary>
        /// Cookies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookies")]
        public global::System.Collections.Generic.Dictionary<string, string>? Cookies { get; set; }

        /// <summary>
        /// The parameters to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::Julep.AnyOf<string, object>? Params { get; set; }

        /// <summary>
        /// The schema of the parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params_schema")]
        public global::Julep.ToolsParameterSchema? ParamsSchema { get; set; }

        /// <summary>
        /// Follow redirects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_redirects")]
        public bool? FollowRedirects { get; set; }

        /// <summary>
        /// The timeout for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public byte? Timeout { get; set; }

        /// <summary>
        /// Whether to include the content in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_response_content")]
        public bool? IncludeResponseContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApiCallDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The HTTP method to use
        /// </param>
        /// <param name="url">
        /// The URL to call
        /// </param>
        /// <param name="schema">
        /// The schema of the response
        /// </param>
        /// <param name="headers">
        /// The headers to send with the request
        /// </param>
        /// <param name="secrets">
        /// Secret references to use in templates (available only at setup time, not during execution)
        /// </param>
        /// <param name="content">
        /// The content as base64 to send with the request
        /// </param>
        /// <param name="data">
        /// The data to send as form data
        /// </param>
        /// <param name="files">
        /// The data to send as files data
        /// </param>
        /// <param name="json">
        /// JSON body to send with the request
        /// </param>
        /// <param name="cookies">
        /// Cookies
        /// </param>
        /// <param name="params">
        /// The parameters to send with the request
        /// </param>
        /// <param name="paramsSchema">
        /// The schema of the parameters
        /// </param>
        /// <param name="followRedirects">
        /// Follow redirects
        /// </param>
        /// <param name="timeout">
        /// The timeout for the request
        /// </param>
        /// <param name="includeResponseContent">
        /// Whether to include the content in the response<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsApiCallDef(
            global::Julep.ToolsApiCallDefMethod method,
            string url,
            object? schema,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRef>? secrets,
            string? content,
            object? data,
            object? files,
            object? json,
            global::System.Collections.Generic.Dictionary<string, string>? cookies,
            global::Julep.AnyOf<string, object>? @params,
            global::Julep.ToolsParameterSchema? paramsSchema,
            bool? followRedirects,
            byte? timeout,
            bool? includeResponseContent)
        {
            this.Method = method;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Schema = schema;
            this.Headers = headers;
            this.Secrets = secrets;
            this.Content = content;
            this.Data = data;
            this.Files = files;
            this.Json = json;
            this.Cookies = cookies;
            this.Params = @params;
            this.ParamsSchema = paramsSchema;
            this.FollowRedirects = followRedirects;
            this.Timeout = timeout;
            this.IncludeResponseContent = includeResponseContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApiCallDef" /> class.
        /// </summary>
        public ToolsApiCallDef()
        {
        }

    }
}