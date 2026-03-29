
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsDocReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The owner of this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.DocsDocOwner Owner { get; set; }

        /// <summary>
        /// ID of the document<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.DocsSnippet Snippet { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocReference" /> class.
        /// </summary>
        /// <param name="owner">
        /// The owner of this document.
        /// </param>
        /// <param name="snippet"></param>
        /// <param name="metadata"></param>
        /// <param name="title"></param>
        /// <param name="distance">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="id">
        /// ID of the document<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsDocReference(
            global::Julep.DocsDocOwner owner,
            global::Julep.DocsSnippet snippet,
            object? metadata,
            string? title,
            double? distance,
            global::System.Guid id = default!)
        {
            this.Metadata = metadata;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Id = id;
            this.Title = title;
            this.Snippet = snippet ?? throw new global::System.ArgumentNullException(nameof(snippet));
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocReference" /> class.
        /// </summary>
        public DocsDocReference()
        {
        }
    }
}