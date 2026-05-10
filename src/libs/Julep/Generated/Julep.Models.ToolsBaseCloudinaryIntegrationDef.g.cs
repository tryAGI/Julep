
#nullable enable

namespace Julep
{
    /// <summary>
    /// Base Cloudinary integration definition
    /// </summary>
    public sealed partial class ToolsBaseCloudinaryIntegrationDef
    {
        /// <summary>
        /// Default Value: cloudinary
        /// </summary>
        /// <default>global::Julep.ToolsBaseCloudinaryIntegrationDefProvider.Cloudinary</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseCloudinaryIntegrationDefProviderJsonConverter))]
        public global::Julep.ToolsBaseCloudinaryIntegrationDefProvider Provider { get; set; } = global::Julep.ToolsBaseCloudinaryIntegrationDefProvider.Cloudinary;

        /// <summary>
        /// Setup parameters for Cloudinary integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Julep.ToolsCloudinarySetup? Setup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsBaseCloudinaryIntegrationDefMethodJsonConverter))]
        public global::Julep.ToolsBaseCloudinaryIntegrationDefMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseCloudinaryIntegrationDef" /> class.
        /// </summary>
        /// <param name="setup">
        /// Setup parameters for Cloudinary integration
        /// </param>
        /// <param name="method"></param>
        /// <param name="provider">
        /// Default Value: cloudinary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBaseCloudinaryIntegrationDef(
            global::Julep.ToolsCloudinarySetup? setup,
            global::Julep.ToolsBaseCloudinaryIntegrationDefMethod? method,
            global::Julep.ToolsBaseCloudinaryIntegrationDefProvider provider = global::Julep.ToolsBaseCloudinaryIntegrationDefProvider.Cloudinary)
        {
            this.Provider = provider;
            this.Setup = setup;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBaseCloudinaryIntegrationDef" /> class.
        /// </summary>
        public ToolsBaseCloudinaryIntegrationDef()
        {
        }

    }
}