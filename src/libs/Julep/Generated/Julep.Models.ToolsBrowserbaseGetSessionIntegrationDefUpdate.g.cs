
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase get session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseGetSessionIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: get_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseGetSessionIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseGetSessionArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: get_session
        /// </param>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseGetSessionIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseGetSessionArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseGetSessionIntegrationDefUpdate()
        {
        }

    }
}