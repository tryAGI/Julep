
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase list sessions integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseListSessionsIntegrationDefUpdate
    {
        /// <summary>
        /// The specific method of the integration to call<br/>
        /// Default Value: list_sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseListSessionsArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call<br/>
        /// Default Value: list_sessions
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseListSessionsIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseListSessionsArguments? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseListSessionsIntegrationDefUpdate()
        {
        }
    }
}