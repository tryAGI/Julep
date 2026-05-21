
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsChosenTextEditor20241022
    {
        /// <summary>
        /// The command to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsChosenTextEditor20241022CommandJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsChosenTextEditor20241022Command Command { get; set; }

        /// <summary>
        /// The path to the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The content of the file to be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_text")]
        public string? FileText { get; set; }

        /// <summary>
        /// The line to insert the new string after
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_line")]
        public int? InsertLine { get; set; }

        /// <summary>
        /// The new string to insert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_str")]
        public string? NewStr { get; set; }

        /// <summary>
        /// The string in the file to replace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_str")]
        public string? OldStr { get; set; }

        /// <summary>
        /// The line range to view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_range")]
        public global::System.Collections.Generic.IList<int>? ViewRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenTextEditor20241022" /> class.
        /// </summary>
        /// <param name="command">
        /// The command to run
        /// </param>
        /// <param name="path">
        /// The path to the file
        /// </param>
        /// <param name="fileText">
        /// The content of the file to be created
        /// </param>
        /// <param name="insertLine">
        /// The line to insert the new string after
        /// </param>
        /// <param name="newStr">
        /// The new string to insert
        /// </param>
        /// <param name="oldStr">
        /// The string in the file to replace
        /// </param>
        /// <param name="viewRange">
        /// The line range to view
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsChosenTextEditor20241022(
            global::Julep.ToolsChosenTextEditor20241022Command command,
            string path,
            string? fileText,
            int? insertLine,
            string? newStr,
            string? oldStr,
            global::System.Collections.Generic.IList<int>? viewRange)
        {
            this.Command = command;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.FileText = fileText;
            this.InsertLine = insertLine;
            this.NewStr = newStr;
            this.OldStr = oldStr;
            this.ViewRange = viewRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsChosenTextEditor20241022" /> class.
        /// </summary>
        public ToolsChosenTextEditor20241022()
        {
        }

    }
}