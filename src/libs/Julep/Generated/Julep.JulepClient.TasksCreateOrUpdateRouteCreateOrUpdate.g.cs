
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {


        private static readonly global::Julep.EndPointSecurityRequirement s_TasksCreateOrUpdateRouteCreateOrUpdateSecurityRequirement0 =
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
        private static readonly global::Julep.EndPointSecurityRequirement[] s_TasksCreateOrUpdateRouteCreateOrUpdateSecurityRequirements =
            new global::Julep.EndPointSecurityRequirement[]
            {                s_TasksCreateOrUpdateRouteCreateOrUpdateSecurityRequirement0,
            };
        partial void PrepareTasksCreateOrUpdateRouteCreateOrUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid parentId,
            ref global::System.Guid id,
            global::Julep.TasksCreateTaskRequest request);
        partial void PrepareTasksCreateOrUpdateRouteCreateOrUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid parentId,
            global::System.Guid id,
            global::Julep.TasksCreateTaskRequest request);
        partial void ProcessTasksCreateOrUpdateRouteCreateOrUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTasksCreateOrUpdateRouteCreateOrUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update a task
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksCreateOrUpdateRouteCreateOrUpdateAsync(
            global::System.Guid parentId,
            global::System.Guid id,

            global::Julep.TasksCreateTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTasksCreateOrUpdateRouteCreateOrUpdateArguments(
                httpClient: HttpClient,
                parentId: ref parentId,
                id: ref id,
                request: request);


            var __authorizations = global::Julep.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TasksCreateOrUpdateRouteCreateOrUpdateSecurityRequirements,
                operationName: "TasksCreateOrUpdateRouteCreateOrUpdateAsync");

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/agents/{parentId}/tasks/{id}",
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
                mediaType: "application/yaml");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTasksCreateOrUpdateRouteCreateOrUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                parentId: parentId,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTasksCreateOrUpdateRouteCreateOrUpdateResponse(
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
                ProcessTasksCreateOrUpdateRouteCreateOrUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Julep.TasksTask.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Julep.TasksTask.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Create or update a task
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="id"></param>
        /// <param name="name">
        /// The name of the task.
        /// </param>
        /// <param name="canonicalName">
        /// The canonical name of the task.
        /// </param>
        /// <param name="description">
        /// The description of the task.
        /// </param>
        /// <param name="main">
        /// The entrypoint of the task.
        /// </param>
        /// <param name="inputSchema">
        /// The schema for the input to the task. `null` means all inputs are valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Tools defined specifically for this task not included in the Agent itself.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="inheritTools">
        /// Whether to inherit tools from the parent agent or not. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.TasksTask> TasksCreateOrUpdateRouteCreateOrUpdateAsync(
            global::System.Guid parentId,
            global::System.Guid id,
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep, global::Julep.TasksReturnStep, global::Julep.TasksSleepStep, global::Julep.TasksErrorWorkflowStep, global::Julep.TasksWaitForInputStep, global::Julep.TasksIfElseWorkflowStep, global::Julep.TasksSwitchStep, global::Julep.TasksForeachStep, global::Julep.TasksParallelStep, global::Julep.TasksCreateTaskRequestMainItem>> main,
            global::System.Collections.Generic.IList<global::Julep.TasksTaskTool> tools,
            bool inheritTools,
            string? canonicalName = default,
            object? inputSchema = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.TasksCreateTaskRequest
            {
                Name = name,
                CanonicalName = canonicalName,
                Description = description,
                Main = main,
                InputSchema = inputSchema,
                Tools = tools,
                InheritTools = inheritTools,
                Metadata = metadata,
            };

            return await TasksCreateOrUpdateRouteCreateOrUpdateAsync(
                parentId: parentId,
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}