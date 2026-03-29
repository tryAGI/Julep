
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsDoc
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Title describing what this document contains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Contents of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> Content { get; set; }

        /// <summary>
        /// Embeddings for the document<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<float>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>))]
        public global::Julep.AnyOf<global::System.Collections.Generic.IList<float>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Embeddings { get; set; }

        /// <summary>
        /// Modality of the document<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// Language of the document<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Embedding model used for the document<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Dimensions of the embedding model<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimensions")]
        public int? EmbeddingDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDoc" /> class.
        /// </summary>
        /// <param name="title">
        /// Title describing what this document contains
        /// </param>
        /// <param name="content">
        /// Contents of the document
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="embeddings">
        /// Embeddings for the document<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modality">
        /// Modality of the document<br/>
        /// Included only in responses
        /// </param>
        /// <param name="language">
        /// Language of the document<br/>
        /// Included only in responses
        /// </param>
        /// <param name="embeddingModel">
        /// Embedding model used for the document<br/>
        /// Included only in responses
        /// </param>
        /// <param name="embeddingDimensions">
        /// Dimensions of the embedding model<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsDoc(
            string title,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> content,
            object? metadata,
            global::Julep.AnyOf<global::System.Collections.Generic.IList<float>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? embeddings,
            string? modality,
            string? language,
            string? embeddingModel,
            int? embeddingDimensions,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!)
        {
            this.Id = id;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content;
            this.Embeddings = embeddings;
            this.Modality = modality;
            this.Language = language;
            this.EmbeddingModel = embeddingModel;
            this.EmbeddingDimensions = embeddingDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDoc" /> class.
        /// </summary>
        public DocsDoc()
        {
        }
    }
}