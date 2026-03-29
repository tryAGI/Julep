
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesWebSearchTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesWebSearchToolTypeJsonConverter))]
        public global::Julep.ResponsesWebSearchToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<string>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesWebSearchToolSearchContextSizeJsonConverter))]
        public global::Julep.ResponsesWebSearchToolSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::Julep.ResponsesWebSearchToolUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="domains"></param>
        /// <param name="searchContextSize"></param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchTool(
            global::Julep.ResponsesWebSearchToolType type,
            global::System.Collections.Generic.IList<string>? domains,
            global::Julep.ResponsesWebSearchToolSearchContextSize? searchContextSize,
            global::Julep.ResponsesWebSearchToolUserLocation? userLocation)
        {
            this.Type = type;
            this.Domains = domains;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        public ResponsesWebSearchTool()
        {
        }
    }
}