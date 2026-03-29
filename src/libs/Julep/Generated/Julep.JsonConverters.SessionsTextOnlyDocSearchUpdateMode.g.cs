#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class SessionsTextOnlyDocSearchUpdateModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.SessionsTextOnlyDocSearchUpdateMode>
    {
        /// <inheritdoc />
        public override global::Julep.SessionsTextOnlyDocSearchUpdateMode Read(
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
                        return global::Julep.SessionsTextOnlyDocSearchUpdateModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.SessionsTextOnlyDocSearchUpdateMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.SessionsTextOnlyDocSearchUpdateMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.SessionsTextOnlyDocSearchUpdateMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.SessionsTextOnlyDocSearchUpdateModeExtensions.ToValueString(value));
        }
    }
}
