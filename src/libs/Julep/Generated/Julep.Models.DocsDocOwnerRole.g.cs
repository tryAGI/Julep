
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocsDocOwnerRole
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocsDocOwnerRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocsDocOwnerRole value)
        {
            return value switch
            {
                DocsDocOwnerRole.Agent => "agent",
                DocsDocOwnerRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocsDocOwnerRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DocsDocOwnerRole.Agent,
                "user" => DocsDocOwnerRole.User,
                _ => null,
            };
        }
    }
}