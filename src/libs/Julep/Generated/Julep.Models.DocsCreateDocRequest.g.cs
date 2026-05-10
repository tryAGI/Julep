
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for creating a doc
    /// </summary>
    public sealed partial class DocsCreateDocRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Title describing what this document contains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Contents of the document. Each string is limited to 30k characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> Content { get; set; }

        /// <summary>
        /// Instruction for the embedding model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_instruction")]
        public string? EmbedInstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCreateDocRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Title describing what this document contains
        /// </param>
        /// <param name="content">
        /// Contents of the document. Each string is limited to 30k characters.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="embedInstruction">
        /// Instruction for the embedding model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsCreateDocRequest(
            string title,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> content,
            object? metadata,
            string? embedInstruction)
        {
            this.Metadata = metadata;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content;
            this.EmbedInstruction = embedInstruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCreateDocRequest" /> class.
        /// </summary>
        public DocsCreateDocRequest()
        {
        }

    }
}