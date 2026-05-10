
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesFileSearchToolCallResult
    {
        /// <summary>
        /// The unique ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The text that was retrieved from the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The attributes of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesVectorStoreFileAttributes Attributes { get; set; }

        /// <summary>
        /// The relevance score of the file - a value between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFileSearchToolCallResult" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique ID of the file.
        /// </param>
        /// <param name="text">
        /// The text that was retrieved from the file.
        /// </param>
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="attributes">
        /// The attributes of the file.
        /// </param>
        /// <param name="score">
        /// The relevance score of the file - a value between 0 and 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesFileSearchToolCallResult(
            string fileId,
            string text,
            string filename,
            global::Julep.ResponsesVectorStoreFileAttributes attributes,
            float score)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFileSearchToolCallResult" /> class.
        /// </summary>
        public ResponsesFileSearchToolCallResult()
        {
        }

    }
}