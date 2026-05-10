
#nullable enable

namespace Julep
{
    /// <summary>
    /// System definition
    /// </summary>
    public sealed partial class ToolsSystemDef
    {
        /// <summary>
        /// Resource is the name of the resource to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSystemDefResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsSystemDefResource Resource { get; set; }

        /// <summary>
        /// Operation is the name of the operation to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSystemDefOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsSystemDefOperation Operation { get; set; }

        /// <summary>
        /// Resource id (if applicable)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        /// Sub-resource type (if applicable)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subresource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsSystemDefSubresourceJsonConverter))]
        public global::Julep.ToolsSystemDefSubresource? Subresource { get; set; }

        /// <summary>
        /// The arguments to pre-apply to the system call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSystemDef" /> class.
        /// </summary>
        /// <param name="resource">
        /// Resource is the name of the resource to use
        /// </param>
        /// <param name="operation">
        /// Operation is the name of the operation to perform
        /// </param>
        /// <param name="resourceId">
        /// Resource id (if applicable)
        /// </param>
        /// <param name="subresource">
        /// Sub-resource type (if applicable)
        /// </param>
        /// <param name="arguments">
        /// The arguments to pre-apply to the system call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSystemDef(
            global::Julep.ToolsSystemDefResource resource,
            global::Julep.ToolsSystemDefOperation operation,
            global::System.Guid? resourceId,
            global::Julep.ToolsSystemDefSubresource? subresource,
            object? arguments)
        {
            this.Resource = resource;
            this.Operation = operation;
            this.ResourceId = resourceId;
            this.Subresource = subresource;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSystemDef" /> class.
        /// </summary>
        public ToolsSystemDef()
        {
        }

    }
}