
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {
        partial void PrepareAgentToolsRoutePatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref global::System.Guid childId,
            global::Julep.ToolsPatchToolRequest request);
        partial void PrepareAgentToolsRoutePatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::System.Guid childId,
            global::Julep.ToolsPatchToolRequest request);
        partial void ProcessAgentToolsRoutePatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentToolsRoutePatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch a resource owned by the given parent using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="childId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> AgentToolsRoutePatchAsync(
            global::System.Guid id,
            global::System.Guid childId,

            global::Julep.ToolsPatchToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentToolsRoutePatchArguments(
                httpClient: HttpClient,
                id: ref id,
                childId: ref childId,
                request: request);

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/agents/{id}/tools/{childId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareAgentToolsRoutePatchRequest(
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
            ProcessAgentToolsRoutePatchResponse(
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
                ProcessAgentToolsRoutePatchResponseContent(
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
        public async global::System.Threading.Tasks.Task<string> AgentToolsRoutePatchAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.ToolsPatchToolRequest
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

            return await AgentToolsRoutePatchAsync(
                id: id,
                childId: childId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}