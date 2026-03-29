#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsCloudinaryEditIntegrationDefMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsCloudinaryEditIntegrationDefMethod>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsCloudinaryEditIntegrationDefMethod Read(
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
                        return global::Julep.ToolsCloudinaryEditIntegrationDefMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsCloudinaryEditIntegrationDefMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsCloudinaryEditIntegrationDefMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsCloudinaryEditIntegrationDefMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsCloudinaryEditIntegrationDefMethodExtensions.ToValueString(value));
        }
    }
}
