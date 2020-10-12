
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000017: System-On-Chip Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000017                                                                                                      |
    // | ECX = 0x00000000 (Main Leaf)                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = MaxSOCID_Index. Reports the maximum input value of supported sub-leaf in leaf 17H                               |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      15:00  SOC Vendor ID                                                                                             |
    // |         16  IsVendorScheme                                                                                            |
    // |             If 1, the SOC Vendor ID field is assigned via an industry standard enumeration scheme.                    |
    // |             Otherwise, the SOC Vendor ID field is assigned by Intel.                                                  |
    // |      31:17  Reserved (0x00)                                                                                           |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Project ID. A unique number an SOC vendor assigns to its SOC projects.                                          |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Stepping ID. A unique number within an SOC project that an SOC vendor assigns.                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000017                                                                                                      |
    // | ECX = 0x00000001..0x00000001                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = SOC Vendor Brand String. UTF-8 encoded string                                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = SOC Vendor Brand String. UTF-8 encoded string                                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = SOC Vendor Brand String. UTF-8 encoded string                                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = SOC Vendor Brand String. UTF-8 encoded string                                                                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · SOC Vendor Brand String is a UTF-8 encoded string padded with trailing bytes of 00H.                                |
    // |                                                                                                                       |
    // | · The complete SOC Vendor Brand String is constructed by concatenating in ascending order of EAX:EBX:ECX:EDX and from |
    // |   the sub-leaf 1 fragment towards sub-leaf 3.                                                                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>System-On-Chip Information</b>.
    /// </summary>
    internal sealed class Leaf00000017 : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

        #region register EBX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IsVendorScheme = Bits.Bit16; // 16 - If 1, the SOC Vendor ID field is assigned via an industry standard enumeration scheme. Otherwise, the SOC Vendor ID field is assigned by Intel.

        #endregion

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000017(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000017"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000017(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) MaxSOCID: Gets a value representing the 'MaxSOCID' field
        /// <summary>
        /// Gets a value representing the <b>MaxSOCID</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaxSOCID => InvokeResult.eax;
        #endregion

        #region [private] (uint) SocVendorId: Gets a value representing the 'SOC Vendor Id' field
        /// <summary>
        /// Gets a value representing the <b>SOC Vendor Id</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SocVendorId => InvokeResult.ebx & 0xffff;
        #endregion

        #region [private] (uint) ProjectID: Gets a value representing the 'Project ID' field
        /// <summary>
        /// Gets a value representing the <b>Project ID</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint ProjectID => InvokeResult.ecx;
        #endregion

        #region [private] (uint) SteppingID: Gets a value representing the 'Stepping ID' field
        /// <summary>
        /// Gets a value representing the <b>Stepping ID</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SteppingID => InvokeResult.edx;
        #endregion

        #region [private] (string) SOCVendorBrandString.: Gets a value representing the 'SOC Vendor Brand String.' field
        /// <summary>
        /// Gets a value representing the <b>Processor Brand String</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SOCVendorBrandString => $"{Word2Str((int)InvokeResult.eax)}{Word2Str((int)InvokeResult.ebx)}{Word2Str((int)InvokeResult.ecx)}{Word2Str((int)InvokeResult.edx)}";
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
            if (SubLeaf== SubLeaf.Main)
            {
                properties.Add(LeafProperty.SystemOnChipInformation.MaxSOCID, MaxSOCID);
                properties.Add(LeafProperty.SystemOnChipInformation.SocVendorId, SocVendorId);
                properties.Add(LeafProperty.SystemOnChipInformation.IsVendorScheme, InvokeResult.ebx.CheckBit(IsVendorScheme));
                properties.Add(LeafProperty.SystemOnChipInformation.ProjectID, ProjectID);
                properties.Add(LeafProperty.SystemOnChipInformation.SteppingID, SteppingID);
            }
            else
            {
                properties.Add(LeafProperty.SystemOnChipInformation.Chip.SOCVendorBrandString, SOCVendorBrandString);
            }
        }
        #endregion

        #endregion
    }
}
