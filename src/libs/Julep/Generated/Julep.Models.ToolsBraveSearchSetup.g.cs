
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition for Brave Search
    /// </summary>
    public sealed partial class ToolsBraveSearchSetup
    {
        /// <summary>
        /// The api key for Brave Search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brave_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BraveApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveSearchSetup" /> class.
        /// </summary>
        /// <param name="braveApiKey">
        /// The api key for Brave Search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBraveSearchSetup(
            string braveApiKey)
        {
            this.BraveApiKey = braveApiKey ?? throw new global::System.ArgumentNullException(nameof(braveApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBraveSearchSetup" /> class.
        /// </summary>
        public ToolsBraveSearchSetup()
        {
        }

    }
}