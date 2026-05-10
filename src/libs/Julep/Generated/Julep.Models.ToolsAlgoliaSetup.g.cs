
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition for Algolia
    /// </summary>
    public sealed partial class ToolsAlgoliaSetup
    {
        /// <summary>
        /// The Algolia Application ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algolia_application_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AlgoliaApplicationId { get; set; }

        /// <summary>
        /// The Algolia API Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algolia_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AlgoliaApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSetup" /> class.
        /// </summary>
        /// <param name="algoliaApplicationId">
        /// The Algolia Application ID
        /// </param>
        /// <param name="algoliaApiKey">
        /// The Algolia API Key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsAlgoliaSetup(
            string algoliaApplicationId,
            string algoliaApiKey)
        {
            this.AlgoliaApplicationId = algoliaApplicationId ?? throw new global::System.ArgumentNullException(nameof(algoliaApplicationId));
            this.AlgoliaApiKey = algoliaApiKey ?? throw new global::System.ArgumentNullException(nameof(algoliaApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSetup" /> class.
        /// </summary>
        public ToolsAlgoliaSetup()
        {
        }

    }
}