
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type (fixed to 'image_url')<br/>
    /// Default Value: image_url
    /// </summary>
    public enum TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type value)
        {
            return value switch
            {
                TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}