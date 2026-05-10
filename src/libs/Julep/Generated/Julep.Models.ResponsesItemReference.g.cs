#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Julep
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct ResponsesItemReference : global::System.IEquatable<ResponsesItemReference>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesInputMessageResource? InputMessageResource { get; init; }
#else
        public global::Julep.ResponsesInputMessageResource? InputMessageResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageResource))]
#endif
        public bool IsInputMessageResource => InputMessageResource != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputMessageResource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesInputMessageResource? value)
        {
            value = InputMessageResource;
            return IsInputMessageResource;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesOutputMessage? OutputMessage { get; init; }
#else
        public global::Julep.ResponsesOutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesOutputMessage? value)
        {
            value = OutputMessage;
            return IsOutputMessage;
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
        public global::Julep.ResponsesComputerToolCallOutputResource? ComputerToolCallOutputResource { get; init; }
#else
        public global::Julep.ResponsesComputerToolCallOutputResource? ComputerToolCallOutputResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutputResource))]
#endif
        public bool IsComputerToolCallOutputResource => ComputerToolCallOutputResource != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerToolCallOutputResource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesComputerToolCallOutputResource? value)
        {
            value = ComputerToolCallOutputResource;
            return IsComputerToolCallOutputResource;
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
        public global::Julep.ResponsesFunctionToolCallOutputResource? FunctionToolCallOutputResource { get; init; }
#else
        public global::Julep.ResponsesFunctionToolCallOutputResource? FunctionToolCallOutputResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutputResource))]
