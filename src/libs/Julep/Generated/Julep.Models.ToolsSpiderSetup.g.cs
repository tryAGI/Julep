
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Spider integration
    /// </summary>
    public sealed partial class ToolsSpiderSetup
    {
        /// <summary>
        /// The API key for Spider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spider_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpiderApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderSetup" /> class.
        /// </summary>
        /// <param name="spiderApiKey">
        /// The API key for Spider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSpiderSetup(
            string spiderApiKey)
        {
            this.SpiderApiKey = spiderApiKey ?? throw new global::System.ArgumentNullException(nameof(spiderApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSpiderSetup" /> class.
        /// </summary>
        public ToolsSpiderSetup()
        {
        }

    }
}