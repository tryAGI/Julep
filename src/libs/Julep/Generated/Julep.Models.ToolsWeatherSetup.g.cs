
#nullable enable

namespace Julep
{
    /// <summary>
    /// Integration definition for Weather
    /// </summary>
    public sealed partial class ToolsWeatherSetup
    {
        /// <summary>
        /// The api key for OpenWeatherMap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openweathermap_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenweathermapApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherSetup" /> class.
        /// </summary>
        /// <param name="openweathermapApiKey">
        /// The api key for OpenWeatherMap
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWeatherSetup(
            string openweathermapApiKey)
        {
            this.OpenweathermapApiKey = openweathermapApiKey ?? throw new global::System.ArgumentNullException(nameof(openweathermapApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherSetup" /> class.
        /// </summary>
        public ToolsWeatherSetup()
        {
        }

    }
}