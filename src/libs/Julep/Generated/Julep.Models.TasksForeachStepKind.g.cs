
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: foreach<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksForeachStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Foreach,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksForeachStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksForeachStepKind value)
        {
            return value switch
            {
                TasksForeachStepKind.Foreach => "foreach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksForeachStepKind? ToEnum(string value)
        {
            return value switch
            {
                "foreach" => TasksForeachStepKind.Foreach,
                _ => null,
            };
        }
    }
}