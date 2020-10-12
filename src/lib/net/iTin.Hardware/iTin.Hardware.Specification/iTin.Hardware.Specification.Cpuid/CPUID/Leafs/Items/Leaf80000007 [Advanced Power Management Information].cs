
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x80000007: Advanced Power Management Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x80000007                                                                                                      |
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
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Invariant TSC                                                                                                   |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      07:00  Reserved (0x00)                                                                                           |
    // |         08  Invariant TSC available if 1                                                                              |
    // |      31:09  Reserved (0x00)                                                                                           |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Advanced Power Management Information</b>.
    /// </summary>
    internal sealed class Leaf80000007 : LeafBase
    {
        #region private constants

        #region register EDX definition
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC = Bits.Bit08; // 08 - nvariant TSC available if 1
        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf80000007(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf80000007"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf80000007(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (bool) InvariantTsc: Gets a value representing the 'Invariant TSC' field
        /// <summary>
        /// Gets a value representing the <b>Invariant TSC</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool InvariantTsc => InvokeResult.edx.CheckBit(TSC);
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
            properties.Add(LeafProperty.AdvancedPowerManagement.InvariantTSC, InvariantTsc);
        }
        #endregion

        #endregion
    }
}
