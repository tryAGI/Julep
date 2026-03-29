#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsGoogleSheetsReadArgumentsMajorDimensionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension?>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? Read(
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
                        return global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimensionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimensionExtensions.ToValueString(value.Value));
            }
        }
    }
}
