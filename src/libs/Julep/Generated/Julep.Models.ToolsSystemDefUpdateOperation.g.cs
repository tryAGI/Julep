
#nullable enable

namespace Julep
{
    /// <summary>
    /// Operation is the name of the operation to perform
    /// </summary>
    public enum ToolsSystemDefUpdateOperation
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
    public static class ToolsSystemDefUpdateOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsSystemDefUpdateOperation value)
        {
            return value switch
            {
                ToolsSystemDefUpdateOperation.ChangeStatus => "change_status",
                ToolsSystemDefUpdateOperation.Chat => "chat",
                ToolsSystemDefUpdateOperation.Create => "create",
                ToolsSystemDefUpdateOperation.CreateOrUpdate => "create_or_update",
                ToolsSystemDefUpdateOperation.Delete => "delete",
                ToolsSystemDefUpdateOperation.Embed => "embed",
                ToolsSystemDefUpdateOperation.Get => "get",
                ToolsSystemDefUpdateOperation.History => "history",
                ToolsSystemDefUpdateOperation.List => "list",
                ToolsSystemDefUpdateOperation.Patch => "patch",
                ToolsSystemDefUpdateOperation.Search => "search",
                ToolsSystemDefUpdateOperation.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsSystemDefUpdateOperation? ToEnum(string value)
        {
            return value switch
            {
                "change_status" => ToolsSystemDefUpdateOperation.ChangeStatus,
                "chat" => ToolsSystemDefUpdateOperation.Chat,
                "create" => ToolsSystemDefUpdateOperation.Create,
                "create_or_update" => ToolsSystemDefUpdateOperation.CreateOrUpdate,
                "delete" => ToolsSystemDefUpdateOperation.Delete,
                "embed" => ToolsSystemDefUpdateOperation.Embed,
                "get" => ToolsSystemDefUpdateOperation.Get,
                "history" => ToolsSystemDefUpdateOperation.History,
                "list" => ToolsSystemDefUpdateOperation.List,
                "patch" => ToolsSystemDefUpdateOperation.Patch,
                "search" => ToolsSystemDefUpdateOperation.Search,
                "update" => ToolsSystemDefUpdateOperation.Update,
                _ => null,
            };
        }
    }
}