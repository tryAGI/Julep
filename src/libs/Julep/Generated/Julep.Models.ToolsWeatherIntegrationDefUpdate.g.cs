
#nullable enable

namespace Julep
{
    /// <summary>
    /// Weather integration definition
    /// </summary>
    public sealed partial class ToolsWeatherIntegrationDefUpdate
    {
        /// <summary>
        /// The provider must be "weather"<br/>
        /// Default Value: weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsWeatherIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsWeatherIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The setup parameters for Weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsWeatherSetupUpdate? Setup { get; set; }

        /// <summary>
        /// The arguments for Weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsWeatherGetArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider must be "weather"<br/>
        /// Default Value: weather
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="setup">
        /// The setup parameters for Weather
        /// </param>
        /// <param name="arguments">
        /// The arguments for Weather
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWeatherIntegrationDefUpdate(
            global::Julep.ToolsWeatherIntegrationDefUpdateProvider? provider,
            string? method,
            global::Julep.ToolsWeatherSetupUpdate? setup,
            global::Julep.ToolsWeatherGetArgumentsUpdate? arguments)
        {
            this.Provider = provider;
            this.Method = method;
            this.Setup = setup;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsWeatherIntegrationDefUpdate()
        {
        }

    }
}