
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for creating a file
    /// </summary>
    public sealed partial class FilesCreateFileRequest
    {
        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// MIME type of the file<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Base64 encoded content of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Project canonical name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateFileRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the file
        /// </param>
        /// <param name="description">
        /// Description of the file
        /// </param>
        /// <param name="content">
        /// Base64 encoded content of the file
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="project">
        /// Project canonical name of the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesCreateFileRequest(
            string name,
            string description,
            string content,
            string? mimeType,
            string? project)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MimeType = mimeType;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateFileRequest" /> class.
        /// </summary>
        public FilesCreateFileRequest()
        {
        }

    }
}