#endif
        public bool IsFunctionToolCallOutputResource => FunctionToolCallOutputResource != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionToolCallOutputResource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesFunctionToolCallOutputResource? value)
        {
            value = FunctionToolCallOutputResource;
            return IsFunctionToolCallOutputResource;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesInputMessageResource value) => new ResponsesItemReference((global::Julep.ResponsesInputMessageResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesInputMessageResource?(ResponsesItemReference @this) => @this.InputMessageResource;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesInputMessageResource? value)
        {
            InputMessageResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromInputMessageResource(global::Julep.ResponsesInputMessageResource? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesOutputMessage value) => new ResponsesItemReference((global::Julep.ResponsesOutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesOutputMessage?(ResponsesItemReference @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesOutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromOutputMessage(global::Julep.ResponsesOutputMessage? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesFileSearchToolCall value) => new ResponsesItemReference((global::Julep.ResponsesFileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFileSearchToolCall?(ResponsesItemReference @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesFileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromFileSearchToolCall(global::Julep.ResponsesFileSearchToolCall? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesComputerToolCall value) => new ResponsesItemReference((global::Julep.ResponsesComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesComputerToolCall?(ResponsesItemReference @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromComputerToolCall(global::Julep.ResponsesComputerToolCall? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesComputerToolCallOutputResource value) => new ResponsesItemReference((global::Julep.ResponsesComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesComputerToolCallOutputResource?(ResponsesItemReference @this) => @this.ComputerToolCallOutputResource;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutputResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromComputerToolCallOutputResource(global::Julep.ResponsesComputerToolCallOutputResource? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesWebSearchToolCall value) => new ResponsesItemReference((global::Julep.ResponsesWebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesWebSearchToolCall?(ResponsesItemReference @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesWebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromWebSearchToolCall(global::Julep.ResponsesWebSearchToolCall? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesFunctionToolCall value) => new ResponsesItemReference((global::Julep.ResponsesFunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFunctionToolCall?(ResponsesItemReference @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesFunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromFunctionToolCall(global::Julep.ResponsesFunctionToolCall? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesItemReference(global::Julep.ResponsesFunctionToolCallOutputResource value) => new ResponsesItemReference((global::Julep.ResponsesFunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFunctionToolCallOutputResource?(ResponsesItemReference @this) => @this.FunctionToolCallOutputResource;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(global::Julep.ResponsesFunctionToolCallOutputResource? value)
        {
            FunctionToolCallOutputResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesItemReference FromFunctionToolCallOutputResource(global::Julep.ResponsesFunctionToolCallOutputResource? value) => new ResponsesItemReference(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesItemReference(
            global::Julep.ResponsesInputMessageResource? inputMessageResource,
            global::Julep.ResponsesOutputMessage? outputMessage,
            global::Julep.ResponsesFileSearchToolCall? fileSearchToolCall,
            global::Julep.ResponsesComputerToolCall? computerToolCall,
            global::Julep.ResponsesComputerToolCallOutputResource? computerToolCallOutputResource,
            global::Julep.ResponsesWebSearchToolCall? webSearchToolCall,
            global::Julep.ResponsesFunctionToolCall? functionToolCall,
            global::Julep.ResponsesFunctionToolCallOutputResource? functionToolCallOutputResource
            )
        {
            InputMessageResource = inputMessageResource;
            OutputMessage = outputMessage;
            FileSearchToolCall = fileSearchToolCall;
            ComputerToolCall = computerToolCall;
            ComputerToolCallOutputResource = computerToolCallOutputResource;
            WebSearchToolCall = webSearchToolCall;
            FunctionToolCall = functionToolCall;
            FunctionToolCallOutputResource = functionToolCallOutputResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionToolCallOutputResource as object ??
            FunctionToolCall as object ??
            WebSearchToolCall as object ??
            ComputerToolCallOutputResource as object ??
            ComputerToolCall as object ??
            FileSearchToolCall as object ??
            OutputMessage as object ??
            InputMessageResource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessageResource?.ToString() ??
            OutputMessage?.ToString() ??
            FileSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            ComputerToolCallOutputResource?.ToString() ??
            WebSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionToolCallOutputResource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessageResource || IsOutputMessage || IsFileSearchToolCall || IsComputerToolCall || IsComputerToolCallOutputResource || IsWebSearchToolCall || IsFunctionToolCall || IsFunctionToolCallOutputResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Julep.ResponsesInputMessageResource, TResult>? inputMessageResource = null,
            global::System.Func<global::Julep.ResponsesOutputMessage, TResult>? outputMessage = null,
            global::System.Func<global::Julep.ResponsesFileSearchToolCall, TResult>? fileSearchToolCall = null,
            global::System.Func<global::Julep.ResponsesComputerToolCall, TResult>? computerToolCall = null,
            global::System.Func<global::Julep.ResponsesComputerToolCallOutputResource, TResult>? computerToolCallOutputResource = null,
            global::System.Func<global::Julep.ResponsesWebSearchToolCall, TResult>? webSearchToolCall = null,
            global::System.Func<global::Julep.ResponsesFunctionToolCall, TResult>? functionToolCall = null,
            global::System.Func<global::Julep.ResponsesFunctionToolCallOutputResource, TResult>? functionToolCallOutputResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessageResource && inputMessageResource != null)
            {
                return inputMessageResource(InputMessageResource!);
            }
            else if (IsOutputMessage && outputMessage != null)
            {
                return outputMessage(OutputMessage!);
            }
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsComputerToolCallOutputResource && computerToolCallOutputResource != null)
            {
                return computerToolCallOutputResource(ComputerToolCallOutputResource!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutputResource && functionToolCallOutputResource != null)
            {
                return functionToolCallOutputResource(FunctionToolCallOutputResource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Julep.ResponsesInputMessageResource>? inputMessageResource = null,

            global::System.Action<global::Julep.ResponsesOutputMessage>? outputMessage = null,

            global::System.Action<global::Julep.ResponsesFileSearchToolCall>? fileSearchToolCall = null,

            global::System.Action<global::Julep.ResponsesComputerToolCall>? computerToolCall = null,

            global::System.Action<global::Julep.ResponsesComputerToolCallOutputResource>? computerToolCallOutputResource = null,

            global::System.Action<global::Julep.ResponsesWebSearchToolCall>? webSearchToolCall = null,

            global::System.Action<global::Julep.ResponsesFunctionToolCall>? functionToolCall = null,

            global::System.Action<global::Julep.ResponsesFunctionToolCallOutputResource>? functionToolCallOutputResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessageResource)
            {
                inputMessageResource?.Invoke(InputMessageResource!);
            }
            else if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsComputerToolCallOutputResource)
            {
                computerToolCallOutputResource?.Invoke(ComputerToolCallOutputResource!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutputResource)
            {
                functionToolCallOutputResource?.Invoke(FunctionToolCallOutputResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Julep.ResponsesInputMessageResource>? inputMessageResource = null,
            global::System.Action<global::Julep.ResponsesOutputMessage>? outputMessage = null,
            global::System.Action<global::Julep.ResponsesFileSearchToolCall>? fileSearchToolCall = null,
            global::System.Action<global::Julep.ResponsesComputerToolCall>? computerToolCall = null,
            global::System.Action<global::Julep.ResponsesComputerToolCallOutputResource>? computerToolCallOutputResource = null,
            global::System.Action<global::Julep.ResponsesWebSearchToolCall>? webSearchToolCall = null,
            global::System.Action<global::Julep.ResponsesFunctionToolCall>? functionToolCall = null,
            global::System.Action<global::Julep.ResponsesFunctionToolCallOutputResource>? functionToolCallOutputResource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessageResource)
            {
                inputMessageResource?.Invoke(InputMessageResource!);
            }
            else if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsComputerToolCallOutputResource)
            {
                computerToolCallOutputResource?.Invoke(ComputerToolCallOutputResource!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutputResource)
            {
                functionToolCallOutputResource?.Invoke(FunctionToolCallOutputResource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessageResource,
                typeof(global::Julep.ResponsesInputMessageResource),
                OutputMessage,
                typeof(global::Julep.ResponsesOutputMessage),
                FileSearchToolCall,
                typeof(global::Julep.ResponsesFileSearchToolCall),
                ComputerToolCall,
                typeof(global::Julep.ResponsesComputerToolCall),
                ComputerToolCallOutputResource,
                typeof(global::Julep.ResponsesComputerToolCallOutputResource),
                WebSearchToolCall,
                typeof(global::Julep.ResponsesWebSearchToolCall),
                FunctionToolCall,
                typeof(global::Julep.ResponsesFunctionToolCall),
                FunctionToolCallOutputResource,
                typeof(global::Julep.ResponsesFunctionToolCallOutputResource),
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
        public bool Equals(ResponsesItemReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesInputMessageResource?>.Default.Equals(InputMessageResource, other.InputMessageResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesOutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutputResource, other.ComputerToolCallOutputResource) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesWebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutputResource, other.FunctionToolCallOutputResource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesItemReference obj1, ResponsesItemReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesItemReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesItemReference obj1, ResponsesItemReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesItemReference o && Equals(o);
        }
    }
}
