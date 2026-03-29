
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsMultipleEmbedQueryRequest
    {
        /// <summary>
        /// Texts to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>
        /// Instruction for the embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbedInstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsMultipleEmbedQueryRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Texts to embed
        /// </param>
        /// <param name="embedInstruction">
        /// Instruction for the embedding model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsMultipleEmbedQueryRequest(
            global::System.Collections.Generic.IList<string> text,
            string embedInstruction)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.EmbedInstruction = embedInstruction ?? throw new global::System.ArgumentNullException(nameof(embedInstruction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsMultipleEmbedQueryRequest" /> class.
        /// </summary>
        public DocsMultipleEmbedQueryRequest()
        {
        }
    }
}