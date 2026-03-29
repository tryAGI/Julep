
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionsSessionDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        MultiAgentMultiUser,
        /// <summary>
        /// 
        /// </summary>
        MultiAgentNoUser,
        /// <summary>
        /// 
        /// </summary>
        MultiAgentSingleUser,
        /// <summary>
        /// 
        /// </summary>
        SingleAgentMultiUser,
        /// <summary>
        /// 
        /// </summary>
        SingleAgentNoUser,
        /// <summary>
        /// 
        /// </summary>
        SingleAgentSingleUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsSessionDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsSessionDiscriminatorKind value)
        {
            return value switch
            {
                SessionsSessionDiscriminatorKind.MultiAgentMultiUser => "multi_agent_multi_user",
                SessionsSessionDiscriminatorKind.MultiAgentNoUser => "multi_agent_no_user",
                SessionsSessionDiscriminatorKind.MultiAgentSingleUser => "multi_agent_single_user",
                SessionsSessionDiscriminatorKind.SingleAgentMultiUser => "single_agent_multi_user",
                SessionsSessionDiscriminatorKind.SingleAgentNoUser => "single_agent_no_user",
                SessionsSessionDiscriminatorKind.SingleAgentSingleUser => "single_agent_single_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsSessionDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "multi_agent_multi_user" => SessionsSessionDiscriminatorKind.MultiAgentMultiUser,
                "multi_agent_no_user" => SessionsSessionDiscriminatorKind.MultiAgentNoUser,
                "multi_agent_single_user" => SessionsSessionDiscriminatorKind.MultiAgentSingleUser,
                "single_agent_multi_user" => SessionsSessionDiscriminatorKind.SingleAgentMultiUser,
                "single_agent_no_user" => SessionsSessionDiscriminatorKind.SingleAgentNoUser,
                "single_agent_single_user" => SessionsSessionDiscriminatorKind.SingleAgentSingleUser,
                _ => null,
            };
        }
    }
}