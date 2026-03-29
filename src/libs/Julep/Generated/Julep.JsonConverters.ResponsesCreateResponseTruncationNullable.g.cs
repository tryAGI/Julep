#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponsesCreateResponseTruncationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ResponsesCreateResponseTruncation?>
    {
        /// <inheritdoc />
        public override global::Julep.ResponsesCreateResponseTruncation? Read(
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
                        return global::Julep.ResponsesCreateResponseTruncationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ResponsesCreateResponseTruncation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ResponsesCreateResponseTruncation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ResponsesCreateResponseTruncation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ResponsesCreateResponseTruncationExtensions.ToValueString(value.Value));
            }
        }
    }
}
