
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase context provider
    /// </summary>
    public sealed partial class ToolsBrowserbaseContextIntegrationDefUpdate
    {
        /// <summary>
        /// The specific method of the integration to call<br/>
        /// Default Value: create_context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseContextIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseContextArgumentsUpdate? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseContextIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call<br/>
        /// Default Value: create_context
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseContextIntegrationDefUpdate(
            global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod? method,
            global::Julep.ToolsBrowserbaseContextArgumentsUpdate? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseContextIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBrowserbaseContextIntegrationDefUpdate()
        {
        }
    }
}