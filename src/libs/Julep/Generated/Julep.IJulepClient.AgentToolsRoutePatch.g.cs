#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Patch a resource owned by the given parent using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AgentToolsRoutePatchAsync(
            global::System.Guid id,
            global::System.Guid childId,

            global::Julep.ToolsPatchToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch a resource owned by the given parent using its id
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
        global::System.Threading.Tasks.Task<string> AgentToolsRoutePatchAsync(
            global::System.Guid id,
            global::System.Guid childId,
            string? name = default,
            global::Julep.ToolsToolType? type = default,
            string? description = default,
            global::Julep.ToolsFunctionDef? function = default,
            global::Julep.AnyOf<global::Julep.ToolsDummyIntegrationDefUpdate, global::Julep.ToolsBraveIntegrationDefUpdate, global::Julep.ToolsEmailIntegrationDefUpdate, global::Julep.ToolsSpiderIntegrationDefUpdate, global::Julep.ToolsWikipediaIntegrationDefUpdate, global::Julep.ToolsWeatherIntegrationDefUpdate, global::Julep.ToolsMailgunIntegrationDefUpdate, global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate, global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate, global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate, global::Julep.ToolsRemoteBrowserIntegrationDefUpdate, global::Julep.ToolsLlamaParseIntegrationDefUpdate, global::Julep.ToolsFfmpegIntegrationDefUpdate, global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate, global::Julep.ToolsCloudinaryEditIntegrationDefUpdate, global::Julep.ToolsArxivIntegrationDefUpdate, global::Julep.ToolsUnstructuredIntegrationDefUpdate, global::Julep.ToolsAlgoliaIntegrationDefUpdate, global::Julep.ToolsMcpIntegrationDefUpdate, global::Julep.ToolsGoogleSheetsIntegrationDefUpdate>? integration = default,
            global::Julep.ToolsSystemDefUpdate? system = default,
            global::Julep.ToolsApiCallDefUpdate? apiCall = default,
            global::Julep.ToolsComputer20241022DefUpdate? computer20241022 = default,
            global::Julep.ToolsTextEditor20241022DefUpdate? textEditor20241022 = default,
            global::Julep.ToolsBash20241022DefUpdate? bash20241022 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}