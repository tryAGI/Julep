
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {
        partial void PrepareRenderRouteRenderArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::Julep.ChatChatInput request);
        partial void PrepareRenderRouteRenderRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::Julep.ChatChatInput request);
        partial void ProcessRenderRouteRenderResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRenderRouteRenderResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Render system prompt for the session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.ChatRenderResponse> RenderRouteRenderAsync(
            global::System.Guid id,

            global::Julep.ChatChatInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRenderRouteRenderArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::Julep.PathBuilder(
                path: $"/sessions/{id}/render",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRenderRouteRenderRequest(
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
            ProcessRenderRouteRenderResponse(
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
                ProcessRenderRouteRenderResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Julep.ChatRenderResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Julep.ChatRenderResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Render system prompt for the session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="recall">
        /// Whether previous memories and docs should be recalled or not<br/>
        /// Default Value: true
        /// </param>
        /// <param name="save">
        /// Whether this interaction should be stored in the session history or not<br/>
        /// Default Value: true
        /// </param>
        /// <param name="model">
        /// Identifier of the model to be used
        /// </param>
        /// <param name="stream">
        /// Indicates if the server should stream the response as it's generated<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically for that particular seed value
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the chat completion
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion
        /// </param>
        /// <param name="responseFormat">
        /// Response format (set to `json_object` to restrict output to JSON)
        /// </param>
        /// <param name="agent">
        /// Agent ID of the agent to use for this interaction. (Only applicable for multi-agent sessions)
        /// </param>
        /// <param name="repetitionPenalty">
        /// Number between 0 and 2.0. 1.0 is neutral and values larger than that penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </param>
        /// <param name="lengthPenalty">
        /// Number between 0 and 2.0. 1.0 is neutral and values larger than that penalize number of tokens generated.
        /// </param>
        /// <param name="minP">
        /// Minimum probability compared to leading token to be considered
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// </param>
        /// <param name="topP">
        /// Defaults to 1 An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or temperature but not both.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="autoRunTools">
        /// Whether to automatically run tools and send the results back to the model (requires tools or agents with tools).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recallTools">
        /// Whether to include tool requests and responses when recalling messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.ChatRenderResponse> RenderRouteRenderAsync(
            global::System.Guid id,
            bool recall,
            bool save,
            bool stream,
            global::System.Collections.Generic.IList<string> stop,
            bool autoRunTools,
            bool recallTools,
            string? model = default,
            short? seed = default,
            int? maxTokens = default,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias = default,
            global::Julep.AnyOf<global::Julep.ChatSimpleCompletionResponseFormat, global::Julep.ChatSchemaCompletionResponseFormat>? responseFormat = default,
            global::System.Guid? agent = default,
            float? repetitionPenalty = default,
            float? lengthPenalty = default,
            float? minP = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            float? temperature = default,
            float? topP = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.ChatChatInput
            {
                Recall = recall,
                Save = save,
                Model = model,
                Stream = stream,
                Stop = stop,
                Seed = seed,
                MaxTokens = maxTokens,
                LogitBias = logitBias,
                ResponseFormat = responseFormat,
                Agent = agent,
                RepetitionPenalty = repetitionPenalty,
                LengthPenalty = lengthPenalty,
                MinP = minP,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                Temperature = temperature,
                TopP = topP,
                Metadata = metadata,
                AutoRunTools = autoRunTools,
                RecallTools = recallTools,
            };

            return await RenderRouteRenderAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}