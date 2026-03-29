#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Update a resource owned by the given parent using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AgentToolsRouteUpdateAsync(
            global::System.Guid id,
            global::System.Guid childId,

            global::Julep.ToolsUpdateToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a resource owned by the given parent using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AgentToolsRouteUpdateAsync(
            global::System.Guid id,
            global::System.Guid childId,
            string name,
            global::Julep.ToolsToolType type,
            string? description = default,
            global::Julep.ToolsFunctionDef? function = default,
            global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDef, global::Julep.ToolsBraveIntegrationDef, global::Julep.ToolsEmailIntegrationDef, global::Julep.ToolsSpiderIntegrationDef, global::Julep.ToolsWikipediaIntegrationDef, global::Julep.ToolsWeatherIntegrationDef, global::Julep.ToolsMailgunIntegrationDef, global::Julep.ToolsBrowserbaseContextIntegrationDef, global::Julep.ToolsBrowserbaseExtensionIntegrationDef, global::Julep.ToolsBrowserbaseListSessionsIntegrationDef, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionIntegrationDef, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef, global::Julep.ToolsRemoteBrowserIntegrationDef, global::Julep.ToolsLlamaParseIntegrationDef, global::Julep.ToolsFfmpegIntegrationDef, global::Julep.ToolsCloudinaryUploadIntegrationDef, global::Julep.ToolsCloudinaryEditIntegrationDef, global::Julep.ToolsArxivIntegrationDef, global::Julep.ToolsUnstructuredIntegrationDef, global::Julep.ToolsAlgoliaIntegrationDef, global::Julep.ToolsMcpIntegrationDef, global::Julep.ToolsGoogleSheetsIntegrationDef>? integration = default,
            global::Julep.ToolsSystemDef? system = default,
            global::Julep.ToolsApiCallDef? apiCall = default,
            global::Julep.ToolsComputer20241022Def? computer20241022 = default,
            global::Julep.ToolsTextEditor20241022Def? textEditor20241022 = default,
            global::Julep.ToolsBash20241022Def? bash20241022 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}