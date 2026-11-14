
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Julep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsAgent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsCreateAgentRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsCreateOrUpdateAgentRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsListModelsResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AgentsModelInfo>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsModelInfo? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsPatchAgentRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsUpdateAgentRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatBaseChatOutput? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatFinishReason? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatLogProbResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ToolsChosenFunctionCall, global::Julep.ToolsChosenComputer20241022, global::Julep.ToolsChosenTextEditor20241022, global::Julep.ToolsChosenBash20241022>>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ToolsChosenFunctionCall, global::Julep.ToolsChosenComputer20241022, global::Julep.ToolsChosenTextEditor20241022, global::Julep.ToolsChosenBash20241022>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenFunctionCall? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenComputer20241022? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenTextEditor20241022? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenBash20241022? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatBaseChatResponse? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatCompletionUsage? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.DocsDocReference>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsDocReference? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatBaseTokenLogProb? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInput? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public short? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, float>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ChatSimpleCompletionResponseFormat, global::Julep.ChatSchemaCompletionResponseFormat>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSimpleCompletionResponseFormat? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSchemaCompletionResponseFormat? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputData? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatInputDataMessage>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessage? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesChatMLRole? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant1? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant1Type? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant2? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant2ImageUrl? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesImageDetail? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant2Type? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3Type? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant1Item>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant1Item? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant1ItemType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2Item>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2Item? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2ItemType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2ItemSource? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ToolsCreateToolRequest>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCreateToolRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ChatChatInputDataToolChoice?, global::Julep.ToolsNamedToolChoice>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatInputDataToolChoice? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsNamedToolChoice? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunk? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDelta? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant1? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant1Type? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant2ImageUrl? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant2Type? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3Type? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1ItemType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2ItemType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2ItemSource? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatChunkChatResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatChatOutputChunk>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatTokenLogProb>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatTokenLogProb? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMessageChatResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ChatSingleChatOutput, global::Julep.ChatMultipleChatOutput>>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ChatSingleChatOutput, global::Julep.ChatMultipleChatOutput>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutput? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatMultipleChatOutputMessage>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessage? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant1? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant1Type? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant2? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant2ImageUrl? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant2Type? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3Type? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemType? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemSource? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatRenderResponse? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSchemaCompletionResponseFormatType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSimpleCompletionResponseFormatType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessage? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant1Type? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant2? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant2ImageUrl? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant2Type? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3Type? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant1ItemType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemSource? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ChatBaseTokenLogProb>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.CommonResourceDeletedResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsBulkDeleteDocsRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsCreateDocRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsDoc? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::System.Collections.Generic.IList<float>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsDocOwner? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsDocOwnerRole? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsSnippet? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsDocSearchResponse? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsEmbedQueryResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsHybridDocSearchRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public sbyte? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsMultipleEmbedQueryRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsSingleEmbedQueryRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsTextOnlyDocSearchRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsVectorDocSearchRequest? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntry? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant1? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant1Type? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2ImageUrl? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2Type? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3Type? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1Item>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1Item? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1ItemType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2Item>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2Item? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemSource? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemSourceType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTool? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsToolResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2ImageUrl? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2Type? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1Item>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1Item? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1ItemType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2Item>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2Item? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSource? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntrySource? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesEntry? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesHistory? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesEntry>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesRelation>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesRelation? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsCreateExecutionRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsExecution? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsExecutionStatus? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsResumeExecutionRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsResumeExecutionRequestStatus? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsStopExecutionRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsStopExecutionRequestStatus? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTaskTokenResumeExecutionRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTaskTokenResumeExecutionRequestStatus? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransition? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionTarget? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionEvent? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionEventType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestStatus? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestDiscriminator? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestDiscriminatorStatus? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.FilesCreateFileRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.FilesFile? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputText? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImage? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputFile? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.JobsJobState? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.JobsJobStatus? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsCreateOrUpdateProjectRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsCreateProjectRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsPatchProjectRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsProject? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsUpdateProjectRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesBaseTool? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClick? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClickType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClickButton? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerScreenshotImage? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerScreenshotImageType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerTool? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolEnvironment? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCall? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDoubleClick? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDrag? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesKeyPress? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMove? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScreenshot? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScroll? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWait? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallSafetyCheck? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallStatus? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutput? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutputType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMessageStatus? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutputResource? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCoordinate? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputItem? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesIncludable? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoning? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseText? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesResponseFormatText, global::Julep.ResponsesTextResponseFormatJsonSchema, global::Julep.ResponsesResponseFormatJsonObject>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatText? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTextResponseFormatJsonSchema? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatJsonObject? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnum? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnum2? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnumType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnumFunction? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesTool>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTool? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseTruncation? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDoubleClickType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDragType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesCoordinate>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesEasyInputMessage? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMessageRole? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesEasyInputMessageType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileCitation? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileCitationType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFilePath? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFilePathType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchTool? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolRankingOptions? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolRankingOptionsRanker? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCall? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallStatus? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesFileSearchToolCallResult>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallResult? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesVectorStoreFileAttributes? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionTool? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCall? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallStatus? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutput? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputStatus? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputResource? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputFileType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImageType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImageDetail? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesItem? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesItemReference? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessage? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessageType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessageResource? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputTextType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputMessage? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolCall? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesKeyPressType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMoveType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputItem? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItem? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputMessageType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesOutputText, global::Julep.ResponsesRefusal>>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesOutputText, global::Julep.ResponsesRefusal>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputText? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesRefusal? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputTextType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesFileCitation, global::Julep.ResponsesUrlCitation, global::Julep.ResponsesFilePath>>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesFileCitation, global::Julep.ResponsesUrlCitation, global::Julep.ResponsesFilePath>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesUrlCitation? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningEffort? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningGenerateSummary? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningContent? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningContentType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItemType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesReasoningContent>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItemStatus? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesRefusalType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseObject? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseStatus? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseError? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseIncompleteDetails? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseIncompleteDetailsReason? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesOutputItem>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseText? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesToolChoiceOptions?, global::Julep.ResponsesToolChoiceTypes, global::Julep.ResponsesToolChoiceFunction>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceOptions? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceTypes? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceFunction? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseTruncation? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsage? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatJsonObjectType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatTextType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsageInputTokensDetails? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsageOutputTokensDetails? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScreenshotType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScrollType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTextResponseFormatJsonSchemaType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchTool? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceFunctionType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceTypesType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTypeType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesUrlCitationType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, bool?, double?>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWaitType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchStatus? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolSearchContextSize? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolUserLocation? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolUserLocationType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolCallType? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsCreateSecretRequest? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsSecret? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsUpdateSecretRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsBaseDocSearch? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsBaseDocSearchUpdate? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsContextOverflowType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsCreateOrUpdateSessionRequest? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearch? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearch? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearch? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsCreateSessionRequest? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchMode? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchUpdate? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchUpdateMode? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentMultiUserSession? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSession? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentNoUserSession? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentSingleUserSession? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsPatchSessionRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearchUpdate, global::Julep.SessionsTextOnlyDocSearchUpdate, global::Julep.SessionsHybridDocSearchUpdate>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchUpdate? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchUpdate? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSessionDiscriminator? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSessionDiscriminatorKind? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentMultiUserSession? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentNoUserSession? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentSingleUserSession? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchMode? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchUpdateMode? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsUpdateSessionRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchMode? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchUpdateMode? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThen? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::Julep.TasksCaseThenCase?>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenCase? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStep? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStep? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStep? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStep? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStep? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStep? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStep? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStep? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStep? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStep? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStep? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenUpdateItem? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::Julep.TasksCaseThenUpdateItemCase?>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenUpdateItemCase? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItem? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequest? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStep? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStep? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStep? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStep? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItem2? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemKind? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemEnum? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemEnumKind? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItem? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemKind? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemEnum? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemEnumKind? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksTaskTool>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskTool? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepKind? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepEnum? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepEnumKind? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepKind? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, object>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepEnum? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepEnumKind? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachDo? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachDoUpdateItem? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepKind? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepEnum? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepEnumKind? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepUpdateItem? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepUpdateItemVariant1? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepKind? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepEnum? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepEnumKind? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepKind? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThen? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenKind? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenEnum? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenEnumKind? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElse? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseKind? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseEnum? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseEnumKind? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepEnum? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepEnumKind? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItem? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepUpdateItem? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepUpdateItem? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemThen? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemThenVariant1? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemElse? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemElseVariant1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemVariant1? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepKind? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepEnum? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepEnumKind? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepKind? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepEnum? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepEnumKind? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepUpdateItemVariant1? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestItem2? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestItemVariant1? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestMainItem? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestMainItemVariant1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepKind? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2Item>>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2Item>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2Item? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant1Type? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2ImageUrl? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2Type? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3Type? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepTools? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRef? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepToolChoice?, global::Julep.ToolsNamedToolChoice>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepToolChoice? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepEnum? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepEnumKind? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2Item? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2ImageUrl? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemTools? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefUpdateItem? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemToolChoice?, global::Julep.ToolsNamedToolChoice>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemToolChoice? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemVariant1? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepKind? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepEnum? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepEnumKind? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepKind? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepEnum? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepEnumKind? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepFor? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepKind? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepEnum? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepEnumKind? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepKind? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksCaseThen>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepEnum? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepEnumKind? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksCaseThenUpdateItem>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepUpdateItemVariant1? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTask? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItem2? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemKind? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemEnum? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemEnumKind? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItem? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemKind? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemEnum? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemEnumKind? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepKind? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<object, global::Julep.TasksToolCallStepArgumentsEnum3?>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepArgumentsEnum3? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepEnum? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepEnumKind? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRefById, global::Julep.TasksToolRefByName>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefById? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefByName? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItem2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemKind? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemEnum? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemEnumKind? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItem? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemKind? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemEnum? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemEnumKind? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputInfo? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepKind? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepEnum? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepEnumKind? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepKind? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<object, global::Julep.TasksYieldStepArgumentsEnum3?>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepArgumentsEnum3? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepEnum? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepEnumKind? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDef? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefProvider? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSetup? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSearchArguments? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDef? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefUpdate? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefUpdateProvider? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSetupUpdate? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSearchArgumentsUpdate? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdate? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDef? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefMethod? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRef>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSecretRef? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsParameterSchema? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefUpdate? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefUpdateMethod? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRefUpdate>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSecretRefUpdate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsParameterSchemaUpdate? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDef? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefProvider? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArguments? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefUpdate? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefUpdateProvider? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdate? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsSortBy? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsSortOrder? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdateSortBy? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdateSortOrder? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDef? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseSetup? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefMethod? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdate? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateProvider? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseSetupUpdate? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateMethod? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseChosenToolCall? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsToolType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFunctionCallOption? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDef? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefProvider? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinarySetup? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefMethod? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdate? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinarySetupUpdate? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefProvider? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefDiscriminator? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefDiscriminatorProvider? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateProvider? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateDiscriminator? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateDiscriminatorProvider? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022Def? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefType? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefUpdate? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefUpdateType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDef? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefProvider? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchSetup? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchArguments? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefUpdate? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefUpdateProvider? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchSetupUpdate? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchArgumentsUpdate? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArguments? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsStatus? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdate? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextArguments? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextArgumentsUpdate? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDef? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefMethod? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionArguments? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<bool?, global::System.Collections.Generic.IList<object>>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionArguments? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionArgumentsUpdate? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDef? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefMethod? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdateMethod? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionArguments? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionArgumentsUpdate? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDef? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArguments? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArgumentsUpdate? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsArguments? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsArgumentsStatus? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDef? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022Action? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenFunctionCallType? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenTextEditor20241022Command? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditArguments? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditArgumentsUpdate? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDef? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefMethod? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefUpdate? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefUpdateMethod? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadArguments? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadArgumentsUpdate? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDef? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefMethod? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefUpdateMethod? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022Def? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefUpdate? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefUpdateType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFunctionDef? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDef? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDef? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDef? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDef? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDef? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDef? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDef? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDef? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDef? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDef? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDef? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDef? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDef? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022Def? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefProvider? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefUpdate? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefUpdateProvider? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailArguments? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailArgumentsUpdate? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefProvider? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailSetup? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefUpdate? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefUpdateProvider? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailSetupUpdate? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefProvider? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegSearchArguments? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefUpdate? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefUpdateProvider? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegSearchArgumentsUpdate? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArguments? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsValueInputOption? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsInsertDataOption? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdate? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArguments? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsMajorDimension? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsValueRenderOption? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdate? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArguments? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ToolsGoogleSheetsValueRange>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsValueRange? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsValueInputOption? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdate? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsClearArguments? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsClearArgumentsUpdate? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefProvider? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefMethod? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsSetup? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArguments? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArguments? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdate? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateMethod? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsSetupUpdate? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdate? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdate? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateMajorDimension? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsValueRangeMajorDimension? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsValueInputOption? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsInsertDataOption? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseFetchArguments? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseFetchArgumentsUpdate? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefProvider? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseSetup? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefUpdate? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefUpdateProvider? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseSetupUpdate? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefProvider? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefMethod? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSetup? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSendEmailArguments? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdate? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdateProvider? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdateMethod? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSetupUpdate? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSendEmailArgumentsUpdate? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpCallToolArguments? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpCallToolArgumentsUpdate? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefProvider? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetup? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArguments, global::Julep.ToolsMcpListToolsArguments>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpListToolsArguments? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefUpdate? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefUpdateProvider? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupUpdate? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArgumentsUpdate, global::Julep.ToolsMcpListToolsArgumentsUpdate>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpListToolsArgumentsUpdate? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupTransport? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupUpdateTransport? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinition>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPropertyDefinition? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinitionUpdate>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPropertyDefinitionUpdate? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPatchToolRequest? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdate? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefUpdate? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefUpdate? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdate? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefUpdate? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdate? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefUpdate? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArguments? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsAction? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsUpdate? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsUpdateAction? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefProvider? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserSetup? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefMethod? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateProvider? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArguments? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsContentType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsUpdate? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsUpdateContentType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefProvider? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefMethod? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderSetup? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdateProvider? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdateMethod? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderSetupUpdate? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefResource? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefOperation? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefSubresource? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateResource? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateOperation? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateSubresource? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefType? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefUpdateType? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefProvider? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredSetup? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredPartitionArguments? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefUpdateProvider? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredSetupUpdate? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredPartitionArgumentsUpdate? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUpdateToolRequest? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherGetArguments? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherGetArgumentsUpdate? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefProvider? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherSetup? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefUpdateProvider? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherSetupUpdate? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefProvider? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaSearchArguments? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefUpdateProvider? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaSearchArgumentsUpdate? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersCreateOrUpdateUserRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersCreateUserRequest? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersPatchUserRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersUpdateUserRequest? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersUser? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsDocsSearchRouteSearchRequest? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EmbedRouteEmbedRequest? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.DocsSingleEmbedQueryRequest, global::Julep.DocsMultipleEmbedQueryRequest>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsSearchRouteSearchRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListSortBy? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListDirection? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListSortBy? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListDirection? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListSortBy? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListDirection? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListSortBy? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListDirection? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListSortBy? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListDirection? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListSortBy? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListDirection? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListSortBy? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListDirection? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListSortBy? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListDirection? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListSortBy? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListDirection? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListSortBy? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListDirection? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListSortBy? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListDirection? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListSortBy? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListDirection? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AgentsAgent>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.DocsDoc>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.CommonResourceDeletedResponse>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.SecretsSecret>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListResponse? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksTask>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListResponse? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ToolsTool>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionTransitionsRouteListResponseItem>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListResponseItem? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionsTransition>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ProjectsProject>? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListResponse? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.SessionsSession>? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListResponse? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionsExecution>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListResponse? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.UsersUser>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListResponse? Type937 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AgentsModelInfo>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ToolsChosenFunctionCall, global::Julep.ToolsChosenComputer20241022, global::Julep.ToolsChosenTextEditor20241022, global::Julep.ToolsChosenBash20241022>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.DocsDocReference>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatInputDataMessage>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant1Item>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatInputDataMessageContentVariant3ItemVariant3ContentVariant2Item>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ToolsCreateToolRequest>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant1Item>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatOutputChunkDeltaContentVariant3ItemVariant3ContentVariant2Item>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatChatOutputChunk>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatTokenLogProb>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ChatSingleChatOutput, global::Julep.ChatMultipleChatOutput>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatMultipleChatOutputMessage>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatMultipleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant1Item>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatSingleChatOutputMessageContentVariant3ItemVariant3ContentVariant2Item>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ChatBaseTokenLogProb>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::System.Collections.Generic.List<float>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1Item>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2Item>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1Item>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2Item>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesEntry>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.EntriesRelation>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesComputerToolCallSafetyCheck>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<global::Julep.ResponsesInputItem>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesInputItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesIncludable>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesTool>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesCoordinate>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesFileSearchToolCallResult>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ResponsesOutputText, global::Julep.ResponsesRefusal>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.ResponsesFileCitation, global::Julep.ResponsesUrlCitation, global::Julep.ResponsesFilePath>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesReasoningContent>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ResponsesOutputItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksTaskTool>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<global::Julep.TasksPromptStepPromptVariant2Item>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepPromptVariant2Item>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepTools?, global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksCaseThen>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksCaseThenUpdateItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<bool?, global::System.Collections.Generic.List<object>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ToolsGoogleSheetsValueRange>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.AgentsAgent>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.DocsDoc>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.CommonResourceDeletedResponse>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.SecretsSecret>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.TasksTask>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ToolsTool>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ExecutionTransitionsRouteListResponseItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ExecutionsTransition>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ProjectsProject>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.SessionsSession>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.ExecutionsExecution>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Julep.UsersUser>? ListType79 { get; set; }
    }
}