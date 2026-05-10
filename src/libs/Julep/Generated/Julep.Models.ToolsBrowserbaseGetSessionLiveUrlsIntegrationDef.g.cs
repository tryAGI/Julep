
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase get session live urls integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef
    {
        /// <summary>
        /// Default Value: get_live_urls
        /// </summary>
        /// <default>global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod.GetLiveUrls</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod Method { get; set; } = global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod.GetLiveUrls;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="method">
        /// Default Value: get_live_urls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef(
            global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArguments? arguments,
            global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod method = global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod.GetLiveUrls)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef()
        {
        }

    }
}