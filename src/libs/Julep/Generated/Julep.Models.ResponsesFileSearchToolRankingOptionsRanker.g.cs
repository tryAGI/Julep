
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesFileSearchToolRankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFileSearchToolRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFileSearchToolRankingOptionsRanker value)
        {
            return value switch
            {
                ResponsesFileSearchToolRankingOptionsRanker.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFileSearchToolRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesFileSearchToolRankingOptionsRanker.Auto,
                _ => null,
            };
        }
    }
}