
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "kind",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsMultiAgentMultiUserSession), typeDiscriminator: "multi_agent_multi_user")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsMultiAgentNoUserSession), typeDiscriminator: "multi_agent_no_user")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsMultiAgentSingleUserSession), typeDiscriminator: "multi_agent_single_user")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsSingleAgentMultiUserSession), typeDiscriminator: "single_agent_multi_user")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsSingleAgentNoUserSession), typeDiscriminator: "single_agent_no_user")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::Julep.SessionsSingleAgentSingleUserSession), typeDiscriminator: "single_agent_single_user")]
    public partial class SessionsSession
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
        /// Summary (null at the beginning) - generated automatically after every interaction<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSession" /> class.
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
        /// <param name="situation">
        /// Session situation<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemTemplate">
        /// A specific system prompt template that sets the background for this session
        /// </param>
        /// <param name="summary">
        /// Summary (null at the beginning) - generated automatically after every interaction<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Included only in responses
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
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsSession(
            bool renderTemplates,
            bool autoRunTools,
            bool forwardToolCalls,
            string? situation,
            string? systemTemplate,
            string? summary,
            int? tokenBudget,
            global::Julep.SessionsContextOverflowType? contextOverflow,
            global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? recallOptions,
            object? metadata,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Situation = situation;
            this.SystemTemplate = systemTemplate;
            this.Summary = summary;
            this.RenderTemplates = renderTemplates;
            this.TokenBudget = tokenBudget;
            this.ContextOverflow = contextOverflow;
            this.AutoRunTools = autoRunTools;
            this.ForwardToolCalls = forwardToolCalls;
            this.RecallOptions = recallOptions;
            this.Id = id;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSession" /> class.
        /// </summary>
        public SessionsSession()
        {
        }

    }
}