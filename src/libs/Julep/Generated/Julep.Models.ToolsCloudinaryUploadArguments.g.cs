
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Cloudinary media upload
    /// </summary>
    public sealed partial class ToolsCloudinaryUploadArguments
    {
        /// <summary>
        /// The URL of the file upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string File { get; set; }

        /// <summary>
        /// Return base64 encoded file<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnBase64 { get; set; }

        /// <summary>
        /// Optional public ID for the uploaded file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        public string? PublicId { get; set; }

        /// <summary>
        /// Optional upload parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_params")]
        public object? UploadParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadArguments" /> class.
        /// </summary>
        /// <param name="file">
        /// The URL of the file upload
        /// </param>
        /// <param name="returnBase64">
        /// Return base64 encoded file<br/>
        /// Default Value: false
        /// </param>
        /// <param name="publicId">
        /// Optional public ID for the uploaded file
        /// </param>
        /// <param name="uploadParams">
        /// Optional upload parameters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryUploadArguments(
            string file,
            bool returnBase64,
            string? publicId,
            object? uploadParams)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.ReturnBase64 = returnBase64;
            this.PublicId = publicId;
            this.UploadParams = uploadParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadArguments" /> class.
        /// </summary>
        public ToolsCloudinaryUploadArguments()
        {
        }

    }
}