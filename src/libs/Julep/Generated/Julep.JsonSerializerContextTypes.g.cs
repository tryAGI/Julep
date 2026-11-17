
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
        public global::Julep.DocsMultipleEmbedQueryRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsSingleEmbedQueryRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsTextOnlyDocSearchRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DocsVectorDocSearchRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntry? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant1? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant1Type? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2ImageUrl? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant2Type? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3Type? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1Item>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1Item? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant1ItemType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2Item>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2Item? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemSource? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant1ItemVariant3ContentVariant2ItemSourceType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTool? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsToolResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant1Type? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2ImageUrl? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant2Type? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3Type? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1Item>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1Item? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant1ItemType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2Item>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2Item? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSource? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntryContentVariant9ItemVariant1ItemVariant3ContentVariant2ItemSourceType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesBaseEntrySource? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesEntry? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesHistory? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesEntry>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.EntriesRelation>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EntriesRelation? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsCreateExecutionRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsExecution? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsExecutionStatus? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsResumeExecutionRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsResumeExecutionRequestStatus? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsStopExecutionRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsStopExecutionRequestStatus? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTaskTokenResumeExecutionRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTaskTokenResumeExecutionRequestStatus? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransition? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionTarget? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionEvent? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsTransitionEventType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestStatus? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestDiscriminator? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionsUpdateExecutionRequestDiscriminatorStatus? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.FilesCreateFileRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.FilesFile? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputText? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImage? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputFile? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.JobsJobState? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.JobsJobStatus? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsCreateOrUpdateProjectRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsCreateProjectRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsPatchProjectRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsProject? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsUpdateProjectRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesBaseTool? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClick? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClickType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesClickButton? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerScreenshotImage? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerScreenshotImageType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerTool? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolEnvironment? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCall? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDoubleClick? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDrag? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesKeyPress? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMove? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScreenshot? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScroll? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWait? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesComputerToolCallSafetyCheck>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallSafetyCheck? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallStatus? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutput? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutputType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMessageStatus? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesComputerToolCallOutputResource? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCoordinate? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesInputItem>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputItem? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesIncludable>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesIncludable? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoning? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseText? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesResponseFormatText, global::Julep.ResponsesTextResponseFormatJsonSchema, global::Julep.ResponsesResponseFormatJsonObject>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatText? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTextResponseFormatJsonSchema? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatJsonObject? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesCreateResponseToolChoiceEnum?, global::Julep.ResponsesCreateResponseToolChoiceEnum2>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnum? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnum2? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnumType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseToolChoiceEnumFunction? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesTool>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTool? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesCreateResponseTruncation? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDoubleClickType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesDragType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesCoordinate>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesEasyInputMessage? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMessageRole? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesInputText, global::Julep.ResponsesInputImage, global::Julep.ResponsesInputFile>>>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesEasyInputMessageType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileCitation? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileCitationType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFilePath? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFilePathType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchTool? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolRankingOptions? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolRankingOptionsRanker? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCall? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallStatus? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesFileSearchToolCallResult>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFileSearchToolCallResult? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesVectorStoreFileAttributes? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionTool? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCall? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallStatus? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutput? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputStatus? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesFunctionToolCallOutputResource? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputFileType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImageType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputImageDetail? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesItem? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesItemReference? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessage? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessageType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputMessageResource? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesInputTextType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputMessage? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolCall? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesKeyPressType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesMoveType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputItem? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItem? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputMessageType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesOutputText, global::Julep.ResponsesRefusal>>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesOutputText, global::Julep.ResponsesRefusal>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputText? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesRefusal? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesOutputTextType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.ResponsesFileCitation, global::Julep.ResponsesUrlCitation, global::Julep.ResponsesFilePath>>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesFileCitation, global::Julep.ResponsesUrlCitation, global::Julep.ResponsesFilePath>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesUrlCitation? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningEffort? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningGenerateSummary? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningContent? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningContentType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItemType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesReasoningContent>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesReasoningItemStatus? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesRefusalType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseObject? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseStatus? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseError? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseIncompleteDetails? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseIncompleteDetailsReason? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ResponsesOutputItem>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseText? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ResponsesToolChoiceOptions?, global::Julep.ResponsesToolChoiceTypes, global::Julep.ResponsesToolChoiceFunction>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceOptions? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceTypes? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceFunction? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseTruncation? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsage? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatJsonObjectType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseFormatTextType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsageInputTokensDetails? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesResponseUsageOutputTokensDetails? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScreenshotType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesScrollType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTextResponseFormatJsonSchemaType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchTool? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceFunctionType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesToolChoiceTypesType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesTypeType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesUrlCitationType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, bool?, double?>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWaitType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchStatus? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolSearchContextSize? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolUserLocation? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolUserLocationType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ResponsesWebSearchToolCallType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsCreateSecretRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsSecret? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SecretsUpdateSecretRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsBaseDocSearch? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsBaseDocSearchUpdate? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsContextOverflowType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsCreateOrUpdateSessionRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearch, global::Julep.SessionsTextOnlyDocSearch, global::Julep.SessionsHybridDocSearch>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearch? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearch? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearch? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsCreateSessionRequest? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchMode? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchUpdate? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsHybridDocSearchUpdateMode? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentMultiUserSession? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSession? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentNoUserSession? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsMultiAgentSingleUserSession? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsPatchSessionRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.SessionsVectorDocSearchUpdate, global::Julep.SessionsTextOnlyDocSearchUpdate, global::Julep.SessionsHybridDocSearchUpdate>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchUpdate? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchUpdate? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSessionDiscriminator? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSessionDiscriminatorKind? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentMultiUserSession? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentNoUserSession? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsSingleAgentSingleUserSession? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchMode? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsTextOnlyDocSearchUpdateMode? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsUpdateSessionRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchMode? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsVectorDocSearchUpdateMode? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThen? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::Julep.TasksCaseThenCase?>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenCase? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStep? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStep? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStep? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStep? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStep? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStep? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStep? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStep? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStep? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStep? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStep? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenUpdateItem? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::Julep.TasksCaseThenUpdateItemCase?>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCaseThenUpdateItemCase? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItem? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStep? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStep? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStep? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStep? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItem2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemKind? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemEnum? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestItemEnumKind? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItem? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemKind? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemEnum? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksCreateTaskRequestMainItemEnumKind? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksTaskTool>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskTool? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepKind? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepEnum? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksErrorWorkflowStepEnumKind? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepKind? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, object>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepEnum? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksEvaluateStepEnumKind? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachDo? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachDoUpdateItem? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepKind? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepEnum? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepEnumKind? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepUpdateItem? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksForeachStepUpdateItemVariant1? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepKind? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepEnum? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksGetStepEnumKind? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepKind? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThen? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenKind? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenEnum? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepThenEnumKind? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseKind? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseEnum? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepElseEnumKind? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepEnum? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepEnumKind? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItem? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepUpdateItem? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepUpdateItem? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemThen? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemThenVariant1? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemElse? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemElseVariant1? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksIfElseWorkflowStepUpdateItemVariant1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepKind? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepEnum? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksLogStepEnumKind? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepKind? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksEvaluateStep, global::Julep.TasksToolCallStep, global::Julep.TasksPromptStep, global::Julep.TasksGetStep, global::Julep.TasksSetStep, global::Julep.TasksLogStep, global::Julep.TasksYieldStep>>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepEnum? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepEnumKind? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksParallelStepUpdateItemVariant1? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestItem2? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestItemVariant1? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestMainItem? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPatchTaskRequestMainItemVariant1? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepKind? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2Item>>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2Item>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2Item? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant1? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant1Type? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2ImageUrl? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant2Type? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3Type? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepTools? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRef, global::Julep.ToolsCreateToolRequest>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRef? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepToolChoice?, global::Julep.ToolsNamedToolChoice>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepToolChoice? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepEnum? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepEnumKind? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2Item>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2Item? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant1Type? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2ImageUrl? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant2Type? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3Type? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1Item? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant1ItemType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2Item? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSource? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemPromptVariant2ItemContentVariant3ItemVariant3ContentVariant2ItemSourceType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemTools?, global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemTools? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRefUpdateItem, global::Julep.ToolsCreateToolRequest>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefUpdateItem? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksPromptStepUpdateItemToolChoice?, global::Julep.ToolsNamedToolChoice>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemToolChoice? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksPromptStepUpdateItemVariant1? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepKind? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepEnum? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksReturnStepEnumKind? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepKind? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepEnum? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSetStepEnumKind? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepFor? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepKind? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepEnum? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSleepStepEnumKind? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepKind? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksCaseThen>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepEnum? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepEnumKind? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksCaseThenUpdateItem>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksSwitchStepUpdateItemVariant1? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTask? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItem2? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemKind? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemEnum? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskItemEnumKind? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItem? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemKind? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemEnum? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksTaskMainItemEnumKind? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepKind? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<object, global::Julep.TasksToolCallStepArgumentsEnum3?>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepArgumentsEnum3? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepEnum? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolCallStepEnumKind? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.TasksToolRefById, global::Julep.TasksToolRefByName>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefById? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksToolRefByName? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequest? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItem2? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemKind? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemEnum? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestItemEnumKind? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItem? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemKind? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemEnum? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksUpdateTaskRequestMainItemEnumKind? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputInfo? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepKind? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepEnum? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksWaitForInputStepEnumKind? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepKind? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<object, global::Julep.TasksYieldStepArgumentsEnum3?>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepArgumentsEnum3? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepEnum? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksYieldStepEnumKind? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDef? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefProvider? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSetup? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSearchArguments? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDef? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefUpdate? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaIntegrationDefUpdateProvider? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSetupUpdate? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsAlgoliaSearchArgumentsUpdate? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdate? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDef? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefMethod? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRef>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSecretRef? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsParameterSchema? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefUpdate? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsApiCallDefUpdateMethod? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsSecretRefUpdate>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSecretRefUpdate? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsParameterSchemaUpdate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDef? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefProvider? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArguments? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefUpdate? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivIntegrationDefUpdateProvider? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdate? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsSortBy? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsSortOrder? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdateSortBy? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsArxivSearchArgumentsUpdateSortOrder? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDef? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefProvider? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseSetup? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefMethod? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdate? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateProvider? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseSetupUpdate? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseBrowserbaseIntegrationDefUpdateMethod? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseChosenToolCall? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsToolType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFunctionCallOption? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDef? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefProvider? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinarySetup? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefMethod? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdate? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateProvider? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinarySetupUpdate? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseCloudinaryIntegrationDefUpdateMethod? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefProvider? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefDiscriminator? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefDiscriminatorProvider? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateProvider? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateDiscriminator? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBaseIntegrationDefUpdateDiscriminatorProvider? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022Def? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefUpdate? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBash20241022DefUpdateType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDef? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefProvider? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchSetup? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchArguments? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefUpdate? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveIntegrationDefUpdateProvider? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchSetupUpdate? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBraveSearchArgumentsUpdate? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArguments? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsStatus? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdate? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionArgumentsUpdateStatus? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDef? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefMethod? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdate? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCompleteSessionIntegrationDefUpdateMethod? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextArguments? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextArgumentsUpdate? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDef? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefMethod? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefUpdate? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseContextIntegrationDefUpdateMethod? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionArguments? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<bool?, global::System.Collections.Generic.IList<object>>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDef? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefMethod? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdate? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseCreateSessionIntegrationDefUpdateMethod? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionArguments? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionArgumentsUpdate? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDef? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefMethod? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdate? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseExtensionIntegrationDefUpdateMethod? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionArguments? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionArgumentsUpdate? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDef? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefMethod? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdate? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionIntegrationDefUpdateMethod? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArguments? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsArgumentsUpdate? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDef? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefMethod? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdate? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseGetSessionLiveUrlsIntegrationDefUpdateMethod? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsArguments? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsArgumentsStatus? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDef? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefMethod? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdate? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsBrowserbaseListSessionsIntegrationDefUpdateMethod? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022Action? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenFunctionCallType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsChosenTextEditor20241022Command? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditArguments? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditArgumentsUpdate? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDef? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefMethod? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefUpdate? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryEditIntegrationDefUpdateMethod? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadArguments? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadArgumentsUpdate? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDef? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefMethod? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefUpdate? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsCloudinaryUploadIntegrationDefUpdateMethod? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022Def? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefUpdate? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsComputer20241022DefUpdateType? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFunctionDef? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDef? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDef? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDef? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDef? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDef? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDef? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDef? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDef? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDef? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDef? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDef? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDef? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDef? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022Def? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefProvider? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefUpdate? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsDummyIntegrationDefUpdateProvider? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailArguments? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailArgumentsUpdate? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefProvider? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailSetup? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefUpdate? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailIntegrationDefUpdateProvider? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsEmailSetupUpdate? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefProvider? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegSearchArguments? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefUpdate? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegIntegrationDefUpdateProvider? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsFfmpegSearchArgumentsUpdate? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArguments? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsValueInputOption? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsInsertDataOption? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdate? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdateValueInputOption? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsAppendArgumentsUpdateInsertDataOption? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArguments? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsMajorDimension? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsValueRenderOption? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsDateTimeRenderOption? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdate? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateMajorDimension? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateValueRenderOption? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchReadArgumentsUpdateDateTimeRenderOption? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArguments? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ToolsGoogleSheetsValueRange>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsValueRange? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsValueInputOption? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdate? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsBatchWriteArgumentsUpdateValueInputOption? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsClearArguments? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsClearArgumentsUpdate? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefProvider? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefMethod? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsSetup? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArguments? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArguments? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdate? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateProvider? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsIntegrationDefUpdateMethod? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsSetupUpdate? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdate? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdate? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsMajorDimension? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsValueRenderOption? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsDateTimeRenderOption? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateMajorDimension? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateValueRenderOption? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsReadArgumentsUpdateDateTimeRenderOption? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsValueRangeMajorDimension? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsValueInputOption? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsInsertDataOption? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateValueInputOption? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsGoogleSheetsWriteArgumentsUpdateInsertDataOption? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseFetchArguments? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseFetchArgumentsUpdate? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefProvider? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseSetup? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefUpdate? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseIntegrationDefUpdateProvider? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsLlamaParseSetupUpdate? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefProvider? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefMethod? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSetup? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSendEmailArguments? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdate? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdateProvider? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunIntegrationDefUpdateMethod? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSetupUpdate? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMailgunSendEmailArgumentsUpdate? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpCallToolArguments? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpCallToolArgumentsUpdate? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefProvider? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetup? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArguments, global::Julep.ToolsMcpListToolsArguments>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpListToolsArguments? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefUpdate? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpIntegrationDefUpdateProvider? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupUpdate? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ToolsMcpCallToolArgumentsUpdate, global::Julep.ToolsMcpListToolsArgumentsUpdate>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpListToolsArgumentsUpdate? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupTransport? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsMcpSetupUpdateTransport? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinition>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPropertyDefinition? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Julep.ToolsPropertyDefinitionUpdate>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPropertyDefinitionUpdate? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsPatchToolRequest? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdate? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefUpdate? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefUpdate? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdate? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefUpdate? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdate? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefUpdate? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArguments? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsAction? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsUpdate? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserArgumentsUpdateAction? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefProvider? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserSetup? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefMethod? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateProvider? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsRemoteBrowserIntegrationDefUpdateMethod? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArguments? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsContentType? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsUpdate? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderFetchArgumentsUpdateContentType? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefProvider? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefMethod? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderSetup? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdateProvider? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderIntegrationDefUpdateMethod? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSpiderSetupUpdate? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefResource? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefOperation? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefSubresource? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateResource? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateOperation? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsSystemDefUpdateSubresource? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefType? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsTextEditor20241022DefUpdateType? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefProvider? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredSetup? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredPartitionArguments? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredIntegrationDefUpdateProvider? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredSetupUpdate? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUnstructuredPartitionArgumentsUpdate? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsUpdateToolRequest? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherGetArguments? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherGetArgumentsUpdate? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefProvider? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherSetup? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherIntegrationDefUpdateProvider? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWeatherSetupUpdate? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefProvider? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaSearchArguments? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaIntegrationDefUpdateProvider? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ToolsWikipediaSearchArgumentsUpdate? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersCreateOrUpdateUserRequest? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersCreateUserRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersPatchUserRequest? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersUpdateUserRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersUser? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsDocsSearchRouteSearchRequest? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.DocsVectorDocSearchRequest, global::Julep.DocsTextOnlyDocSearchRequest, global::Julep.DocsHybridDocSearchRequest>? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.EmbedRouteEmbedRequest? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.DocsSingleEmbedQueryRequest, global::Julep.DocsMultipleEmbedQueryRequest>? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsSearchRouteSearchRequest? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListSortBy? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListDirection? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListSortBy? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListDirection? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListSortBy? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListDirection? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListSortBy? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListDirection? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListSortBy? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListDirection? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListSortBy? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListDirection? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListSortBy? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListDirection? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListSortBy? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListDirection? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListSortBy? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListDirection? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListSortBy? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListDirection? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListSortBy? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListDirection? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListSortBy? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListDirection? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentsRouteListResponse? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.AgentsAgent>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentDocsRouteListResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.DocsDoc>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.CommonResourceDeletedResponse>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentSecretsRouteListResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.SecretsSecret>? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TasksRouteListResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.TasksTask>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AgentToolsRouteListResponse? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ToolsTool>? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListResponse? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionTransitionsRouteListResponseItem>? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ExecutionTransitionsRouteListResponseItem? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionsTransition>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.ProjectsRouteListResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ProjectsProject>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.DeveloperSecretsRouteListResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.SessionsRouteListResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.SessionsSession>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.AnyOf<global::Julep.ChatChunkChatResponse, global::Julep.ChatMessageChatResponse>? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.TaskExecutionsRouteListResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.ExecutionsExecution>? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UsersRouteListResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Julep.UsersUser>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Julep.UserDocsRouteListResponse? Type936 { get; set; }

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