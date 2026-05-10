
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Unstructured partition integration
    /// </summary>
    public sealed partial class ToolsUnstructuredPartitionArguments
    {
        /// <summary>
        /// File Name. If not provided, a random name will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The base64 string of the file, which can be a single string or a list of strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string File { get; set; }

        /// <summary>
        /// Additional partition parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partition_params")]
        public object? PartitionParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredPartitionArguments" /> class.
        /// </summary>
        /// <param name="file">
        /// The base64 string of the file, which can be a single string or a list of strings
        /// </param>
        /// <param name="filename">
        /// File Name. If not provided, a random name will be generated.
        /// </param>
        /// <param name="partitionParams">
        /// Additional partition parameters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsUnstructuredPartitionArguments(
            string file,
            string? filename,
            object? partitionParams)
        {
            this.Filename = filename;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.PartitionParams = partitionParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUnstructuredPartitionArguments" /> class.
        /// </summary>
        public ToolsUnstructuredPartitionArguments()
        {
        }

    }
}