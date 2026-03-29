
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
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsAlgoliaIntegrationDef), typeDiscriminator: "algolia")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsArxivIntegrationDef), typeDiscriminator: "arxiv")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBraveIntegrationDef), typeDiscriminator: "brave")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBaseBrowserbaseIntegrationDef), typeDiscriminator: "browserbase")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsBaseCloudinaryIntegrationDef), typeDiscriminator: "cloudinary")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsEmailIntegrationDef), typeDiscriminator: "email")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsFfmpegIntegrationDef), typeDiscriminator: "ffmpeg")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsGoogleSheetsIntegrationDef), typeDiscriminator: "google_sheets")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsLlamaParseIntegrationDef), typeDiscriminator: "llama_parse")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsMailgunIntegrationDef), typeDiscriminator: "mailgun")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsMcpIntegrationDef), typeDiscriminator: "mcp")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsRemoteBrowserIntegrationDef), typeDiscriminator: "remote_browser")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsSpiderIntegrationDef), typeDiscriminator: "spider")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsUnstructuredIntegrationDef), typeDiscriminator: "unstructured")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsWeatherIntegrationDef), typeDiscriminator: "weather")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.ToolsWikipediaIntegrationDef), typeDiscriminator: "wikipedia")]
    public partial class ToolsBaseIntegrationDef
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
        /// Initializes a new instance of the <see cref="ToolsBaseIntegrationDef" /> class.
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
        public ToolsBaseIntegrationDef(
            string? method,
            object? setup,
            object? arguments)
        {
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseIntegrationDef" /> class.
        /// </summary>
        public ToolsBaseIntegrationDef()
        {
        }
    }
}