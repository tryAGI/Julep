
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Cloudinary integration
    /// </summary>
    public sealed partial class ToolsCloudinarySetup
    {
        /// <summary>
        /// The API key for Cloudinary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudinary_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudinaryApiKey { get; set; }

        /// <summary>
        /// The API secret for Cloudinary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudinary_api_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudinaryApiSecret { get; set; }

        /// <summary>
        /// The Cloud name for Cloudinary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudinary_cloud_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudinaryCloudName { get; set; }

        /// <summary>
        /// Additional parameters for the Cloudinary API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinarySetup" /> class.
        /// </summary>
        /// <param name="cloudinaryApiKey">
        /// The API key for Cloudinary
        /// </param>
        /// <param name="cloudinaryApiSecret">
        /// The API secret for Cloudinary
        /// </param>
        /// <param name="cloudinaryCloudName">
        /// The Cloud name for Cloudinary
        /// </param>
        /// <param name="params">
        /// Additional parameters for the Cloudinary API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsCloudinarySetup(
            string cloudinaryApiKey,
            string cloudinaryApiSecret,
            string cloudinaryCloudName,
            object? @params)
        {
            this.CloudinaryApiKey = cloudinaryApiKey ?? throw new global::System.ArgumentNullException(nameof(cloudinaryApiKey));
            this.CloudinaryApiSecret = cloudinaryApiSecret ?? throw new global::System.ArgumentNullException(nameof(cloudinaryApiSecret));
            this.CloudinaryCloudName = cloudinaryCloudName ?? throw new global::System.ArgumentNullException(nameof(cloudinaryCloudName));
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCloudinarySetup" /> class.
        /// </summary>
        public ToolsCloudinarySetup()
        {
        }

    }
}