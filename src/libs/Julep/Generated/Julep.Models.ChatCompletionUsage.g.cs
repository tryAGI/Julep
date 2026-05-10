
#nullable enable

namespace Julep
{
    /// <summary>
    /// Usage statistics for the completion request
    /// </summary>
    public sealed partial class ChatCompletionUsage
    {
        /// <summary>
        /// Number of tokens in the generated completion<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion<br/>
        /// Included only in responses
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (prompt + completion)<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUsage(
            int? completionTokens,
            int? promptTokens,
            int? totalTokens)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        public ChatCompletionUsage()
        {
        }

    }
}