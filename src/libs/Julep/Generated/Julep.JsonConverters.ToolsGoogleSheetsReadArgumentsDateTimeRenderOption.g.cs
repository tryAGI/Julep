#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsGoogleSheetsReadArgumentsDateTimeRenderOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption Read(
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
                        return global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOptionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOptionExtensions.ToValueString(value));
        }
    }
}
