
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for Email sending
    /// </summary>
    public sealed partial class ToolsEmailArgumentsUpdate
    {
        /// <summary>
        /// The email address to send the email to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The email address to send the email from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The body of the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailArgumentsUpdate" /> class.
        /// </summary>
        /// <param name="to">
        /// The email address to send the email to
        /// </param>
        /// <param name="from">
        /// The email address to send the email from
        /// </param>
        /// <param name="subject">
        /// The subject of the email
        /// </param>
        /// <param name="body">
        /// The body of the email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsEmailArgumentsUpdate(
            string? to,
            string? from,
            string? subject,
            string? body)
        {
            this.To = to;
            this.From = from;
            this.Subject = subject;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailArgumentsUpdate" /> class.
        /// </summary>
        public ToolsEmailArgumentsUpdate()
        {
        }

    }
}