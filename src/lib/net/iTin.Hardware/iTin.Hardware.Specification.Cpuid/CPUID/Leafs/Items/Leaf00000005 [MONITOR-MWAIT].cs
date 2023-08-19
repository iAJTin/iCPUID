
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x00000005: MONITOR/MWAIT
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x00000005                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Smallest monitor-line size in bytes (default is processor's monitor granularity).                         |
// |      31:16  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Largest monitor-line size in bytes (default is processor's monitor granularity).                          |
// |      31:16  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |         00  Enumeration of Monitor-Mwait extensions (beyond EAX and EBX registers) supported.                         |
// |         01  Supports treating interrupts as break-event for MWAIT, even when interrupts disabled.                     |
// |      31:02  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      03:00  Number of C0 sub C-states supported using MWAIT.                                                          |
// |      07:04  Number of C1 sub C-states supported using MWAIT.                                                          |
// |      11:08  Number of C2 sub C-states supported using MWAIT.                                                          |
// |      15:12  Number of C3 sub C-states supported using MWAIT.                                                          |
// |      19:16  Number of C4 sub C-states supported using MWAIT.                                                          |
// |      23:20  Number of C5 sub C-states supported using MWAIT.                                                          |
// |      27:24  Number of C6 sub C-states supported using MWAIT.                                                          |
// |      31:28  Number of C7 sub C-states supported using MWAIT.                                                          |
// |                                                                                                                       |
// •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | · The definition of C0 through C7 states for MWAIT extension are processor-specific C-states, not ACPI C-states.      |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>MONITOR/MWAIT</b>.
/// </summary>
internal sealed class Leaf00000005 : LeafBase
{
    #region private constants

    #region register ECX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits NMMMW = Bits.Bit00; // 00 - Enumeration of Monitor-Mwait extensions (beyond EAX and EBX registers) supported
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TRRNG = Bits.Bit01; // 01 - Supports treating interrupts as break-event for MWAIT, even when interrupts disable
    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf00000005"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf00000005(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>C0</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C0 => InvokeResult.edx.GetByte(Bytes.Byte00).ToArray()[0];

    /// <summary>
    /// Gets a value representing the <b>C1</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C1 => InvokeResult.edx.GetByte(Bytes.Byte00).ToArray()[1];

    /// <summary>
    /// Gets a value representing the <b>C2</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C2 => InvokeResult.edx.GetByte(Bytes.Byte01).ToArray()[0];

    /// <summary>
    /// Gets a value representing the <b>C3</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C3 => InvokeResult.edx.GetByte(Bytes.Byte01).ToArray()[1];

    /// <summary>
    /// Gets a value representing the <b>C4</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C4 => InvokeResult.edx.GetByte(Bytes.Byte02).ToArray()[0];

    /// <summary>
    /// Gets a value representing the <b>C5</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C5 => InvokeResult.edx.GetByte(Bytes.Byte02).ToArray()[1];

    /// <summary>
    /// Gets a value representing the <b>C6</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C6 => InvokeResult.edx.GetByte(Bytes.Byte03).ToArray()[0];

    /// <summary>
    /// Gets a value representing the <b>C7</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte C7 => InvokeResult.edx.GetByte(Bytes.Byte03).ToArray()[1];

    /// <summary>
    /// Gets a value representing the <b>Smallest monitor-line size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint SmallestMonitorLineSize => InvokeResult.eax & 0xffff;

    /// <summary>
    /// Gets a value representing the <b>Largest monitor-line size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint LargestMonitorLineSize => InvokeResult.ebx & 0xffff;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        var hasExtensions = InvokeResult.ecx.CheckBit(NMMMW);
        if (hasExtensions)
        {
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C0, C0);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C1, C1);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C2, C2);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C3, C3);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C4, C4);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C5, C5);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C6, C6);
            properties.Add(LeafProperty.MonitorAndMwaitFeatures.C7, C7);
        }

        properties.Add(LeafProperty.MonitorAndMwaitFeatures.SmallestMonitorLineSize, SmallestMonitorLineSize);
        properties.Add(LeafProperty.MonitorAndMwaitFeatures.LargestMonitorLineSize, LargestMonitorLineSize);
        properties.Add(LeafProperty.MonitorAndMwaitFeatures.MwaitSupportsTreatingInterrupts, InvokeResult.ecx.CheckBit(TRRNG));
    }

    #endregion
}
