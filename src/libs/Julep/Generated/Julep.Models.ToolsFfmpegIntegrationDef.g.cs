
#nullable enable

namespace Julep
{
    /// <summary>
    /// Ffmpeg integration definition
    /// </summary>
    public sealed partial class ToolsFfmpegIntegrationDef
    {
        /// <summary>
        /// The provider must be "ffmpeg"<br/>
        /// Default Value: ffmpeg
        /// </summary>
        /// <default>global::Julep.ToolsFfmpegIntegrationDefProvider.Ffmpeg</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsFfmpegIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsFfmpegIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsFfmpegIntegrationDefProvider.Ffmpeg;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Ffmpeg<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public object? Setup { get; set; }

        /// <summary>
        /// The arguments for Ffmpeg Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsFfmpegSearchArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFfmpegIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Ffmpeg<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="arguments">
        /// The arguments for Ffmpeg Search
        /// </param>
        /// <param name="provider">
        /// The provider must be "ffmpeg"<br/>
        /// Default Value: ffmpeg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsFfmpegIntegrationDef(
            string? method,
            object? setup,
            global::Julep.ToolsFfmpegSearchArguments? arguments,
            global::Julep.ToolsFfmpegIntegrationDefProvider provider = global::Julep.ToolsFfmpegIntegrationDefProvider.Ffmpeg)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFfmpegIntegrationDef" /> class.
        /// </summary>
        public ToolsFfmpegIntegrationDef()
        {
        }

    }
}