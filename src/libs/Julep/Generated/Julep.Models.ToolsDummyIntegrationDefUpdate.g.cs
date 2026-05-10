
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsDummyIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: dummy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsDummyIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsDummyIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsDummyIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// Default Value: dummy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsDummyIntegrationDefUpdate(
            global::Julep.ToolsDummyIntegrationDefUpdateProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsDummyIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsDummyIntegrationDefUpdate()
        {
        }

    }
}