
#nullable enable

namespace Julep
{
    /// <summary>
    /// Base Cloudinary integration definition
    /// </summary>
    public sealed partial class ToolsBaseCloudinaryIntegrationDefUpdate
    {
        /// <summary>
        /// Default Value: cloudinary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseCloudinaryIntegrationDefUpdateProviderJsonConverter))]
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider? Provider { get; set; }

        /// <summary>
        /// Setup parameters for Cloudinary integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsCloudinarySetupUpdate? Setup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseCloudinaryIntegrationDefUpdateMethodJsonConverter))]
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseCloudinaryIntegrationDefUpdate" /> class.
        /// </summary>
        /// <param name="provider">
        /// Default Value: cloudinary
        /// </param>
        /// <param name="setup">
        /// Setup parameters for Cloudinary integration
        /// </param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBaseCloudinaryIntegrationDefUpdate(
            global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider? provider,
            global::Julep.ToolsCloudinarySetupUpdate? setup,
            global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod? method)
        {
            this.Provider = provider;
            this.Setup = setup;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseCloudinaryIntegrationDefUpdate" /> class.
        /// </summary>
        public ToolsBaseCloudinaryIntegrationDefUpdate()
        {
        }
    }
}