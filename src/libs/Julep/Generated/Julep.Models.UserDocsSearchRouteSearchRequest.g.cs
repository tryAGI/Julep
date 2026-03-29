
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserDocsSearchRouteSearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.AnyOf<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest> Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocsSearchRouteSearchRequest" /> class.
        /// </summary>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserDocsSearchRouteSearchRequest(
            global::Julep.AnyOf<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest> body)
        {
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocsSearchRouteSearchRequest" /> class.
        /// </summary>
        public UserDocsSearchRouteSearchRequest()
        {
        }
    }
}