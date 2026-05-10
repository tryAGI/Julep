
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsBrowserbaseCreateSessionArguments
    {
        /// <summary>
        /// The Project ID. Can be found in Settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The installed Extension ID. See Install Extension from GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// Browser settings<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserSettings")]
        public object? BrowserSettings { get; set; }

        /// <summary>
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's defaultTimeout.<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Set to true to keep the session alive even after disconnections. This is available on the Startup plan only.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepAlive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<object>>))]
        public global::Julep.AnyOf<bool?, global::System.Collections.Generic.IList<object>>? Proxies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionArguments" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in Settings.
        /// </param>
        /// <param name="extensionId">
        /// The installed Extension ID. See Install Extension from GitHub.
        /// </param>
        /// <param name="browserSettings">
        /// Browser settings<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="timeout">
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's defaultTimeout.<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="keepAlive">
        /// Set to true to keep the session alive even after disconnections. This is available on the Startup plan only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsBrowserbaseCreateSessionArguments(
            string? projectId,
            string? extensionId,
            object? browserSettings,
            int? timeout,
            bool? keepAlive,
            global::Julep.AnyOf<bool?, global::System.Collections.Generic.IList<object>>? proxies)
        {
            this.ProjectId = projectId;
            this.ExtensionId = extensionId;
            this.BrowserSettings = browserSettings;
            this.Timeout = timeout;
            this.KeepAlive = keepAlive;
            this.Proxies = proxies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsBrowserbaseCreateSessionArguments" /> class.
        /// </summary>
        public ToolsBrowserbaseCreateSessionArguments()
        {
        }

    }
}