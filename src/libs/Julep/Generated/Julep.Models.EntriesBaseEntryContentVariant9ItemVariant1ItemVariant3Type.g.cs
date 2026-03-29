
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: tool_result
    /// </summary>
    public enum EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type value)
        {
            return value switch
            {
                EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type.ToolResult,
                _ => null,
            };
        }
    }
}