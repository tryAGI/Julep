#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesTool : global::System.IEquatable<ResponsesTool>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesFunctionTool? Function { get; init; }
#else
        public global::Julep.ResponsesFunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesFunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Julep.ResponsesFunctionTool PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesWebSearchTool? WebSearch { get; init; }
#else
        public global::Julep.ResponsesWebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesWebSearchTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Julep.ResponsesWebSearchTool PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesFileSearchTool? FileSearch { get; init; }
#else
        public global::Julep.ResponsesFileSearchTool? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesFileSearchTool? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Julep.ResponsesFileSearchTool PickFileSearch() => IsFileSearch
            ? FileSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Julep.ResponsesComputerTool? Computer { get; init; }
#else
        public global::Julep.ResponsesComputerTool? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Julep.ResponsesComputerTool? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Julep.ResponsesComputerTool PickComputer() => IsComputer
            ? Computer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesTool(global::Julep.ResponsesFunctionTool value) => new ResponsesTool((global::Julep.ResponsesFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFunctionTool?(ResponsesTool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesTool(global::Julep.ResponsesFunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesTool FromFunction(global::Julep.ResponsesFunctionTool? value) => new ResponsesTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesTool(global::Julep.ResponsesWebSearchTool value) => new ResponsesTool((global::Julep.ResponsesWebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesWebSearchTool?(ResponsesTool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesTool(global::Julep.ResponsesWebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesTool FromWebSearch(global::Julep.ResponsesWebSearchTool? value) => new ResponsesTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesTool(global::Julep.ResponsesFileSearchTool value) => new ResponsesTool((global::Julep.ResponsesFileSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesFileSearchTool?(ResponsesTool @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesTool(global::Julep.ResponsesFileSearchTool? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesTool FromFileSearch(global::Julep.ResponsesFileSearchTool? value) => new ResponsesTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesTool(global::Julep.ResponsesComputerTool value) => new ResponsesTool((global::Julep.ResponsesComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Julep.ResponsesComputerTool?(ResponsesTool @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesTool(global::Julep.ResponsesComputerTool? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesTool FromComputer(global::Julep.ResponsesComputerTool? value) => new ResponsesTool(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesTool(
            global::Julep.ResponsesFunctionTool? function,
            global::Julep.ResponsesWebSearchTool? webSearch,
            global::Julep.ResponsesFileSearchTool? fileSearch,
            global::Julep.ResponsesComputerTool? computer
            )
        {
            Function = function;
            WebSearch = webSearch;
            FileSearch = fileSearch;
            Computer = computer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Computer as object ??
            FileSearch as object ??
            WebSearch as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString() ??
            FileSearch?.ToString() ??
            Computer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsWebSearch || IsFileSearch || IsComputer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Julep.ResponsesFunctionTool, TResult>? function = null,
            global::System.Func<global::Julep.ResponsesWebSearchTool, TResult>? webSearch = null,
            global::System.Func<global::Julep.ResponsesFileSearchTool, TResult>? fileSearch = null,
            global::System.Func<global::Julep.ResponsesComputerTool, TResult>? computer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsComputer && computer != null)
            {
                return computer(Computer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Julep.ResponsesFunctionTool>? function = null,

            global::System.Action<global::Julep.ResponsesWebSearchTool>? webSearch = null,

            global::System.Action<global::Julep.ResponsesFileSearchTool>? fileSearch = null,

            global::System.Action<global::Julep.ResponsesComputerTool>? computer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Julep.ResponsesFunctionTool>? function = null,
            global::System.Action<global::Julep.ResponsesWebSearchTool>? webSearch = null,
            global::System.Action<global::Julep.ResponsesFileSearchTool>? fileSearch = null,
            global::System.Action<global::Julep.ResponsesComputerTool>? computer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Julep.ResponsesFunctionTool),
                WebSearch,
                typeof(global::Julep.ResponsesWebSearchTool),
                FileSearch,
                typeof(global::Julep.ResponsesFileSearchTool),
                Computer,
                typeof(global::Julep.ResponsesComputerTool),
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
        public bool Equals(ResponsesTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesWebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesFileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Julep.ResponsesComputerTool?>.Default.Equals(Computer, other.Computer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesTool obj1, ResponsesTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesTool obj1, ResponsesTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesTool o && Equals(o);
        }
    }
}
