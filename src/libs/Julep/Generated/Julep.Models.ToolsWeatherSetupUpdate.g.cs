
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition for Weather
    /// </summary>
    public sealed partial class ToolsWeatherSetupUpdate
    {
        /// <summary>
        /// The api key for OpenWeatherMap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openweathermap_api_key")]
        public string? OpenweathermapApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherSetupUpdate" /> class.
        /// </summary>
        /// <param name="openweathermapApiKey">
        /// The api key for OpenWeatherMap
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWeatherSetupUpdate(
            string? openweathermapApiKey)
        {
            this.OpenweathermapApiKey = openweathermapApiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherSetupUpdate" /> class.
        /// </summary>
        public ToolsWeatherSetupUpdate()
        {
        }

    }
}