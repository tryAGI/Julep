
#nullable enable

namespace Julep
{
    /// <summary>
    /// Cloudinary edit integration definition
    /// </summary>
    public sealed partial class ToolsCloudinaryEditIntegrationDef
    {
        /// <summary>
        /// Default Value: media_edit
        /// </summary>
        /// <default>global::Julep.ToolsCloudinaryEditIntegrationDefMethod.MediaEdit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsCloudinaryEditIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsCloudinaryEditIntegrationDefMethod Method { get; set; } = global::Julep.ToolsCloudinaryEditIntegrationDefMethod.MediaEdit;

        /// <summary>
        /// Arguments for Cloudinary media edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsCloudinaryEditArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments">
        /// Arguments for Cloudinary media edit
        /// </param>
        /// <param name="method">
        /// Default Value: media_edit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryEditIntegrationDef(
            global::Julep.ToolsCloudinaryEditArguments? arguments,
            global::Julep.ToolsCloudinaryEditIntegrationDefMethod method = global::Julep.ToolsCloudinaryEditIntegrationDefMethod.MediaEdit)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditIntegrationDef" /> class.
        /// </summary>
        public ToolsCloudinaryEditIntegrationDef()
        {
        }
    }
}