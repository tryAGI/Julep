
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsDummyIntegrationDef
    {
        /// <summary>
        /// Default Value: dummy
        /// </summary>
        /// <default>global::Julep.ToolsDummyIntegrationDefProvider.Dummy</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsDummyIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsDummyIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsDummyIntegrationDefProvider.Dummy;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsDummyIntegrationDef" /> class.
        /// </summary>
        /// <param name="provider">
        /// Default Value: dummy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsDummyIntegrationDef(
            global::Julep.ToolsDummyIntegrationDefProvider provider = global::Julep.ToolsDummyIntegrationDefProvider.Dummy)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsDummyIntegrationDef" /> class.
        /// </summary>
        public ToolsDummyIntegrationDef()
        {
        }

    }
}