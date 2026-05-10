
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Google Sheets integration
    /// </summary>
    public sealed partial class ToolsGoogleSheetsSetupUpdate
    {
        /// <summary>
        /// Whether to use Julep's built-in Google Sheets service account.<br/>
        /// If true, no credentials needed. If false, service_account_json is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_julep_service")]
        public bool? UseJulepService { get; set; }

        /// <summary>
        /// Base64 encoded service account JSON for authentication.<br/>
        /// Required when use_julep_service is false.<br/>
        /// Users can provide their own service account for better isolation and quota management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_json")]
        public string? ServiceAccountJson { get; set; }

        /// <summary>
        /// Default number of retry attempts for API calls<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_retry_count")]
        public byte? DefaultRetryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsSetupUpdate" /> class.
        /// </summary>
        /// <param name="useJulepService">
        /// Whether to use Julep's built-in Google Sheets service account.<br/>
        /// If true, no credentials needed. If false, service_account_json is required.
        /// </param>
        /// <param name="serviceAccountJson">
        /// Base64 encoded service account JSON for authentication.<br/>
        /// Required when use_julep_service is false.<br/>
        /// Users can provide their own service account for better isolation and quota management.
        /// </param>
        /// <param name="defaultRetryCount">
        /// Default number of retry attempts for API calls<br/>
        /// Default Value: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsSetupUpdate(
            bool? useJulepService,
            string? serviceAccountJson,
            byte? defaultRetryCount)
        {
            this.UseJulepService = useJulepService;
            this.ServiceAccountJson = serviceAccountJson;
            this.DefaultRetryCount = defaultRetryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsSetupUpdate" /> class.
        /// </summary>
        public ToolsGoogleSheetsSetupUpdate()
        {
        }

    }
}