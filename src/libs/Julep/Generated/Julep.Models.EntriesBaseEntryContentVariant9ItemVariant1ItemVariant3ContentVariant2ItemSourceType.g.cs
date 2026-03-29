
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: base64
    /// </summary>
    public enum EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType value)
        {
            return value switch
            {
                EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType.Base64,
                _ => null,
            };
        }
    }
}