
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatChatInput
    {
        /// <summary>
        /// DISABLED: Whether this interaction should form new memories or not (will be enabled in a future release)<br/>
        /// Default Value: false<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("remember")]
        public bool Remember { get; set; } = default!;

        /// <summary>
        /// Whether previous memories and docs should be recalled or not<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Recall { get; set; }

        /// <summary>
        /// Whether this interaction should be stored in the session history or not<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Save { get; set; }

        /// <summary>
        /// Identifier of the model to be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Indicates if the server should stream the response as it's generated<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Stream { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Stop { get; set; }

        /// <summary>
        /// If specified, the system will make a best effort to sample deterministically for that particular seed value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public short? Seed { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the chat completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, float>? LogitBias { get; set; }

        /// <summary>
        /// Response format (set to `json_object` to restrict output to JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ChatSimpleCompletionResponseFormat, global::Julep.ChatSchemaCompletionResponseFormat>))]
        public global::Julep.AnyOf<global::Julep.ChatSimpleCompletionResponseFormat, global::Julep.ChatSchemaCompletionResponseFormat>? ResponseFormat { get; set; }

        /// <summary>
        /// Agent ID of the agent to use for this interaction. (Only applicable for multi-agent sessions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Guid? Agent { get; set; }

        /// <summary>
        /// Number between 0 and 2.0. 1.0 is neutral and values larger than that penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Number between 0 and 2.0. 1.0 is neutral and values larger than that penalize number of tokens generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length_penalty")]
        public float? LengthPenalty { get; set; }

        /// <summary>
        /// Minimum probability compared to leading token to be considered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public float? MinP { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Defaults to 1 An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or temperature but not both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether to automatically run tools and send the results back to the model (requires tools or agents with tools).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_run_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRunTools { get; set; }

        /// <summary>
        /// Whether to include tool requests and responses when recalling messages.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RecallTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatInput" /> class.
        /// </summary>
        /// <param name="recall">
        /// Whether previous memories and docs should be recalled or not<br/>
        /// Default Value: true
        /// </param>
        /// <param name="save">
        /// Whether this interaction should be stored in the session history or not<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stream">
        /// Indicates if the server should stream the response as it's generated<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="autoRunTools">
        /// Whether to automatically run tools and send the results back to the model (requires tools or agents with tools).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recallTools">
        /// Whether to include tool requests and responses when recalling messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="model">
        /// Identifier of the model to be used
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
        /// <param name="remember">
        /// DISABLED: Whether this interaction should form new memories or not (will be enabled in a future release)<br/>
        /// Default Value: false<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatChatInput(
            bool recall,
            bool save,
            bool stream,
            global::System.Collections.Generic.IList<string> stop,
            bool autoRunTools,
            bool recallTools,
            string? model,
            short? seed,
            int? maxTokens,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias,
            global::Julep.AnyOf<global::Julep.ChatSimpleCompletionResponseFormat, global::Julep.ChatSchemaCompletionResponseFormat>? responseFormat,
            global::System.Guid? agent,
            float? repetitionPenalty,
            float? lengthPenalty,
            float? minP,
            float? frequencyPenalty,
            float? presencePenalty,
            float? temperature,
            float? topP,
            object? metadata,
            bool remember = default!)
        {
            this.Remember = remember;
            this.Recall = recall;
            this.Save = save;
            this.Model = model;
            this.Stream = stream;
            this.Stop = stop ?? throw new global::System.ArgumentNullException(nameof(stop));
            this.Seed = seed;
            this.MaxTokens = maxTokens;
            this.LogitBias = logitBias;
            this.ResponseFormat = responseFormat;
            this.Agent = agent;
            this.RepetitionPenalty = repetitionPenalty;
            this.LengthPenalty = lengthPenalty;
            this.MinP = minP;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Metadata = metadata;
            this.AutoRunTools = autoRunTools;
            this.RecallTools = recallTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChatInput" /> class.
        /// </summary>
        public ChatChatInput()
        {
        }

    }
}