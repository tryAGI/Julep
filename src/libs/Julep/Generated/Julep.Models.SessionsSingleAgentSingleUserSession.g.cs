
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsSingleAgentSingleUserSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSingleAgentSingleUserSession" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsSingleAgentSingleUserSession(
            global::System.Guid agent,
            global::System.Guid user)
        {
            this.Agent = agent;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSingleAgentSingleUserSession" /> class.
        /// </summary>
        public SessionsSingleAgentSingleUserSession()
        {
        }

    }
}