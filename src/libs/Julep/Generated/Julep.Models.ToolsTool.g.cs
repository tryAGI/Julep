
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsTool
    {
        /// <summary>
        /// Name of the tool (must be unique for this agent and a valid python identifier string )
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsToolType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ToolsDummyIntegrationDef, global::Julep.ToolsBraveIntegrationDef, global::Julep.ToolsEmailIntegrationDef, global::Julep.ToolsSpiderIntegrationDef, global::Julep.ToolsWikipediaIntegrationDef, global::Julep.ToolsWeatherIntegrationDef, global::Julep.ToolsMailgunIntegrationDef, global::Julep.ToolsBrowserbaseContextIntegrationDef, global::Julep.ToolsBrowserbaseExtensionIntegrationDef, global::Julep.ToolsBrowserbaseListSessionsIntegrationDef, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionIntegrationDef, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef, global::Julep.ToolsRemoteBrowserIntegrationDef, global::Julep.ToolsLlamaParseIntegrationDef, global::Julep.ToolsFfmpegIntegrationDef, global::Julep.ToolsCloudinaryUploadIntegrationDef, global::Julep.ToolsCloudinaryEditIntegrationDef, global::Julep.ToolsArxivIntegrationDef, global::Julep.ToolsUnstructuredIntegrationDef, global::Julep.ToolsAlgoliaIntegrationDef, global::Julep.ToolsMcpIntegrationDef, global::Julep.ToolsGoogleSheetsIntegrationDef>))]
        public global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDef, global::Julep.ToolsBraveIntegrationDef, global::Julep.ToolsEmailIntegrationDef, global::Julep.ToolsSpiderIntegrationDef, global::Julep.ToolsWikipediaIntegrationDef, global::Julep.ToolsWeatherIntegrationDef, global::Julep.ToolsMailgunIntegrationDef, global::Julep.ToolsBrowserbaseContextIntegrationDef, global::Julep.ToolsBrowserbaseExtensionIntegrationDef, global::Julep.ToolsBrowserbaseListSessionsIntegrationDef, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionIntegrationDef, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef, global::Julep.ToolsRemoteBrowserIntegrationDef, global::Julep.ToolsLlamaParseIntegrationDef, global::Julep.ToolsFfmpegIntegrationDef, global::Julep.ToolsCloudinaryUploadIntegrationDef, global::Julep.ToolsCloudinaryEditIntegrationDef, global::Julep.ToolsArxivIntegrationDef, global::Julep.ToolsUnstructuredIntegrationDef, global::Julep.ToolsAlgoliaIntegrationDef, global::Julep.ToolsMcpIntegrationDef, global::Julep.ToolsGoogleSheetsIntegrationDef>? Integration { get; set; }

        /// <summary>
        /// The system to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::Julep.ToolsSystemDef? System { get; set; }

        /// <summary>
        /// The API call to make
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_call")]
        public global::Julep.ToolsApiCallDef? ApiCall { get; set; }

        /// <summary>
        /// (Alpha) Anthropic new tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computer_20241022")]
        public global::Julep.ToolsComputer20241022Def? Computer20241022 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_editor_20241022")]
        public global::Julep.ToolsTextEditor20241022Def? TextEditor20241022 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bash_20241022")]
        public global::Julep.ToolsBash20241022Def? Bash20241022 { get; set; }

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsTool" /> class.
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
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsTool(
            string name,
            global::Julep.ToolsToolType type,
            string? description,
            global::Julep.ToolsFunctionDef? function,
            global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDef, global::Julep.ToolsBraveIntegrationDef, global::Julep.ToolsEmailIntegrationDef, global::Julep.ToolsSpiderIntegrationDef, global::Julep.ToolsWikipediaIntegrationDef, global::Julep.ToolsWeatherIntegrationDef, global::Julep.ToolsMailgunIntegrationDef, global::Julep.ToolsBrowserbaseContextIntegrationDef, global::Julep.ToolsBrowserbaseExtensionIntegrationDef, global::Julep.ToolsBrowserbaseListSessionsIntegrationDef, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionIntegrationDef, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef, global::Julep.ToolsRemoteBrowserIntegrationDef, global::Julep.ToolsLlamaParseIntegrationDef, global::Julep.ToolsFfmpegIntegrationDef, global::Julep.ToolsCloudinaryUploadIntegrationDef, global::Julep.ToolsCloudinaryEditIntegrationDef, global::Julep.ToolsArxivIntegrationDef, global::Julep.ToolsUnstructuredIntegrationDef, global::Julep.ToolsAlgoliaIntegrationDef, global::Julep.ToolsMcpIntegrationDef, global::Julep.ToolsGoogleSheetsIntegrationDef>? integration,
            global::Julep.ToolsSystemDef? system,
            global::Julep.ToolsApiCallDef? apiCall,
            global::Julep.ToolsComputer20241022Def? computer20241022,
            global::Julep.ToolsTextEditor20241022Def? textEditor20241022,
            global::Julep.ToolsBash20241022Def? bash20241022,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!,
            global::System.Guid id = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.Function = function;
            this.Integration = integration;
            this.System = system;
            this.ApiCall = apiCall;
            this.Computer20241022 = computer20241022;
            this.TextEditor20241022 = textEditor20241022;
            this.Bash20241022 = bash20241022;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsTool" /> class.
        /// </summary>
        public ToolsTool()
        {
        }
    }
}