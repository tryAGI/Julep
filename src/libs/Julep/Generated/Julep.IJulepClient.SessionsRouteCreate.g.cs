#nullable enable

namespace Julep
{
    public partial interface IJulepClient
    {
        /// <summary>
        /// Create a new session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Julep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.SessionsSession> SessionsRouteCreateAsync(

            global::Julep.SessionsCreateSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new session
        /// </summary>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Julep.SessionsSession> SessionsRouteCreateAsync(
            bool renderTemplates,
            bool autoRunTools,
            bool forwardToolCalls,
            global::System.Guid? user = default,
            global::System.Collections.Generic.IList<global::System.Guid>? users = default,
            global::System.Guid? agent = default,
            global::System.Collections.Generic.IList<global::System.Guid>? agents = default,
            string? situation = default,
            string? systemTemplate = default,
            int? tokenBudget = default,
            global::Julep.SessionsContextOverflowType? contextOverflow = default,
            global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? recallOptions = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}