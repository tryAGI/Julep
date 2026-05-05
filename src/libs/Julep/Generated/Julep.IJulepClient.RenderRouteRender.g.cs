#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Render system prompt for the session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ChatRenderResponse> RenderRouteRenderAsync(
            global::System.Guid id,

            global::Julep.ChatChatInput request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render system prompt for the session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.AutoSDKHttpResponse<global::Julep.ChatRenderResponse>> RenderRouteRenderAsResponseAsync(
            global::System.Guid id,

            global::Julep.ChatChatInput request,
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ChatRenderResponse> RenderRouteRenderAsync(
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
            global::Julep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}