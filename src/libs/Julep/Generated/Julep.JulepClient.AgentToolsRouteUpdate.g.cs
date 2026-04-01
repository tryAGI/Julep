
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {
        partial void PrepareAgentToolsRouteUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref global::System.Guid childId,
            global::Julep.ToolsUpdateToolRequest request);
        partial void PrepareAgentToolsRouteUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::System.Guid childId,
            global::Julep.ToolsUpdateToolRequest request);
        partial void ProcessAgentToolsRouteUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentToolsRouteUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a resource owned by the given parent using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> AgentToolsRouteUpdateAsync(
            global::System.Guid id,
            global::System.Guid childId,

            global::Julep.ToolsUpdateToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentToolsRouteUpdateArguments(
                httpClient: HttpClient,
                id: ref id,
                childId: ref childId,
                request: request);

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/agents/{id}/tools/{childId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentToolsRouteUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                childId: childId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentToolsRouteUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAgentToolsRouteUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Julep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Julep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<string> AgentToolsRouteUpdateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.ToolsUpdateToolRequest
            {
                Name = name,
                Type = type,
                Description = description,
                Function = function,
                Integration = integration,
                System = system,
                ApiCall = apiCall,
                Computer20241022 = computer20241022,
                TextEditor20241022 = textEditor20241022,
                Bash20241022 = bash20241022,
            };

            return await AgentToolsRouteUpdateAsync(
                id: id,
                childId: childId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}