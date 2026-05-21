
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Email integration
    /// </summary>
    public sealed partial class ToolsEmailSetupUpdate
    {
        /// <summary>
        /// The host of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// The port of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// The username of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The password of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailSetupUpdate" /> class.
        /// </summary>
        /// <param name="host">
        /// The host of the email server
        /// </param>
        /// <param name="port">
        /// The port of the email server
        /// </param>
        /// <param name="user">
        /// The username of the email server
        /// </param>
        /// <param name="password">
        /// The password of the email server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsEmailSetupUpdate(
            string? host,
            int? port,
            string? user,
            string? password)
        {
            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailSetupUpdate" /> class.
        /// </summary>
        public ToolsEmailSetupUpdate()
        {
        }

    }
}