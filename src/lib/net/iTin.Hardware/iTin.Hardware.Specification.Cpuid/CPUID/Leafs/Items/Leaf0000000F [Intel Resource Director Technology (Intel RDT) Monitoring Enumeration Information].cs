
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x0000000F: Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x0000000F                                                                                                      |
// | ECX = 0x00000000 Sub-leaf index 0 reports valid resource type starting at bit position 1 of EDX                       |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Reserved                                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Maximum range (zero-based) of RMID within this physical processor of all types.                                 |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Reserved                                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |         00  Reserved                                                                                                  |
// |         01  Supports L3 Cache Intel RDT Monitoring if 1.                                                              |
// |      31:02  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x0000000F                                                                                                      |
// | ECX = 0x00000001                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Reserved                                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Conversion factor from reported IA32_QM_CTR value to occupancy metric (bytes).                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Maximum range (zero-based) of RMID of this resource type.                                                       |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |         00  Supports L3 occupancy monitoring if 1.                                                                    |
// |         01  Supports L3 Total Bandwidth monitoring if 1.                                                              |
// |         02  Supports L3 Local Bandwidth monitoring if 1.                                                              |
// |      31:03  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information</b>.
/// </summary>
internal sealed class Leaf0000000F : LeafBase
{
    #region private constants

    #region SubLeaf: Main

    #region register EDX definition

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L3RDT = Bits.Bit01; // 01 - Supports L3 Cache Intel RDT Monitoring

    #endregion

    #endregion

    #region SubLeaf: One

    #region register EDX definition

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L3OCC = Bits.Bit00;    // 00 - Supports L3 occupancy monitoring
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L3TBRAND = Bits.Bit01; // 01 - Supports L3 Total Bandwidth monitoring
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L3LBRAND = Bits.Bit02; // 02 - Supports L3 Local Bandwidth monitoring

    #endregion

    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf0000000F"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf0000000F(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Maximum range</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint MaximumRangeAllTypes => InvokeResult.ebx;

    /// <summary>
    /// Gets a value representing the <b>Conversion factor from reported IA32_QM_CTR</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint ConversionFactorThis => InvokeResult.ebx;

    /// <summary>
    /// Gets a value representing the <b>Maximum range</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint MaximumRangeThis => InvokeResult.ecx;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        switch (SubLeaf)
        {
            case SubLeaf.Main:
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.MaximumRangeAllTypes, MaximumRangeAllTypes);
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.L3CacheIntelRDT, InvokeResult.edx.CheckBit(L3RDT));
                break;

            case SubLeaf.One:
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.Item.ConversionFactorThis, ConversionFactorThis);
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.Item.MaximumRangeThis, MaximumRangeThis);
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.Item.L3OCC, InvokeResult.edx.CheckBit(L3OCC));
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.Item.L3TBRAND, InvokeResult.edx.CheckBit(L3TBRAND));
                properties.Add(LeafProperty.ResourceDirectorTechnologyMonitoring.Item.L3LBRAND, InvokeResult.edx.CheckBit(L3LBRAND));
                break;
        }
    }

    #endregion
}
