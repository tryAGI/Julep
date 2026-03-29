
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type (fixed to 'text')<br/>
    /// Default Value: text
    /// </summary>
    public enum EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type value)
        {
            return value switch
            {
                EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type.Text,
                _ => null,
            };
        }
    }
}