
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x80000005: L1 Cache and TLB Identifiers
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x80000005                                                                                                      |
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
    // | EDX = Reserved (0x00)                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>L1 Cache and TLB Identifiers</b>.
    /// </summary>
    internal sealed class Leaf80000005 : LeafBase
    {
        #region constructor/s

        #region [public] Leaf80000005(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf80000005"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf80000005(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (bool) Valid: Gets a value that indicates if the CPUID call is valid
        /// <summary>
        /// Gets a value that indicates if the <b>CPUID</b> call is valid.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Valid => InvokeResult.eax == 0x0000 && InvokeResult.ebx == 0x0000 && InvokeResult.ecx == 0x0000 && InvokeResult.edx == 0x0000;
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
            properties.Add(LeafProperty.L1CacheAndTlbIdentifiers.Valid, Valid);
        }
        #endregion

        #endregion
    }
}
