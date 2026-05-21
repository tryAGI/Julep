
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocsDocOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.DocsDocOwnerRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.DocsDocOwnerRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocOwner" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocsDocOwner(
            global::System.Guid id,
            global::Julep.DocsDocOwnerRole role)
        {
            this.Id = id;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocsDocOwner" /> class.
        /// </summary>
        public DocsDocOwner()
        {
        }

    }
}