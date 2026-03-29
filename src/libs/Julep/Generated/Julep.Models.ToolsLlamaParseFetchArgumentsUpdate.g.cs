
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for LlamaParse integration
    /// </summary>
    public sealed partial class ToolsLlamaParseFetchArgumentsUpdate
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? File { get; set; }

        /// <summary>
        /// Optional upload parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// The input file is base64<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public bool? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseFetchArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="filename">
        /// File Name. If not provided, a random name will be generated.
        /// </param>
        /// <param name="file">
        /// The base64 string of the file, which can be a single string or a list of strings
        /// </param>
        /// <param name="params">
        /// Optional upload parameters
        /// </param>
        /// <param name="base64">
        /// The input file is base64<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsLlamaParseFetchArgumentsUpdate(
            string? filename,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? file,
            object? @params,
            bool? base64)
        {
            this.Filename = filename;
            this.File = file;
            this.Params = @params;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsLlamaParseFetchArgumentsUpdate" /> class.
        /// </summary>
        public ToolsLlamaParseFetchArgumentsUpdate()
        {
        }
    }
}