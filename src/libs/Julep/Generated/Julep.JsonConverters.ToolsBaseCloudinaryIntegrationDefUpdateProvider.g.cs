#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolsBaseCloudinaryIntegrationDefUpdateProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider>
    {
        /// <inheritdoc />
        public override global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider Read(
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
                        return global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProviderExtensions.ToValueString(value));
        }
    }
}
