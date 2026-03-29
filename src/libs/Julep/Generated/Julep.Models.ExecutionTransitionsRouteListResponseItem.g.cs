
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionTransitionsRouteListResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.ExecutionsTransition> Transitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionTransitionsRouteListResponseItem" /> class.
        /// </summary>
        /// <param name="transitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionTransitionsRouteListResponseItem(
            global::System.Collections.Generic.IList<global::Julep.ExecutionsTransition> transitions)
        {
            this.Transitions = transitions ?? throw new global::System.ArgumentNullException(nameof(transitions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionTransitionsRouteListResponseItem" /> class.
        /// </summary>
        public ExecutionTransitionsRouteListResponseItem()
        {
        }
    }
}