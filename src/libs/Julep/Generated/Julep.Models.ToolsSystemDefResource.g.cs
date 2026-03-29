
#nullable enable

namespace Julep
{
    /// <summary>
    /// Resource is the name of the resource to use
    /// </summary>
    public enum ToolsSystemDefResource
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
    public static class ToolsSystemDefResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefResource value)
        {
            return value switch
            {
                ToolsSystemDefResource.Agent => "agent",
                ToolsSystemDefResource.Doc => "doc",
                ToolsSystemDefResource.Execution => "execution",
                ToolsSystemDefResource.Job => "job",
                ToolsSystemDefResource.Session => "session",
                ToolsSystemDefResource.Task => "task",
                ToolsSystemDefResource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefResource? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ToolsSystemDefResource.Agent,
                "doc" => ToolsSystemDefResource.Doc,
                "execution" => ToolsSystemDefResource.Execution,
                "job" => ToolsSystemDefResource.Job,
                "session" => ToolsSystemDefResource.Session,
                "task" => ToolsSystemDefResource.Task,
                "user" => ToolsSystemDefResource.User,
                _ => null,
            };
        }
    }
}