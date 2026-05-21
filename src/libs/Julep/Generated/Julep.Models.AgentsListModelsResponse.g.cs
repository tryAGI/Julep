
#nullable enable

namespace Julep
{
    /// <summary>
    /// Response for the list models endpoint
    /// </summary>
    public sealed partial class AgentsListModelsResponse
    {
        /// <summary>
        /// List of available models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Julep.AgentsModelInfo> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsListModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// List of available models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsListModelsResponse(
            global::System.Collections.Generic.IList<global::Julep.AgentsModelInfo> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsListModelsResponse" /> class.
        /// </summary>
        public AgentsListModelsResponse()
        {
        }

    }
}