
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type (fixed to 'image_url')<br/>
    /// Default Value: image_url
    /// </summary>
    public enum ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMultipleChatOutputMessageContentVariant3ItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type value)
        {
            return value switch
            {
                ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}