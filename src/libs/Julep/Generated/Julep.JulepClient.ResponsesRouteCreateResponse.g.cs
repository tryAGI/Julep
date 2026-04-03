
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {
        partial void PrepareResponsesRouteCreateResponseArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Julep.ResponsesCreateResponse request);
        partial void PrepareResponsesRouteCreateResponseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Julep.ResponsesCreateResponse request);
        partial void ProcessResponsesRouteCreateResponseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResponsesRouteCreateResponseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.ResponsesResponse> ResponsesRouteCreateResponseAsync(

            global::Julep.ResponsesCreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareResponsesRouteCreateResponseArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Julep.PathBuilder(
                path: "/responses",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareResponsesRouteCreateResponseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessResponsesRouteCreateResponseResponse(
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
                ProcessResponsesRouteCreateResponseResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Julep.ResponsesResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Julep.ResponsesResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="include"></param>
        /// <param name="parallelToolCalls">
        /// Default Value: true
        /// </param>
        /// <param name="store">
        /// Default Value: true
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="n"></param>
        /// <param name="stop"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="user"></param>
        /// <param name="instructions"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="reasoning">
        /// Reasoning configuration options for o-series models.
        /// </param>
        /// <param name="text"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="truncation"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.ResponsesResponse> ResponsesRouteCreateResponseAsync(
            string model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>> input,
            global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? include = default,
            bool? parallelToolCalls = default,
            bool? store = default,
            bool? stream = default,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            object? logitBias = default,
            string? user = default,
            string? instructions = default,
            string? previousResponseId = default,
            global::Julep.ResponsesReasoning? reasoning = default,
            global::Julep.ResponsesCreateResponseText? text = default,
            global::Julep.AnyOf<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>? toolChoice = default,
            global::System.Collections.Generic.IList<global::Julep.ResponsesTool>? tools = default,
            global::Julep.ResponsesCreateResponseTruncation? truncation = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.ResponsesCreateResponse
            {
                Model = model,
                Input = input,
                Include = include,
                ParallelToolCalls = parallelToolCalls,
                Store = store,
                Stream = stream,
                MaxTokens = maxTokens,
                Temperature = temperature,
                TopP = topP,
                N = n,
                Stop = stop,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                User = user,
                Instructions = instructions,
                PreviousResponseId = previousResponseId,
                Reasoning = reasoning,
                Text = text,
                ToolChoice = toolChoice,
                Tools = tools,
                Truncation = truncation,
                Metadata = metadata,
            };

            return await ResponsesRouteCreateResponseAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}