
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTokenLogProb
    {
        /// <summary>
        /// The log probabilities of the tokens<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<global::Julep.ChatBaseTokenLogProb> TopLogprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogProb" /> class.
        /// </summary>
        /// <param name="topLogprobs">
        /// The log probabilities of the tokens<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTokenLogProb(
            global::System.Collections.Generic.IList<global::Julep.ChatBaseTokenLogProb> topLogprobs = default!)
        {
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogProb" /> class.
        /// </summary>
        public ChatTokenLogProb()
        {
        }
    }
}