#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.ResponsesResponse> ResponsesRouteCreateResponseAsync(

            global::Julep.ResponsesCreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Julep.ResponsesResponse> ResponsesRouteCreateResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}