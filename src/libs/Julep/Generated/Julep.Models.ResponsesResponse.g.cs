
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesResponseObjectJsonConverter))]
        public global::Julep.ResponsesResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Julep.ResponsesResponseError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        public global::Julep.ResponsesResponseIncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ResponsesOutputItem> Output { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ParallelToolCalls { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Julep.ResponsesResponseText? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.ResponsesToolChoiceOptions?, global::Julep.ResponsesToolChoiceTypes, global::Julep.ResponsesToolChoiceFunction>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.ResponsesToolChoiceOptions?, global::Julep.ResponsesToolChoiceTypes, global::Julep.ResponsesToolChoiceFunction> ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ResponsesTool> Tools { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesResponseTruncationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesResponseTruncation Truncation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesResponseUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="status"></param>
        /// <param name="model"></param>
        /// <param name="output"></param>
        /// <param name="parallelToolCalls">
        /// Default Value: true
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="truncation"></param>
        /// <param name="usage"></param>
        /// <param name="metadata"></param>
        /// <param name="object"></param>
        /// <param name="error"></param>
        /// <param name="incompleteDetails"></param>
        /// <param name="instructions"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="reasoning">
        /// Reasoning configuration options for o-series models.
        /// </param>
        /// <param name="store">
        /// Default Value: true
        /// </param>
        /// <param name="text"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponse(
            string id,
            int createdAt,
            global::Julep.ResponsesResponseStatus status,
            string model,
            global::System.Collections.Generic.IList<global::Julep.ResponsesOutputItem> output,
            bool parallelToolCalls,
            double temperature,
            global::Julep.AnyOf<global::Julep.ResponsesToolChoiceOptions?, global::Julep.ResponsesToolChoiceTypes, global::Julep.ResponsesToolChoiceFunction> toolChoice,
            global::System.Collections.Generic.IList<global::Julep.ResponsesTool> tools,
            double topP,
            global::Julep.ResponsesResponseTruncation truncation,
            global::Julep.ResponsesResponseUsage usage,
            object metadata,
            global::Julep.ResponsesResponseObject @object,
            global::Julep.ResponsesResponseError? error,
            global::Julep.ResponsesResponseIncompleteDetails? incompleteDetails,
            string? instructions,
            int? maxOutputTokens,
            string? previousResponseId,
            global::Julep.ResponsesReasoning? reasoning,
            bool? store,
            global::Julep.ResponsesResponseText? text,
            string? user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Error = error;
            this.IncompleteDetails = incompleteDetails;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.ParallelToolCalls = parallelToolCalls;
            this.PreviousResponseId = previousResponseId;
            this.Reasoning = reasoning;
            this.Store = store;
            this.Temperature = temperature;
            this.Text = text;
            this.ToolChoice = toolChoice;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.TopP = topP;
            this.Truncation = truncation;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.User = user;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponse" /> class.
        /// </summary>
        public ResponsesResponse()
        {
        }

    }
}