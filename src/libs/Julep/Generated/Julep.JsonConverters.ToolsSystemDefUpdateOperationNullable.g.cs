#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsSystemDefUpdateOperationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsSystemDefUpdateOperation?>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsSystemDefUpdateOperation? Read(
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
                        return global::Julep.ToolsSystemDefUpdateOperationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsSystemDefUpdateOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsSystemDefUpdateOperation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsSystemDefUpdateOperation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ToolsSystemDefUpdateOperationExtensions.ToValueString(value.Value));
            }
        }
    }
}
