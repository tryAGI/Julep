#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class SessionsVectorDocSearchUpdateModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.SessionsVectorDocSearchUpdateMode?>
    {
        /// <inheritdoc />
        public override global::Julep.SessionsVectorDocSearchUpdateMode? Read(
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
                        return global::Julep.SessionsVectorDocSearchUpdateModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.SessionsVectorDocSearchUpdateMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.SessionsVectorDocSearchUpdateMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.SessionsVectorDocSearchUpdateMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.SessionsVectorDocSearchUpdateModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
