
#nullable enable

namespace Julep
{
    /// <summary>
    /// The arguments for the remote browser
    /// </summary>
    public sealed partial class ToolsRemoteBrowserArguments
    {
        /// <summary>
        /// The connection URL for the remote browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect_url")]
        public string? ConnectUrl { get; set; }

        /// <summary>
        /// The action to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsRemoteBrowserArgumentsActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ToolsRemoteBrowserArgumentsAction Action { get; set; }

        /// <summary>
        /// The text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The coordinate to move the mouse to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        public global::System.Collections.Generic.IList<object>? Coordinate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserArguments" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to perform
        /// </param>
        /// <param name="connectUrl">
        /// The connection URL for the remote browser
        /// </param>
        /// <param name="text">
        /// The text
        /// </param>
        /// <param name="coordinate">
        /// The coordinate to move the mouse to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsRemoteBrowserArguments(
            global::Julep.ToolsRemoteBrowserArgumentsAction action,
            string? connectUrl,
            string? text,
            global::System.Collections.Generic.IList<object>? coordinate)
        {
            this.ConnectUrl = connectUrl;
            this.Action = action;
            this.Text = text;
            this.Coordinate = coordinate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsRemoteBrowserArguments" /> class.
        /// </summary>
        public ToolsRemoteBrowserArguments()
        {
        }

    }
}