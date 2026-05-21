
#nullable enable

namespace Julep
{
    /// <summary>
    /// Setup parameters for Email integration
    /// </summary>
    public sealed partial class ToolsEmailSetup
    {
        /// <summary>
        /// The host of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// The port of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// The username of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// The password of the email server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailSetup" /> class.
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
        public ToolsEmailSetup(
            string host,
            int port,
            string user,
            string password)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Port = port;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsEmailSetup" /> class.
        /// </summary>
        public ToolsEmailSetup()
        {
        }

    }
}