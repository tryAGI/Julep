
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase create session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseCreateSessionIntegrationDef
    {
        /// <summary>
        /// Default Value: create_session
        /// </summary>
        /// <default>global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod.CreateSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseCreateSessionIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod Method { get; set; } = global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod.CreateSession;

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
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments for the method
        /// </param>
        /// <param name="method">
        /// Default Value: create_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCreateSessionIntegrationDef(
            global::Julep.ToolsBrowserbaseCreateSessionArguments? arguments,
            global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod method = global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod.CreateSession)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseCreateSessionIntegrationDef()
        {
        }
    }
}