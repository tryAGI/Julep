
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {


        private static readonly global::Julep.EndPointSecurityRequirement s_AgentToolsRouteCreateSecurityRequirement0 =
            new global::Julep.EndPointSecurityRequirement
            {
                Authorizations = new global::Julep.EndPointAuthorizationRequirement[]
                {                    new global::Julep.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Julep.EndPointSecurityRequirement[] s_AgentToolsRouteCreateSecurityRequirements =
            new global::Julep.EndPointSecurityRequirement[]
            {                s_AgentToolsRouteCreateSecurityRequirement0,
            };
        partial void PrepareAgentToolsRouteCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::Julep.AgentsCreateAgentRequest request);
        partial void PrepareAgentToolsRouteCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::Julep.AgentsCreateAgentRequest request);
        partial void ProcessAgentToolsRouteCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentToolsRouteCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new resource owned by the given parent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> AgentToolsRouteCreateAsync(
            global::System.Guid id,

            global::Julep.AgentsCreateAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentToolsRouteCreateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::Julep.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AgentToolsRouteCreateSecurityRequirements,
                operationName: "AgentToolsRouteCreateAsync");

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/agents/{id}/tools",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareAgentToolsRouteCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentToolsRouteCreateResponse(
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
                ProcessAgentToolsRouteCreateResponseContent(
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
        /// Create a new resource owned by the given parent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="project">
        /// Project canonical name of the agent
        /// </param>
        /// <param name="canonicalName">
        /// Canonical name of the agent
        /// </param>
        /// <param name="about">
        /// About the agent
        /// </param>
        /// <param name="model">
        /// Model name to use (gpt-4-turbo, gemini-nano etc)
        /// </param>
        /// <param name="instructions">
        /// Instructions for the agent<br/>
        /// Default Value: []
        /// </param>
        /// <param name="defaultSettings">
        /// Default settings for all sessions created by this agent
        /// </param>
        /// <param name="defaultSystemTemplate">
        /// Default system template for all sessions created by this agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AgentToolsRouteCreateAsync(
            global::System.Guid id,
            string name,
            string about,
            string model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>> instructions,
            string defaultSystemTemplate,
            object? metadata = default,
            string? project = default,
            string? canonicalName = default,
            object? defaultSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.AgentsCreateAgentRequest
            {
                Metadata = metadata,
                Name = name,
                Project = project,
                CanonicalName = canonicalName,
                About = about,
                Model = model,
                Instructions = instructions,
                DefaultSettings = defaultSettings,
                DefaultSystemTemplate = defaultSystemTemplate,
            };

            return await AgentToolsRouteCreateAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}