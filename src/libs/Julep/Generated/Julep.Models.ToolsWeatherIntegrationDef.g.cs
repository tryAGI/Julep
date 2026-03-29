
#nullable enable

namespace Julep
{
    /// <summary>
    /// Weather integration definition
    /// </summary>
    public sealed partial class ToolsWeatherIntegrationDef
    {
        /// <summary>
        /// The provider must be "weather"<br/>
        /// Default Value: weather
        /// </summary>
        /// <default>global::Julep.ToolsWeatherIntegrationDefProvider.Weather</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsWeatherIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsWeatherIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsWeatherIntegrationDefProvider.Weather;

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsWeatherSetup? Setup { get; set; }

        /// <summary>
        /// The arguments for Weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsWeatherGetArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Weather
        /// </param>
        /// <param name="arguments">
        /// The arguments for Weather
        /// </param>
        /// <param name="provider">
        /// The provider must be "weather"<br/>
        /// Default Value: weather
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWeatherIntegrationDef(
            string? method,
            global::Julep.ToolsWeatherSetup? setup,
            global::Julep.ToolsWeatherGetArguments? arguments,
            global::Julep.ToolsWeatherIntegrationDefProvider provider = global::Julep.ToolsWeatherIntegrationDefProvider.Weather)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherIntegrationDef" /> class.
        /// </summary>
        public ToolsWeatherIntegrationDef()
        {
        }
    }
}