
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesScreenshot
    {
        /// <summary>
        /// Specifies the event type. For a screenshot action, this property is always set to `screenshot`.<br/>
        /// Default Value: screenshot
        /// </summary>
        /// <default>global::Julep.ResponsesScreenshotType.Screenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesScreenshotTypeJsonConverter))]
        public global::Julep.ResponsesScreenshotType Type { get; set; } = global::Julep.ResponsesScreenshotType.Screenshot;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesScreenshot" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a screenshot action, this property is always set to `screenshot`.<br/>
        /// Default Value: screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesScreenshot(
            global::Julep.ResponsesScreenshotType type = global::Julep.ResponsesScreenshotType.Screenshot)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesScreenshot" /> class.
        /// </summary>
        public ResponsesScreenshot()
        {
        }
    }
}