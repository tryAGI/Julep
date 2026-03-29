
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksForeachStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Foreach,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksForeachStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksForeachStepEnumKind value)
        {
            return value switch
            {
                TasksForeachStepEnumKind.Foreach => "foreach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksForeachStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "foreach" => TasksForeachStepEnumKind.Foreach,
                _ => null,
            };
        }
    }
}