
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "weather"<br/>
    /// Default Value: weather
    /// </summary>
    public enum ToolsWeatherIntegrationDefUpdateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Weather,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsWeatherIntegrationDefUpdateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsWeatherIntegrationDefUpdateProvider value)
        {
            return value switch
            {
                ToolsWeatherIntegrationDefUpdateProvider.Weather => "weather",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsWeatherIntegrationDefUpdateProvider? ToEnum(string value)
        {
            return value switch
            {
                "weather" => ToolsWeatherIntegrationDefUpdateProvider.Weather,
                _ => null,
            };
        }
    }
}