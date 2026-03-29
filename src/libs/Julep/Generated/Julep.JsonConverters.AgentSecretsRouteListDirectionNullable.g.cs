#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSecretsRouteListDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.AgentSecretsRouteListDirection?>
    {
        /// <inheritdoc />
        public override global::Julep.AgentSecretsRouteListDirection? Read(
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
                        return global::Julep.AgentSecretsRouteListDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.AgentSecretsRouteListDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.AgentSecretsRouteListDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.AgentSecretsRouteListDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Julep.AgentSecretsRouteListDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
