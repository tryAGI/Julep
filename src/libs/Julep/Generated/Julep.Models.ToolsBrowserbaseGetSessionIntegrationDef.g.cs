
#nullable enable

namespace Julep
{
    /// <summary>
    /// browserbase get session integration definition
    /// </summary>
    public sealed partial class ToolsBrowserbaseGetSessionIntegrationDef
    {
        /// <summary>
        /// Default Value: get_session
        /// </summary>
        /// <default>global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod.GetSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBrowserbaseGetSessionIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod Method { get; set; } = global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod.GetSession;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::Julep.ToolsBrowserbaseGetSessionArguments? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionIntegrationDef" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="method">
        /// Default Value: get_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseGetSessionIntegrationDef(
            global::Julep.ToolsBrowserbaseGetSessionArguments? arguments,
            global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod method = global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod.GetSession)
        {
            this.Method = method;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseGetSessionIntegrationDef" /> class.
        /// </summary>
        public ToolsBrowserbaseGetSessionIntegrationDef()
        {
        }
    }
}