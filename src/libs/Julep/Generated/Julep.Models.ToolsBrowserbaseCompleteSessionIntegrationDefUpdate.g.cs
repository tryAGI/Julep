
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase complete session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseCompleteSessionIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: complete_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: complete_session
        /// </param>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCompleteSessionIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseCompleteSessionIntegrationDefUpdate()
        {
        }

    }
}