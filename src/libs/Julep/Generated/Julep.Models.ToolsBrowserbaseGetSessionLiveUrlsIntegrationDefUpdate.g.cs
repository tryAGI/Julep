
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase get session live urls integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: get_live_urls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: get_live_urls
        /// </param>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate()
        {
        }

    }
}