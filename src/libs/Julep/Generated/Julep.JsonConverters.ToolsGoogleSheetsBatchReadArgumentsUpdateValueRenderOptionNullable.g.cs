#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOptionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption?>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? Read(
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
                        return global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOptionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOptionExtensions.ToValueString(value.Value));
            }
        }
    }
}
