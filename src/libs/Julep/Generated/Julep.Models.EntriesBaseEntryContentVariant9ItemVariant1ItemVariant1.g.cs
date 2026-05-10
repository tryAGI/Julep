
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1TypeJsonConverter))]
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type Type { get; set; } = global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// The type (fixed to 'text')<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1(
            string text,
            global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type type = global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1" /> class.
        /// </summary>
        public EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1 FromText(string text)
        {
            return new EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1
            {
                Text = text,
            };
        }

    }
}