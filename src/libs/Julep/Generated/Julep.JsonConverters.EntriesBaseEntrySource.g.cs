#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class EntriesBaseEntrySourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.EntriesBaseEntrySource>
    {
        /// <inheritdoc />
        public override global::Julep.EntriesBaseEntrySource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Julep.EntriesBaseEntrySourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.EntriesBaseEntrySource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.EntriesBaseEntrySource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.EntriesBaseEntrySource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.EntriesBaseEntrySourceExtensions.ToValueString(value));
        }
    }
}
