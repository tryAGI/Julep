
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionsTransitionTarget
    {
        /// <summary>
        /// For Unicode character safety<br/>
        /// See: https://unicode.org/reports/tr31/<br/>
        /// See: https://www.unicode.org/reports/tr39/#Identifier_Characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScopeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsTransitionTarget" /> class.
        /// </summary>
        /// <param name="workflow">
        /// For Unicode character safety<br/>
        /// See: https://unicode.org/reports/tr31/<br/>
        /// See: https://www.unicode.org/reports/tr39/#Identifier_Characters
        /// </param>
        /// <param name="step"></param>
        /// <param name="scopeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionsTransitionTarget(
            string workflow,
            int step,
            global::System.Guid scopeId)
        {
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.Step = step;
            this.ScopeId = scopeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionsTransitionTarget" /> class.
        /// </summary>
        public ExecutionsTransitionTarget()
        {
        }
    }
}