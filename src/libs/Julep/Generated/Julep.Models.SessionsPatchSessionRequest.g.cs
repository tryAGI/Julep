
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for patching a session
    /// </summary>
    public sealed partial class SessionsPatchSessionRequest
    {
        /// <summary>
        /// Session situation<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situation")]
        public string? Situation { get; set; }

        /// <summary>
        /// A specific system prompt template that sets the background for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        public string? SystemTemplate { get; set; }

        /// <summary>
        /// Render system and assistant message content as jinja templates<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_templates")]
        public bool? RenderTemplates { get; set; }

        /// <summary>
        /// Threshold value for the adaptive context functionality<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_budget")]
        public int? TokenBudget { get; set; }

        /// <summary>
        /// Action to start on context window overflow<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_overflow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.SessionsContextOverflowTypeJsonConverter))]
        public global::Julep.SessionsContextOverflowType? ContextOverflow { get; set; }

        /// <summary>
        /// Whether to auto-run the tool and send the tool results to the model when available.<br/>
        /// (default: false for sessions, true for tasks)<br/>
        /// If a tool call is made, the tool's output will be sent back to the model as the model's input.<br/>
        /// If a tool call is not made, the model's output will be returned as is.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_run_tools")]
        public bool? AutoRunTools { get; set; }

        /// <summary>
        /// Whether to forward tool calls to the model<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_tool_calls")]
        public bool? ForwardToolCalls { get; set; }

        /// <summary>
        /// Recall options for the session<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall_options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.SessionsVectorDocSearchUpdate, global::Julep.SessionsTextOnlyDocSearchUpdate, global::Julep.SessionsHybridDocSearchUpdate>))]
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearchUpdate, global::Julep.SessionsTextOnlyDocSearchUpdate, global::Julep.SessionsHybridDocSearchUpdate>? RecallOptions { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionsPatchSessionRequest" /> class.
        /// </summary>
        /// <param name="situation">
        /// Session situation<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemTemplate">
        /// A specific system prompt template that sets the background for this session
        /// </param>
        /// <param name="renderTemplates">
        /// Render system and assistant message content as jinja templates<br/>
        /// Default Value: true
        /// </param>
        /// <param name="tokenBudget">
        /// Threshold value for the adaptive context functionality<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contextOverflow">
        /// Action to start on context window overflow<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoRunTools">
        /// Whether to auto-run the tool and send the tool results to the model when available.<br/>
        /// (default: false for sessions, true for tasks)<br/>
        /// If a tool call is made, the tool's output will be sent back to the model as the model's input.<br/>
        /// If a tool call is not made, the model's output will be returned as is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="forwardToolCalls">
        /// Whether to forward tool calls to the model<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recallOptions">
        /// Recall options for the session<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsPatchSessionRequest(
            string? situation,
            string? systemTemplate,
            bool? renderTemplates,
            int? tokenBudget,
            global::Julep.SessionsContextOverflowType? contextOverflow,
            bool? autoRunTools,
            bool? forwardToolCalls,
            global::Julep.AnyOf<global::Julep.SessionsVectorDocSearchUpdate, global::Julep.SessionsTextOnlyDocSearchUpdate, global::Julep.SessionsHybridDocSearchUpdate>? recallOptions,
            object? metadata)
        {
            this.Situation = situation;
            this.SystemTemplate = systemTemplate;
            this.RenderTemplates = renderTemplates;
            this.TokenBudget = tokenBudget;
            this.ContextOverflow = contextOverflow;
            this.AutoRunTools = autoRunTools;
            this.ForwardToolCalls = forwardToolCalls;
            this.RecallOptions = recallOptions;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsPatchSessionRequest" /> class.
        /// </summary>
        public SessionsPatchSessionRequest()
        {
        }
    }
}