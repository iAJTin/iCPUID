
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x80000006: Extended L2 Cache Features
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x80000006                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reserved (0x00)                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Reserved (0x00)                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reserved (0x00)                                                                                                 |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      07:00  Cache Line size in bytes                                                                                  |
    // |      11:08  Reserved (0x00)                                                                                           |
    // |      15:12  L2 Associativity field                                                                                    |
    // |      31:16  Cache size in 1K units                                                                                    |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved (0x00)                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Extended L2 Cache Features</b>.
    /// </summary>
    internal sealed class Leaf80000006 : LeafBase
    {
        #region private constants

        #region register EDX definition
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC = Bits.Bit08; // 08 - nvariant TSC available if 1
        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf80000006(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf80000006"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf80000006(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) CacheLineSize: Gets a value representing the 'Cache Line Size' field
        /// <summary>
        /// Gets a value representing the <b>Cache Line Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CacheLineSize => InvokeResult.ecx.GetByte(Bytes.Byte00);
        #endregion

        #region [private] (byte) CacheSize: Gets a value representing the 'Cache Size' field
        /// <summary>
        /// Gets a value representing the <b>Cache Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint CacheSize => CreateUnsignedIntFromValues(InvokeResult.ecx.GetByte(Bytes.Byte03), InvokeResult.ecx.GetByte(Bytes.Byte02));
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(CpuidPropertiesTable): Populates the property collection for this leaf
        /// <summary>
        /// Populates the property collection for this leaf.
        /// </summary>
        /// <param name="properties">Collection of properties of this leaf.</param>
        protected override void PopulateProperties(CpuidPropertiesTable properties)
        {
            properties.Add(LeafProperty.ExtendedL2CacheFeatures.CacheLineSize, CacheLineSize);
            properties.Add(LeafProperty.ExtendedL2CacheFeatures.CacheSize, CacheSize);
        }
        #endregion

        #endregion
    }
}
