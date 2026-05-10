#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesOutputItem : global::System.IEquatable<ResponsesOutputItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesOutputMessage? Message { get; init; }
#else
        public global::Julep.ResponsesOutputMessage? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesOutputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesFileSearchToolCall? FileSearchToolCall { get; init; }
#else
        public global::Julep.ResponsesFileSearchToolCall? FileSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchToolCall))]
#endif
        public bool IsFileSearchToolCall => FileSearchToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearchToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesFileSearchToolCall? value)
        {
            value = FileSearchToolCall;
            return IsFileSearchToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesFunctionToolCall? FunctionToolCall { get; init; }
#else
        public global::Julep.ResponsesFunctionToolCall? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesFunctionToolCall? value)
        {
            value = FunctionToolCall;
            return IsFunctionToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesWebSearchToolCall? WebSearchToolCall { get; init; }
#else
        public global::Julep.ResponsesWebSearchToolCall? WebSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolCall))]
#endif
        public bool IsWebSearchToolCall => WebSearchToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearchToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesWebSearchToolCall? value)
        {
            value = WebSearchToolCall;
            return IsWebSearchToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesComputerToolCall? ComputerToolCall { get; init; }
#else
        public global::Julep.ResponsesComputerToolCall? ComputerToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCall))]
#endif
        public bool IsComputerToolCall => ComputerToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesComputerToolCall? value)
        {
            value = ComputerToolCall;
            return IsComputerToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesReasoningItem? Reasoning { get; init; }
#else
        public global::Julep.ResponsesReasoningItem? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesOutputMessage value) => new ResponsesOutputItem((global::Julep.ResponsesOutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesOutputMessage?(ResponsesOutputItem @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesOutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromMessage(global::Julep.ResponsesOutputMessage? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesFileSearchToolCall value) => new ResponsesOutputItem((global::Julep.ResponsesFileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFileSearchToolCall?(ResponsesOutputItem @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesFileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromFileSearchToolCall(global::Julep.ResponsesFileSearchToolCall? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesFunctionToolCall value) => new ResponsesOutputItem((global::Julep.ResponsesFunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFunctionToolCall?(ResponsesOutputItem @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesFunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromFunctionToolCall(global::Julep.ResponsesFunctionToolCall? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesWebSearchToolCall value) => new ResponsesOutputItem((global::Julep.ResponsesWebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesWebSearchToolCall?(ResponsesOutputItem @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesWebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromWebSearchToolCall(global::Julep.ResponsesWebSearchToolCall? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesComputerToolCall value) => new ResponsesOutputItem((global::Julep.ResponsesComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesComputerToolCall?(ResponsesOutputItem @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromComputerToolCall(global::Julep.ResponsesComputerToolCall? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesOutputItem(global::Julep.ResponsesReasoningItem value) => new ResponsesOutputItem((global::Julep.ResponsesReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesReasoningItem?(ResponsesOutputItem @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(global::Julep.ResponsesReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesOutputItem FromReasoning(global::Julep.ResponsesReasoningItem? value) => new ResponsesOutputItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesOutputItem(
            global::Julep.ResponsesOutputMessage? message,
            global::Julep.ResponsesFileSearchToolCall? fileSearchToolCall,
            global::Julep.ResponsesFunctionToolCall? functionToolCall,
            global::Julep.ResponsesWebSearchToolCall? webSearchToolCall,
            global::Julep.ResponsesComputerToolCall? computerToolCall,
            global::Julep.ResponsesReasoningItem? reasoning
            )
        {
            Message = message;
            FileSearchToolCall = fileSearchToolCall;
            FunctionToolCall = functionToolCall;
            WebSearchToolCall = webSearchToolCall;
            ComputerToolCall = computerToolCall;
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reasoning as object ??
            ComputerToolCall as object ??
            WebSearchToolCall as object ??
            FunctionToolCall as object ??
            FileSearchToolCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FileSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            WebSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            Reasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFileSearchToolCall || IsFunctionToolCall || IsWebSearchToolCall || IsComputerToolCall || IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Julep.ResponsesOutputMessage, TResult>? message = null,
            global::System.Func<global::Julep.ResponsesFileSearchToolCall, TResult>? fileSearchToolCall = null,
            global::System.Func<global::Julep.ResponsesFunctionToolCall, TResult>? functionToolCall = null,
            global::System.Func<global::Julep.ResponsesWebSearchToolCall, TResult>? webSearchToolCall = null,
            global::System.Func<global::Julep.ResponsesComputerToolCall, TResult>? computerToolCall = null,
            global::System.Func<global::Julep.ResponsesReasoningItem, TResult>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Julep.ResponsesOutputMessage>? message = null,

            global::System.Action<global::Julep.ResponsesFileSearchToolCall>? fileSearchToolCall = null,

            global::System.Action<global::Julep.ResponsesFunctionToolCall>? functionToolCall = null,

            global::System.Action<global::Julep.ResponsesWebSearchToolCall>? webSearchToolCall = null,

            global::System.Action<global::Julep.ResponsesComputerToolCall>? computerToolCall = null,

            global::System.Action<global::Julep.ResponsesReasoningItem>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Julep.ResponsesOutputMessage>? message = null,
            global::System.Action<global::Julep.ResponsesFileSearchToolCall>? fileSearchToolCall = null,
            global::System.Action<global::Julep.ResponsesFunctionToolCall>? functionToolCall = null,
            global::System.Action<global::Julep.ResponsesWebSearchToolCall>? webSearchToolCall = null,
            global::System.Action<global::Julep.ResponsesComputerToolCall>? computerToolCall = null,
            global::System.Action<global::Julep.ResponsesReasoningItem>? reasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::Julep.ResponsesOutputMessage),
                FileSearchToolCall,
                typeof(global::Julep.ResponsesFileSearchToolCall),
                FunctionToolCall,
                typeof(global::Julep.ResponsesFunctionToolCall),
                WebSearchToolCall,
                typeof(global::Julep.ResponsesWebSearchToolCall),
                ComputerToolCall,
                typeof(global::Julep.ResponsesComputerToolCall),
                Reasoning,
                typeof(global::Julep.ResponsesReasoningItem),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponsesOutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesOutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesWebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesOutputItem obj1, ResponsesOutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesOutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesOutputItem obj1, ResponsesOutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesOutputItem o && Equals(o);
        }
    }
}
