
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x00000015: Time Stamp Counter and Nominal Core Crystal Clock Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x00000015                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = An unsigned integer which is the denominator of the TSC/”core crystal clock” ratio.                             |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = An unsigned integer which is the numerator of the TSC/”core crystal clock” ratio.                               |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = An unsigned integer which is the nominal frequency of the core crystal clock in Hz.                             |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Reserved (0x00)                                                                                                 |
// |                                                                                                                       |
// •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | · If EBX[31:0] is 0, the TSC/”core crystal clock” ratio is not enumerated.                                            |
// |   EBX[31:0]/EAX[31:0] indicates the ratio of the TSC frequency and the core crystal clock frequency.                  |
// |                                                                                                                       |
// | · If ECX is 0, the nominal core crystal clock frequency is not enumerated.                                            |
// |   "TSC frequency" = "core crystal clock frequency" * EBX/EAX.                                                         |
// |                                                                                                                       |
// | · The core crystal clock may differ from the reference clock, bus clock, or core clock frequencies.                   |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Time Stamp Counter and Nominal Core Crystal Clock Information</b>.
/// </summary>
internal sealed class Leaf00000015 : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf00000015"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf00000015(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Denominator of the TSC/core crystal clock ratio</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint Denominator => InvokeResult.eax;

    /// <summary>
    /// Gets a value representing the <b>Numerator of the TSC/core crystal clock ratio</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint Numerator => InvokeResult.ebx;

    /// <summary>
    /// Gets a value representing the <b>Nominal Frequency in Hz</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint NominalFrequency => InvokeResult.ecx;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        if (Numerator == 0 || Denominator == 0 || NominalFrequency == 0)
        {
            properties.Add(LeafProperty.TimeStampCounterAndNominalCoreCrystalClock.TSCFrequency, -1);
        }
        else
        {
            properties.Add(LeafProperty.TimeStampCounterAndNominalCoreCrystalClock.TSCFrequency, (Numerator / Denominator) * NominalFrequency);
        }
    }

    #endregion
}
