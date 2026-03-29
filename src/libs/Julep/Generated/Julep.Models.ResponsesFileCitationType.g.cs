
#nullable enable

namespace Julep
{
    /// <summary>
    /// The type of the file citation. Always `file_citation`.
    /// </summary>
    public enum ResponsesFileCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesFileCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesFileCitationType value)
        {
            return value switch
            {
                ResponsesFileCitationType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesFileCitationType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => ResponsesFileCitationType.FileCitation,
                _ => null,
            };
        }
    }
}