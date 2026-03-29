
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    public enum TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType value)
        {
            return value switch
            {
                TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "image" => TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType.Image,
                _ => null,
            };
        }
    }
}