
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition for Algolia
    /// </summary>
    public sealed partial class ToolsAlgoliaSetupUpdate
    {
        /// <summary>
        /// The Algolia Application ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algolia_application_id")]
        public string? AlgoliaApplicationId { get; set; }

        /// <summary>
        /// The Algolia API Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algolia_api_key")]
        public string? AlgoliaApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSetupUpdate" /> class.
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
        public ToolsAlgoliaSetupUpdate(
            string? algoliaApplicationId,
            string? algoliaApiKey)
        {
            this.AlgoliaApplicationId = algoliaApplicationId;
            this.AlgoliaApiKey = algoliaApiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsAlgoliaSetupUpdate" /> class.
        /// </summary>
        public ToolsAlgoliaSetupUpdate()
        {
        }
    }
}