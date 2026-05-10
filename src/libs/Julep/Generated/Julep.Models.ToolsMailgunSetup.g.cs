
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Mailgun integration
    /// </summary>
    public sealed partial class ToolsMailgunSetup
    {
        /// <summary>
        /// The API key for the Mailgun integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunSetup" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key for the Mailgun integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMailgunSetup(
            string apiKey)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunSetup" /> class.
        /// </summary>
        public ToolsMailgunSetup()
        {
        }

    }
}