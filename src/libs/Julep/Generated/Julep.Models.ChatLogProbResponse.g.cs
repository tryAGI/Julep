
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatLogProbResponse
    {
        /// <summary>
        /// The log probabilities of the tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Julep.ChatTokenLogProb>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatLogProbResponse" /> class.
        /// </summary>
        /// <param name="content">
        /// The log probabilities of the tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatLogProbResponse(
            global::System.Collections.Generic.IList<global::Julep.ChatTokenLogProb>? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatLogProbResponse" /> class.
        /// </summary>
        public ChatLogProbResponse()
        {
        }

    }
}