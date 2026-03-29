
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase create session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseCreateSessionIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: create_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseCreateSessionArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// Default Value: create_session
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCreateSessionIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseCreateSessionArguments? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseCreateSessionIntegrationDefUpdate()
        {
        }
    }
}