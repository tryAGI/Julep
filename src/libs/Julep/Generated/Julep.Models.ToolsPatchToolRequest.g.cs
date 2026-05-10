
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a tool
    /// </summary>
    public sealed partial class ToolsPatchToolRequest
    {
        /// <summary>
        /// Name of the tool (must be unique for this agent and a valid python identifier string )
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsToolTypeJsonConverter))]
        public global::Julep.ToolsToolType? Type { get; set; }

        /// <summary>
        /// Description of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The function to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Julep.ToolsFunctionDef? Function { get; set; }

        /// <summary>
        /// The integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsDummyIntegrationDefUpdate, global::Julep.ToolsBraveIntegrationDefUpdate, global::Julep.ToolsEmailIntegrationDefUpdate, global::Julep.ToolsSpiderIntegrationDefUpdate, global::Julep.ToolsWikipediaIntegrationDefUpdate, global::Julep.ToolsWeatherIntegrationDefUpdate, global::Julep.ToolsMailgunIntegrationDefUpdate, global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate, global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate, global::Julep.ToolsRemoteBrowserIntegrationDefUpdate, global::Julep.ToolsLlamaParseIntegrationDefUpdate, global::Julep.ToolsFfmpegIntegrationDefUpdate, global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate, global::Julep.ToolsCloudinaryEditIntegrationDefUpdate, global::Julep.ToolsArxivIntegrationDefUpdate, global::Julep.ToolsUnstructuredIntegrationDefUpdate, global::Julep.ToolsAlgoliaIntegrationDefUpdate, global::Julep.ToolsMcpIntegrationDefUpdate, global::Julep.ToolsGoogleSheetsIntegrationDefUpdate>))]
        public global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDefUpdate, global::Julep.ToolsBraveIntegrationDefUpdate, global::Julep.ToolsEmailIntegrationDefUpdate, global::Julep.ToolsSpiderIntegrationDefUpdate, global::Julep.ToolsWikipediaIntegrationDefUpdate, global::Julep.ToolsWeatherIntegrationDefUpdate, global::Julep.ToolsMailgunIntegrationDefUpdate, global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate, global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate, global::Julep.ToolsRemoteBrowserIntegrationDefUpdate, global::Julep.ToolsLlamaParseIntegrationDefUpdate, global::Julep.ToolsFfmpegIntegrationDefUpdate, global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate, global::Julep.ToolsCloudinaryEditIntegrationDefUpdate, global::Julep.ToolsArxivIntegrationDefUpdate, global::Julep.ToolsUnstructuredIntegrationDefUpdate, global::Julep.ToolsAlgoliaIntegrationDefUpdate, global::Julep.ToolsMcpIntegrationDefUpdate, global::Julep.ToolsGoogleSheetsIntegrationDefUpdate>? Integration { get; set; }

        /// <summary>
        /// The system to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::Julep.ToolsSystemDefUpdate? System { get; set; }

        /// <summary>
        /// The API call to make
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_call")]
        public global::Julep.ToolsApiCallDefUpdate? ApiCall { get; set; }

        /// <summary>
        /// (Alpha) Anthropic new tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computer_20241022")]
        public global::Julep.ToolsComputer20241022DefUpdate? Computer20241022 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_editor_20241022")]
        public global::Julep.ToolsTextEditor20241022DefUpdate? TextEditor20241022 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bash_20241022")]
        public global::Julep.ToolsBash20241022DefUpdate? Bash20241022 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPatchToolRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool (must be unique for this agent and a valid python identifier string )
        /// </param>
        /// <param name="type">
        /// Type of the tool
        /// </param>
        /// <param name="description">
        /// Description of the tool
        /// </param>
        /// <param name="function">
        /// The function to call
        /// </param>
        /// <param name="integration">
        /// The integration to call
        /// </param>
        /// <param name="system">
        /// The system to call
        /// </param>
        /// <param name="apiCall">
        /// The API call to make
        /// </param>
        /// <param name="computer20241022">
        /// (Alpha) Anthropic new tools
        /// </param>
        /// <param name="textEditor20241022"></param>
        /// <param name="bash20241022"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsPatchToolRequest(
            string? name,
            global::Julep.ToolsToolType? type,
            string? description,
            global::Julep.ToolsFunctionDef? function,
            global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDefUpdate, global::Julep.ToolsBraveIntegrationDefUpdate, global::Julep.ToolsEmailIntegrationDefUpdate, global::Julep.ToolsSpiderIntegrationDefUpdate, global::Julep.ToolsWikipediaIntegrationDefUpdate, global::Julep.ToolsWeatherIntegrationDefUpdate, global::Julep.ToolsMailgunIntegrationDefUpdate, global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate, global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate, global::Julep.ToolsRemoteBrowserIntegrationDefUpdate, global::Julep.ToolsLlamaParseIntegrationDefUpdate, global::Julep.ToolsFfmpegIntegrationDefUpdate, global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate, global::Julep.ToolsCloudinaryEditIntegrationDefUpdate, global::Julep.ToolsArxivIntegrationDefUpdate, global::Julep.ToolsUnstructuredIntegrationDefUpdate, global::Julep.ToolsAlgoliaIntegrationDefUpdate, global::Julep.ToolsMcpIntegrationDefUpdate, global::Julep.ToolsGoogleSheetsIntegrationDefUpdate>? integration,
            global::Julep.ToolsSystemDefUpdate? system,
            global::Julep.ToolsApiCallDefUpdate? apiCall,
            global::Julep.ToolsComputer20241022DefUpdate? computer20241022,
            global::Julep.ToolsTextEditor20241022DefUpdate? textEditor20241022,
            global::Julep.ToolsBash20241022DefUpdate? bash20241022)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Function = function;
            this.Integration = integration;
            this.System = system;
            this.ApiCall = apiCall;
            this.Computer20241022 = computer20241022;
            this.TextEditor20241022 = textEditor20241022;
            this.Bash20241022 = bash20241022;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPatchToolRequest" /> class.
        /// </summary>
        public ToolsPatchToolRequest()
        {
        }

    }
}