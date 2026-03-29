
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Ffmpeg CMD
    /// </summary>
    public sealed partial class ToolsFfmpegSearchArguments
    {
        /// <summary>
        /// The bash command string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cmd { get; set; }

        /// <summary>
        /// The base64 string of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFfmpegSearchArguments" /> class.
        /// </summary>
        /// <param name="cmd">
        /// The bash command string
        /// </param>
        /// <param name="file">
        /// The base64 string of the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsFfmpegSearchArguments(
            string cmd,
            global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? file)
        {
            this.Cmd = cmd ?? throw new global::System.ArgumentNullException(nameof(cmd));
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsFfmpegSearchArguments" /> class.
        /// </summary>
        public ToolsFfmpegSearchArguments()
        {
        }
    }
}