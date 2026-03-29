#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsBaseCloudinaryIntegrationDefUpdateMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod Read(
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
                        return global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethodExtensions.ToValueString(value));
        }
    }
}
