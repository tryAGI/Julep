
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Spider integration
    /// </summary>
    public sealed partial class ToolsSpiderFetchArgumentsUpdate
    {
        /// <summary>
        /// The URL to fetch data from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The content type to return<br/>
        /// Default Value: application/json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderFetchArgumentsUpdateContentTypeJsonConverter))]
        public global::Julep.ToolsSpiderFetchArgumentsUpdateContentType? ContentType { get; set; }

        /// <summary>
        /// Additional parameters for the Spider API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderFetchArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch data from
        /// </param>
        /// <param name="contentType">
        /// The content type to return<br/>
        /// Default Value: application/json
        /// </param>
        /// <param name="params">
        /// Additional parameters for the Spider API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSpiderFetchArgumentsUpdate(
            string? url,
            global::Julep.ToolsSpiderFetchArgumentsUpdateContentType? contentType,
            object? @params)
        {
            this.Url = url;
            this.ContentType = contentType;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderFetchArgumentsUpdate" /> class.
        /// </summary>
        public ToolsSpiderFetchArgumentsUpdate()
        {
        }
    }
}