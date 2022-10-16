
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x00000010: Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000010                                                                                                      |
    // | ECX = 0x00000000 (ResID) index 0 reports valid resource identification (ResID) starting at bit position 1 of EBX      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  Reserved.                                                                                                 |
    // |         01  Supports L3 Cache Allocation Technology if 1.                                                             |
    // |         02  Supports L2 Cache Allocation Technology if 1.                                                             |
    // |      31:03  Reserved.                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000010                                                                                                      |
    // | ECX = 0x00000001 L3 Cache Allocation Technology Enumeration                                                           |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      04:00  Length of the capacity bit mask for the corresponding ResID using minus-one notation.                     |
    // |      31:05  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Bit-granular map of isolation/contention of allocation units.                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  Reserved                                                                                                  |
    // |         01  Updates of COS should be infrequent if 1.                                                                 |
    // |         02  Code and Data Prioritization Technology supported if 1.                                                   |
    // |      31:03  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Information                                                                                                        |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      15:00  Highest COS number supported for this ResID.                                                              |
    // |      31:16  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000010                                                                                                      |
    // | ECX = 0x00000002 L2 Cache Allocation Technology Enumeration                                                           |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      04:00  Length of the capacity bit mask for the corresponding ResID using minus-one notation.                     |
    // |      31:05  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Bit-granular map of isolation/contention of allocation units.                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  Reserved                                                                                                  |
    // |         01  Updates of COS should be infrequent if 1.                                                                 |
    // |         02  Code and Data Prioritization Technology supported if 1.                                                   |
    // |      31:03  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Information                                                                                                        |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      15:00  Highest COS number supported for this ResID.                                                              |
    // |      31:16  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf00000010 : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

        #region register EBX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L3ALLOC = Bits.Bit01; // 01 - Supports L3 Cache Allocation Technology
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L2ALLOC = Bits.Bit02; // 02 - Supports L2 Cache Allocation Technology

        #endregion

        #endregion

        #region SubLeaf: One/Two

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits UPCOS = Bits.Bit01; // 01 - Updates of COS
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CDDTP = Bits.Bit02; // 02 - Code and Data Prioritization Technology

        #endregion

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000010(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000010"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000010(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) LengthBitMask: Gets a value representing the 'Length Bit Mask' field
        /// <summary>
        /// Gets a value representing the <b>Length Bit Mask</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint LengthBitMask => InvokeResult.eax & 0x1f;
        #endregion

        #region [private] (uint) BitGranularMap: Gets a value representing the 'Bit Granular Map' field
        /// <summary>
        /// Gets a value representing the <b>Bit Granular Map</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint BitGranularMap => InvokeResult.ebx;
        #endregion

        #region [private] (uint) Highest_COS: Gets a value representing the 'Highest COS' field
        /// <summary>
        /// Gets a value representing the <b>Highest COS</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint Highest_COS => InvokeResult.edx & 0xffff;
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
            switch (SubLeaf)
            {
                case SubLeaf.Main:
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.L3CacheAllocation, InvokeResult.ebx.CheckBit(L3ALLOC));
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.L2CacheAllocation, InvokeResult.ebx.CheckBit(L2ALLOC));
                    break;

                case SubLeaf.One:
                case SubLeaf.Two:
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.ResId.LengthBitMask, LengthBitMask);
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.ResId.BitGranularMap, BitGranularMap);
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.ResId.COS, InvokeResult.ecx.CheckBit(UPCOS));
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.ResId.CodeDataPriorization, InvokeResult.ecx.CheckBit(CDDTP));
                    properties.Add(LeafProperty.ResourceDirectorTechnologyAllocation.ResId.Highest_COS, Highest_COS);
                    break;
            }
        }
        #endregion

        #endregion
    }
}
