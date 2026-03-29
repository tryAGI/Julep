
#nullable enable

namespace Julep
{
    /// <summary>
    /// Cloudinary upload integration definition
    /// </summary>
    public sealed partial class ToolsCloudinaryUploadIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: media_upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsCloudinaryUploadIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsCloudinaryUploadIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// Arguments for Cloudinary media upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsCloudinaryUploadArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: media_upload
        /// </param>
        /// <param name="arguments">
        /// Arguments for Cloudinary media upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryUploadIntegrationDefUpdate(
            global::Julep.ToolsCloudinaryUploadIntegrationDefUpdateMethod? method,
            global::Julep.ToolsCloudinaryUploadArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryUploadIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsCloudinaryUploadIntegrationDefUpdate()
        {
        }
    }
}