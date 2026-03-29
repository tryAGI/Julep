
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Cloudinary media edit
    /// </summary>
    public sealed partial class ToolsCloudinaryEditArguments
    {
        /// <summary>
        /// The file Public ID in Cloudinary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicId { get; set; }

        /// <summary>
        /// The transformation to apply to the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Transformation { get; set; }

        /// <summary>
        /// Return base64 encoded file<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditArguments" /> class.
        /// </summary>
        /// <param name="publicId">
        /// The file Public ID in Cloudinary
        /// </param>
        /// <param name="transformation">
        /// The transformation to apply to the file
        /// </param>
        /// <param name="returnBase64">
        /// Return base64 encoded file<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryEditArguments(
            string publicId,
            global::System.Collections.Generic.IList<object> transformation,
            bool returnBase64)
        {
            this.PublicId = publicId ?? throw new global::System.ArgumentNullException(nameof(publicId));
            this.Transformation = transformation ?? throw new global::System.ArgumentNullException(nameof(transformation));
            this.ReturnBase64 = returnBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditArguments" /> class.
        /// </summary>
        public ToolsCloudinaryEditArguments()
        {
        }
    }
}