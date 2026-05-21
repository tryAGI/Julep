
#nullable enable

namespace Julep
{
    /// <summary>
    /// Cloudinary upload integration definition
    /// </summary>
    public sealed partial class ToolsCloudinaryUploadIntegrationDef
    {
        /// <summary>
        /// Default Value: media_upload
        /// </summary>
        /// <default>global::Julep.ToolsCloudinaryUploadIntegrationDefMethod.MediaUpload</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsCloudinaryUploadIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsCloudinaryUploadIntegrationDefMethod Method { get; set; } = global::Julep.ToolsCloudinaryUploadIntegrationDefMethod.MediaUpload;

        /// <summary>
        /// Arguments for Cloudinary media upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsCloudinaryUploadArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments">
        /// Arguments for Cloudinary media upload
        /// </param>
        /// <param name="method">
        /// Default Value: media_upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryUploadIntegrationDef(
            global::Julep.ToolsCloudinaryUploadArguments? arguments,
            global::Julep.ToolsCloudinaryUploadIntegrationDefMethod method = global::Julep.ToolsCloudinaryUploadIntegrationDefMethod.MediaUpload)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadIntegrationDef" /> class.
        /// </summary>
        public ToolsCloudinaryUploadIntegrationDef()
        {
        }

    }
}