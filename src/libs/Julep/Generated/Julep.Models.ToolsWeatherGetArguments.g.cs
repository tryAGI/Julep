
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Weather
    /// </summary>
    public sealed partial class ToolsWeatherGetArguments
    {
        /// <summary>
        /// The location for which to fetch weather data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherGetArguments" /> class.
        /// </summary>
        /// <param name="location">
        /// The location for which to fetch weather data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsWeatherGetArguments(
            string location)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsWeatherGetArguments" /> class.
        /// </summary>
        public ToolsWeatherGetArguments()
        {
        }

    }
}