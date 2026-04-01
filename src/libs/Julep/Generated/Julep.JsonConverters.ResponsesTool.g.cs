#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Julep.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Julep.ResponsesTool>
    {
        /// <inheritdoc />
        public override global::Julep.ResponsesTool Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("domains")) __score1++;
            if (__jsonProps.Contains("search_context_size")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("user_location")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("filters")) __score2++;
            if (__jsonProps.Contains("max_num_results")) __score2++;
            if (__jsonProps.Contains("ranking_options")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("vector_store_ids")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("display_height")) __score3++;
            if (__jsonProps.Contains("display_width")) __score3++;
            if (__jsonProps.Contains("environment")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Julep.ResponsesFunctionTool? function = default;
            global::Julep.ResponsesWebSearchTool? webSearch = default;
            global::Julep.ResponsesFileSearchTool? fileSearch = default;
            global::Julep.ResponsesComputerTool? computer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFunctionTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFunctionTool).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesWebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesWebSearchTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesWebSearchTool).Name}");
                        webSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFileSearchTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFileSearchTool).Name}");
                        fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesComputerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesComputerTool).Name}");
                        computer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && webSearch == null && fileSearch == null && computer == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFunctionTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFunctionTool).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesWebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesWebSearchTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesWebSearchTool).Name}");
                    webSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFileSearchTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFileSearchTool).Name}");
                    fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesComputerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesComputerTool).Name}");
                    computer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Julep.ResponsesTool(
                function,

                webSearch,

                fileSearch,

                computer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Julep.ResponsesTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesWebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesWebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesWebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
            else if (value.IsFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesFileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesFileSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesFileSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch!, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Julep.ResponsesComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Julep.ResponsesComputerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Julep.ResponsesComputerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer!, typeInfo);
            }
        }
    }
}