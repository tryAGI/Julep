#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesInputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ResponsesInputItem>
    {
        /// <inheritdoc />
        public override global::Julep.ResponsesInputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Julep.ResponsesEasyInputMessage? easyMessage = default;
            global::Julep.ResponsesItem? responsesItem = default;
            global::Julep.ResponsesItemReference? reference = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesEasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesEasyInputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesEasyInputMessage).Name}");
                        easyMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItem).Name}");
                        responsesItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItemReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItemReference> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItemReference).Name}");
                        reference = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (easyMessage == null && responsesItem == null && reference == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesEasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesEasyInputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesEasyInputMessage).Name}");
                    easyMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItem).Name}");
                    responsesItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItemReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItemReference> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItemReference).Name}");
                    reference = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Julep.ResponsesInputItem(
                easyMessage,

                responsesItem,

                reference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ResponsesInputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEasyMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesEasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesEasyInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesEasyInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyMessage!, typeInfo);
            }
            else if (value.IsResponsesItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesItem!, typeInfo);
            }
            else if (value.IsReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesItemReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesItemReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesItemReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference!.Value, typeInfo);
            }
        }
    }
}