
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonResourceDeletedResponse
    {
        /// <summary>
        /// ID of deleted resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// When this resource was deleted as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime DeletedAt { get; set; } = default!;

        /// <summary>
        /// IDs (if any) of jobs created as part of this request<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::System.Collections.Generic.IList<global::System.Guid> Jobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResourceDeletedResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of deleted resource
        /// </param>
        /// <param name="deletedAt">
        /// When this resource was deleted as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="jobs">
        /// IDs (if any) of jobs created as part of this request<br/>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonResourceDeletedResponse(
            global::System.Guid id,
            global::System.DateTime deletedAt = default!,
            global::System.Collections.Generic.IList<global::System.Guid> jobs = default!)
        {
            this.Id = id;
            this.DeletedAt = deletedAt;
            this.Jobs = jobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResourceDeletedResponse" /> class.
        /// </summary>
        public CommonResourceDeletedResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CommonResourceDeletedResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CommonResourceDeletedResponse FromId(global::System.Guid id)
        {
            return new CommonResourceDeletedResponse
            {
                Id = id,
            };
        }

    }
}