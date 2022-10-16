
using iTin.Core.ComponentModel;

namespace iTin.Hardware.Specification.Cpuid
{
    /// <summary>
    /// Defines the known leaf values
    /// </summary>
    public enum SubLeaf : uint
    {
        /// <summary>
        /// Main sub-leaf
        /// </summary>
        [EnumDescription("0")]
        Main = 0,

        /// <summary>
        /// One sub-leaf
        /// </summary>
        [EnumDescription("1")]
        One,

        /// <summary>
        /// Two sub-leaf
        /// </summary>
        [EnumDescription("2")]
        Two,

        /// <summary>
        /// Three sub-leaf
        /// </summary>
        [EnumDescription("3")]
        Three,

        /// <summary>
        /// Four sub-leaf
        /// </summary>
        [EnumDescription("4")]
        Four,

        /// <summary>
        /// Five sub-leaf
        /// </summary>
        [EnumDescription("5")]
        Five,

        /// <summary>
        /// Six sub-leaf
        /// </summary>
        [EnumDescription("6")]
        Six,

        /// <summary>
        /// Seven sub-leaf
        /// </summary>
        [EnumDescription("7")]
        Seven,

        /// <summary>
        /// Seven sub-leaf
        /// </summary>
        [EnumDescription("8")]
        Eight,
        
        /// <summary>
        /// Seven sub-leaf
        /// </summary>
        [EnumDescription("9")]
        Nine,
        
        /// <summary>
        /// Ten sub-leaf
        /// </summary>
        [EnumDescription("10")]
        Ten,
    }
}
