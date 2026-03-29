#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSecretsRouteListSortByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.AgentSecretsRouteListSortBy>
    {
        /// <inheritdoc />
        public override global::Julep.AgentSecretsRouteListSortBy Read(
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
                        return global::Julep.AgentSecretsRouteListSortByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.AgentSecretsRouteListSortBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.AgentSecretsRouteListSortBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.AgentSecretsRouteListSortBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.AgentSecretsRouteListSortByExtensions.ToValueString(value));
        }
    }
}
