
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "weather"<br/>
    /// Default Value: weather
    /// </summary>
    public enum ToolsWeatherIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Weather,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsWeatherIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsWeatherIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsWeatherIntegrationDefProvider.Weather => "weather",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsWeatherIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "weather" => ToolsWeatherIntegrationDefProvider.Weather,
                _ => null,
            };
        }
    }
}