
#nullable enable

namespace Julep
{
    /// <summary>
    /// Arguments for mailgun.send_email method
    /// </summary>
    public sealed partial class ToolsMailgunSendEmailArguments
    {
        /// <summary>
        /// The email address to send the email to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// The email address to send the email from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// The body of the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Optional carbon copy recipients (comma-separated email addresses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public string? Cc { get; set; }

        /// <summary>
        /// Optional blind carbon copy recipients (comma-separated email addresses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public string? Bcc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunSendEmailArguments" /> class.
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
        /// <param name="cc">
        /// Optional carbon copy recipients (comma-separated email addresses)
        /// </param>
        /// <param name="bcc">
        /// Optional blind carbon copy recipients (comma-separated email addresses)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsMailgunSendEmailArguments(
            string to,
            string from,
            string subject,
            string body,
            string? cc,
            string? bcc)
        {
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Cc = cc;
            this.Bcc = bcc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsMailgunSendEmailArguments" /> class.
        /// </summary>
        public ToolsMailgunSendEmailArguments()
        {
        }

    }
}