#nullable enable

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponsesFileSearchToolRankingOptionsRankerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ResponsesFileSearchToolRankingOptionsRanker>
    {
        /// <inheritdoc />
        public override global::Julep.ResponsesFileSearchToolRankingOptionsRanker Read(
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
                        return global::Julep.ResponsesFileSearchToolRankingOptionsRankerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Julep.ResponsesFileSearchToolRankingOptionsRanker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Julep.ResponsesFileSearchToolRankingOptionsRanker);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ResponsesFileSearchToolRankingOptionsRanker value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Julep.ResponsesFileSearchToolRankingOptionsRankerExtensions.ToValueString(value));
        }
    }
}
