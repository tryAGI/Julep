
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase complete session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseCompleteSessionIntegrationDef
    {
        /// <summary>
        /// Default Value: complete_session
        /// </summary>
        /// <default>global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod.CompleteSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseCompleteSessionIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod Method { get; set; } = global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod.CompleteSession;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseCompleteSessionArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="method">
        /// Default Value: complete_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCompleteSessionIntegrationDef(
            global::Julep.ToolsBrowserbaseCompleteSessionArguments? arguments,
            global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod method = global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod.CompleteSession)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCompleteSessionIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseCompleteSessionIntegrationDef()
        {
        }

    }
}