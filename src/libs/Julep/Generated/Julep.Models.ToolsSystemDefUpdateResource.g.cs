
#nullable enable

namespace Julep
{
    /// <summary>
    /// Resource is the name of the resource to use
    /// </summary>
    public enum ToolsSystemDefUpdateResource
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Doc,
        /// <summary>
        /// 
        /// </summary>
        Execution,
        /// <summary>
        /// 
        /// </summary>
        Job,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSystemDefUpdateResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefUpdateResource value)
        {
            return value switch
            {
                ToolsSystemDefUpdateResource.Agent => "agent",
                ToolsSystemDefUpdateResource.Doc => "doc",
                ToolsSystemDefUpdateResource.Execution => "execution",
                ToolsSystemDefUpdateResource.Job => "job",
                ToolsSystemDefUpdateResource.Session => "session",
                ToolsSystemDefUpdateResource.Task => "task",
                ToolsSystemDefUpdateResource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefUpdateResource? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ToolsSystemDefUpdateResource.Agent,
                "doc" => ToolsSystemDefUpdateResource.Doc,
                "execution" => ToolsSystemDefUpdateResource.Execution,
                "job" => ToolsSystemDefUpdateResource.Job,
                "session" => ToolsSystemDefUpdateResource.Session,
                "task" => ToolsSystemDefUpdateResource.Task,
                "user" => ToolsSystemDefUpdateResource.User,
                _ => null,
            };
        }
    }
}