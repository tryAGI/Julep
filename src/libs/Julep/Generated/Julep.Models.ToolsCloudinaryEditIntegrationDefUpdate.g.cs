
#nullable enable

namespace Julep
{
    /// <summary>
    /// Cloudinary edit integration definition
    /// </summary>
    public sealed partial class ToolsCloudinaryEditIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: media_edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsCloudinaryEditIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsCloudinaryEditIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// Arguments for Cloudinary media edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsCloudinaryEditArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: media_edit
        /// </param>
        /// <param name="arguments">
        /// Arguments for Cloudinary media edit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinaryEditIntegrationDefUpdate(
            global::Julep.ToolsCloudinaryEditIntegrationDefUpdateMethod? method,
            global::Julep.ToolsCloudinaryEditArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinaryEditIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsCloudinaryEditIntegrationDefUpdate()
        {
        }
    }
}