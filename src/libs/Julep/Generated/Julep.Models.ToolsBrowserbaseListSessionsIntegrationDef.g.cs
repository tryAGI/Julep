
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase list sessions integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseListSessionsIntegrationDef
    {
        /// <summary>
        /// The specific method of the integration to call<br/>
        /// Default Value: list_sessions
        /// </summary>
        /// <default>global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod.ListSessions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseListSessionsIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod Method { get; set; } = global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod.ListSessions;

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
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
        /// <param name="method">
        /// The specific method of the integration to call<br/>
        /// Default Value: list_sessions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseListSessionsIntegrationDef(
            global::Julep.ToolsBrowserbaseListSessionsArguments? arguments,
            global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod method = global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod.ListSessions)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseListSessionsIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseListSessionsIntegrationDef()
        {
        }

    }
}