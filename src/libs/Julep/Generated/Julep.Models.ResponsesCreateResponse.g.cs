
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? Include { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public object? LogitBias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Reasoning configuration options for o-series models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::Julep.ResponsesReasoning? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Julep.ResponsesCreateResponseText? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>))]
        public global::Julep.AnyOf<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Julep.ResponsesTool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesCreateResponseTruncationJsonConverter))]
        public global::Julep.ResponsesCreateResponseTruncation? Truncation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCreateResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesCreateResponse(
            string model,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>> input,
            global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? include,
            bool? parallelToolCalls,
            bool? store,
            bool? stream,
            int? maxTokens,
            double? temperature,
            double? topP,
            int? n,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            double? presencePenalty,
            double? frequencyPenalty,
            object? logitBias,
            string? user,
            string? instructions,
            string? previousResponseId,
            global::Julep.ResponsesReasoning? reasoning,
            global::Julep.ResponsesCreateResponseText? text,
            global::Julep.AnyOf<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>? toolChoice,
            global::System.Collections.Generic.IList<global::Julep.ResponsesTool>? tools,
            global::Julep.ResponsesCreateResponseTruncation? truncation,
            object? metadata)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Stream = stream;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stop = stop;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.User = user;
            this.Instructions = instructions;
            this.PreviousResponseId = previousResponseId;
            this.Reasoning = reasoning;
            this.Text = text;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Truncation = truncation;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCreateResponse" /> class.
        /// </summary>
        public ResponsesCreateResponse()
        {
        }
    }
}