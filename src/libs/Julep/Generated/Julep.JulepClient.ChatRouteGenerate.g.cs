
#nullable enable

namespace Julep
{
    public partial class JulepClient
    {


        private static readonly global::Julep.EndPointSecurityRequirement s_ChatRouteGenerateSecurityRequirement0 =
            new global::Julep.EndPointSecurityRequirement
            {
                Authorizations = new global::Julep.EndPointAuthorizationRequirement[]
                {                    new global::Julep.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Julep.EndPointSecurityRequirement[] s_ChatRouteGenerateSecurityRequirements =
            new global::Julep.EndPointSecurityRequirement[]
            {                s_ChatRouteGenerateSecurityRequirement0,
            };
        partial void PrepareChatRouteGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref string? xCustomApiKey,
            global::Julep.ChatChatInput request);
        partial void PrepareChatRouteGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            string? xCustomApiKey,
            global::Julep.ChatChatInput request);
        partial void ProcessChatRouteGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatRouteGenerateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a response from the model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xCustomApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>> ChatRouteGenerateAsync(
            global::System.Guid id,

            global::Julep.ChatChatInput request,
            string? xCustomApiKey = default,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Julep.ChatChatInput
            {
                Recall = request.Recall,
                Save = request.Save,
                Model = request.Model,
                Stream = false,
                Stop = request.Stop,
                Seed = request.Seed,
                MaxTokens = request.MaxTokens,
                LogitBias = request.LogitBias,
                ResponseFormat = request.ResponseFormat,
                Agent = request.Agent,
                RepetitionPenalty = request.RepetitionPenalty,
                LengthPenalty = request.LengthPenalty,
                MinP = request.MinP,
                FrequencyPenalty = request.FrequencyPenalty,
                PresencePenalty = request.PresencePenalty,
                Temperature = request.Temperature,
                TopP = request.TopP,
                Metadata = request.Metadata,
                AutoRunTools = request.AutoRunTools,
                RecallTools = request.RecallTools,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatRouteGenerateArguments(
                httpClient: HttpClient,
                id: ref id,
                xCustomApiKey: ref xCustomApiKey,
                request: request);


            var __authorizations = global::Julep.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatRouteGenerateSecurityRequirements,
                operationName: "ChatRouteGenerateAsync");

            using var __timeoutCancellationTokenSource = global::Julep.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Julep.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Julep.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Julep.PathBuilder(
                                path: $"/sessions/{id}/chat",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Julep.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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

            if (xCustomApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-custom-api-key", xCustomApiKey.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Julep.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareChatRouteGenerateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id,
                    xCustomApiKey: xCustomApiKey,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Julep.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Julep.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatRouteGenerate",
                                methodName: "ChatRouteGenerateAsync",
                                pathTemplate: "$\"/sessions/{id}/chat\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Julep.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Julep.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatRouteGenerate",
                                methodName: "ChatRouteGenerateAsync",
                                pathTemplate: "$\"/sessions/{id}/chat\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Julep.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Julep.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Julep.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Julep.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatRouteGenerate",
                                methodName: "ChatRouteGenerateAsync",
                                pathTemplate: "$\"/sessions/{id}/chat\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Julep.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessChatRouteGenerateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Julep.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Julep.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatRouteGenerate",
                                methodName: "ChatRouteGenerateAsync",
                                pathTemplate: "$\"/sessions/{id}/chat\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Julep.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Julep.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatRouteGenerate",
                                methodName: "ChatRouteGenerateAsync",
                                pathTemplate: "$\"/sessions/{id}/chat\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessChatRouteGenerateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate a response from the model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xCustomApiKey"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>> ChatRouteGenerateAsync(
            global::System.Guid id,
            bool recall,
            bool save,
            global::System.Collections.Generic.IList<string> stop,
            bool autoRunTools,
            bool recallTools,
            string? xCustomApiKey = default,
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
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Julep.ChatChatInput
            {
                Recall = recall,
                Save = save,
                Model = model,
                Stream = false,
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

            return await ChatRouteGenerateAsync(
                id: id,
                xCustomApiKey: xCustomApiKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}