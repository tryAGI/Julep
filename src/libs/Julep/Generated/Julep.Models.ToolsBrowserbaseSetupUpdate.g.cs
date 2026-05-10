
#nullable enable

namespace Julep
{
    /// <summary>
    /// The setup parameters for the browserbase integration
    /// </summary>
    public sealed partial class ToolsBrowserbaseSetupUpdate
    {
        /// <summary>
        /// API key for the browserbase integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The project ID. Can be found in Settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The API URL. Defaults to https://www.browserbase.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_url")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// The connect URL. Defaults to wss://connect.browserbase.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect_url")]
        public string? ConnectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseSetupUpdate" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// API key for the browserbase integration
        /// </param>
        /// <param name="projectId">
        /// The project ID. Can be found in Settings.
        /// </param>
        /// <param name="apiUrl">
        /// The API URL. Defaults to https://www.browserbase.com
        /// </param>
        /// <param name="connectUrl">
        /// The connect URL. Defaults to wss://connect.browserbase.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseSetupUpdate(
            string? apiKey,
            string? projectId,
            string? apiUrl,
            string? connectUrl)
        {
            this.ApiKey = apiKey;
            this.ProjectId = projectId;
            this.ApiUrl = apiUrl;
            this.ConnectUrl = connectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseSetupUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseSetupUpdate()
        {
        }

    }
}