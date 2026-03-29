
#nullable enable

namespace Julep
{
    /// <summary>
    /// Operation is the name of the operation to perform
    /// </summary>
    public enum ToolsSystemDefOperation
    {
        /// <summary>
        /// 
        /// </summary>
        ChangeStatus,
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        CreateOrUpdate,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Embed,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        History,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsSystemDefOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefOperation value)
        {
            return value switch
            {
                ToolsSystemDefOperation.ChangeStatus => "change_status",
                ToolsSystemDefOperation.Chat => "chat",
                ToolsSystemDefOperation.Create => "create",
                ToolsSystemDefOperation.CreateOrUpdate => "create_or_update",
                ToolsSystemDefOperation.Delete => "delete",
                ToolsSystemDefOperation.Embed => "embed",
                ToolsSystemDefOperation.Get => "get",
                ToolsSystemDefOperation.History => "history",
                ToolsSystemDefOperation.List => "list",
                ToolsSystemDefOperation.Patch => "patch",
                ToolsSystemDefOperation.Search => "search",
                ToolsSystemDefOperation.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefOperation? ToEnum(string value)
        {
            return value switch
            {
                "change_status" => ToolsSystemDefOperation.ChangeStatus,
                "chat" => ToolsSystemDefOperation.Chat,
                "create" => ToolsSystemDefOperation.Create,
                "create_or_update" => ToolsSystemDefOperation.CreateOrUpdate,
                "delete" => ToolsSystemDefOperation.Delete,
                "embed" => ToolsSystemDefOperation.Embed,
                "get" => ToolsSystemDefOperation.Get,
                "history" => ToolsSystemDefOperation.History,
                "list" => ToolsSystemDefOperation.List,
                "patch" => ToolsSystemDefOperation.Patch,
                "search" => ToolsSystemDefOperation.Search,
                "update" => ToolsSystemDefOperation.Update,
                _ => null,
            };
        }
    }
}