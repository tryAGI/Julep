
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "provider",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsAlgoliaIntegrationDefUpdate), typeDiscriminator: "algolia")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsArxivIntegrationDefUpdate), typeDiscriminator: "arxiv")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBraveIntegrationDefUpdate), typeDiscriminator: "brave")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdate), typeDiscriminator: "browserbase")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBaseCloudinaryIntegrationDefUpdate), typeDiscriminator: "cloudinary")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsEmailIntegrationDefUpdate), typeDiscriminator: "email")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsFfmpegIntegrationDefUpdate), typeDiscriminator: "ffmpeg")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsGoogleSheetsIntegrationDefUpdate), typeDiscriminator: "google_sheets")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsLlamaParseIntegrationDefUpdate), typeDiscriminator: "llama_parse")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsMailgunIntegrationDefUpdate), typeDiscriminator: "mailgun")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsMcpIntegrationDefUpdate), typeDiscriminator: "mcp")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsRemoteBrowserIntegrationDefUpdate), typeDiscriminator: "remote_browser")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsSpiderIntegrationDefUpdate), typeDiscriminator: "spider")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsUnstructuredIntegrationDefUpdate), typeDiscriminator: "unstructured")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsWeatherIntegrationDefUpdate), typeDiscriminator: "weather")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsWikipediaIntegrationDefUpdate), typeDiscriminator: "wikipedia")]
    public partial class ToolsBaseIntegrationDefUpdate
    {
        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters the integration accepts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public object? Setup { get; set; }

        /// <summary>
        /// The arguments to pre-apply to the integration call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters the integration accepts
        /// </param>
        /// <param name="arguments">
        /// The arguments to pre-apply to the integration call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBaseIntegrationDefUpdate(
            string? method,
            object? setup,
            object? arguments)
        {
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBaseIntegrationDefUpdate()
        {
        }

    }
}