
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Spider integration
    /// </summary>
    public sealed partial class ToolsSpiderFetchArguments
    {
        /// <summary>
        /// The URL to fetch data from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The content type to return<br/>
        /// Default Value: application/json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSpiderFetchArgumentsContentTypeJsonConverter))]
        public global::Julep.ToolsSpiderFetchArgumentsContentType? ContentType { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolsSpiderFetchArguments" /> class.
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
        public ToolsSpiderFetchArguments(
            string url,
            global::Julep.ToolsSpiderFetchArgumentsContentType? contentType,
            object? @params)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ContentType = contentType;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderFetchArguments" /> class.
        /// </summary>
        public ToolsSpiderFetchArguments()
        {
        }

    }
}