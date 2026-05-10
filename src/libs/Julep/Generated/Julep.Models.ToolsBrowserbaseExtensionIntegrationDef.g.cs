
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase extension provider
    /// </summary>
    public sealed partial class ToolsBrowserbaseExtensionIntegrationDef
    {
        /// <summary>
        /// The specific method of the integration to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseExtensionIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefMethod? Method { get; set; }

        /// <summary>
        /// The arguments for the method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseExtensionArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseExtensionIntegrationDef" /> class.
        /// </summary>
        /// <param name="method">
        /// The specific method of the integration to call
        /// </param>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseExtensionIntegrationDef(
            global::Julep.ToolsBrowserbaseExtensionIntegrationDefMethod? method,
            global::Julep.ToolsBrowserbaseExtensionArguments? arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseExtensionIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseExtensionIntegrationDef()
        {
        }

    }
}