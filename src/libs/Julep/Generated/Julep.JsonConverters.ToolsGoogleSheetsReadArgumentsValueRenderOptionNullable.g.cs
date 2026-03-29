#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsGoogleSheetsReadArgumentsValueRenderOptionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption?>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? Read(
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
                        return global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOptionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOptionExtensions.ToValueString(value.Value));
            }
        }
    }
}
