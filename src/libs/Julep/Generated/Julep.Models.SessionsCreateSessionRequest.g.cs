
#nullable enable

namespace Julep
{
    /// <summary>
    /// Payload for creating a session
    /// </summary>
    public sealed partial class SessionsCreateSessionRequest
    {
        /// <summary>
        /// User ID of user associated with this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Guid? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Users { get; set; }

        /// <summary>
        /// Agent ID of agent associated with this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Guid? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Agents { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RenderTemplates { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRunTools { get; set; }

        /// <summary>
        /// Whether to forward tool calls to the model<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForwardToolCalls { get; set; }

        /// <summary>
        /// Recall options for the session<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall_options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>))]
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? RecallOptions { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionsCreateSessionRequest" /> class.
        /// </summary>
        /// <param name="renderTemplates">
        /// Render system and assistant message content as jinja templates<br/>
        /// Default Value: true
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
        /// <param name="user">
        /// User ID of user associated with this session
        /// </param>
        /// <param name="users"></param>
        /// <param name="agent">
        /// Agent ID of agent associated with this session
        /// </param>
        /// <param name="agents"></param>
        /// <param name="situation">
        /// Session situation<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemTemplate">
        /// A specific system prompt template that sets the background for this session
        /// </param>
        /// <param name="tokenBudget">
        /// Threshold value for the adaptive context functionality<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contextOverflow">
        /// Action to start on context window overflow<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="recallOptions">
        /// Recall options for the session<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsCreateSessionRequest(
            bool renderTemplates,
            bool autoRunTools,
            bool forwardToolCalls,
            global::System.Guid? user,
            global::System.Collections.Generic.IList<global::System.Guid>? users,
            global::System.Guid? agent,
            global::System.Collections.Generic.IList<global::System.Guid>? agents,
            string? situation,
            string? systemTemplate,
            int? tokenBudget,
            global::Julep.SessionsContextOverflowType? contextOverflow,
            global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? recallOptions,
            object? metadata)
        {
            this.User = user;
            this.Users = users;
            this.Agent = agent;
            this.Agents = agents;
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
        /// Initializes a new instance of the <see cref="SessionsCreateSessionRequest" /> class.
        /// </summary>
        public SessionsCreateSessionRequest()
        {
        }
    }
}