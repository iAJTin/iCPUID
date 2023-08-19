
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x0000000A: Architectural Performance Monitoring Features
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x0000000A                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      07:00  Version ID of architectural performance monitoring.                                                       |
// |      15:08  Number of general-purpose performance monitoring counter per logical processor.                           |
// |      23:16  Bit width of general-purpose, performance monitoring counter.                                             |
// |      31:24  Length of EBX bit vector to enumerate architectural performance monitoring events.                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |         00  Core cycle event not available if 1.                                                                      |
// |         01  Instruction retired event not available if 1.                                                             |
// |         02  Reference cycles event not available if 1.                                                                |
// |         03  Last-level cache reference event not available if 1.                                                      |
// |         04  Last-level cache misses event not available if 1.                                                         |
// |         05  Branch instruction retired event not available if 1.                                                      |
// |         06  Branch mispredict retired event not available if 1.                                                       |
// |      31:07  Reserved                                                                                                  |
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
// |      04:00  umber of fixed-function performance counters (if Version ID > 1).                                         |
// |      12:05  Bit width of fixed-function performance counters (if Version ID > 1).                                     |
// |      31:06  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Architectural Performance Monitoring Features</b>.
/// </summary>
internal sealed class Leaf0000000A : LeafBase
{
    #region private constants

    #region register EBX definition

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CCE = Bits.Bit00;     // 00 - Core cycle event 
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IRE = Bits.Bit01;     // 01 - Instruction retired event
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RCE = Bits.Bit02;     // 02 - Reference cycles event
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits LLCRE = Bits.Bit03;   // 03 - Last-level cache reference event
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits LLCME = Bits.Bit04;   // 04 - Last-level cache misses event
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits BIRE = Bits.Bit05;    // 05 - Branch instruction retired event
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits BMRE = Bits.Bit06;    // 06 - Branch mispredict retired event

    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf0000000A"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf0000000A(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Version ID of architectural performance monitoring</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint VersionId => InvokeResult.eax & 0xff;

    /// <summary>
    /// Gets a value representing the <b>Number of general-purpose performance monitoring counter per logical processor</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint NumberOfGeneralPurposeCounterPerLogicalProcessor => (InvokeResult.eax >> 0x08) & 0xff;

    /// <summary>
    /// Gets a value representing the <b>Bit width of general-purpose, performance monitoring counter</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint BitWidth => (InvokeResult.eax >> 0x10) & 0xff;

    /// <summary>
    /// Gets a value representing the <b>Length of EBX bit vector to enumerate architectural performance monitoring events</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint LenghtBitVector => (InvokeResult.eax >> 0x18) & 0xff;

    /// <summary>
    /// Gets a value representing the <b>Number of fixed-function performance counters</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte NumberFixFunctionsCounters => (byte)(InvokeResult.edx & 0xf);

    /// <summary>
    /// Gets a value representing the <b>Bit width of fixed-function performance counters</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte BitWidthFixFunctionsCounters => (byte)((InvokeResult.edx>> 0x05) & 0xff);

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        #region eax register

        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.VersionId, VersionId);
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.NumberOfGeneralPurposeCounterPerLogicalProcessor, NumberOfGeneralPurposeCounterPerLogicalProcessor);
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.BitWidth, BitWidth);
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.LenghtBitVector, LenghtBitVector);

        #endregion

        #region ebx register

        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.CCE, !InvokeResult.ebx.CheckBit(CCE));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.IRE, !InvokeResult.ebx.CheckBit(IRE));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.RCE, !InvokeResult.ebx.CheckBit(RCE));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.LLCRE, !InvokeResult.ebx.CheckBit(LLCRE));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.LLCME, !InvokeResult.ebx.CheckBit(LLCME));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.BIRE, !InvokeResult.ebx.CheckBit(BIRE));
        properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.BMRE, !InvokeResult.ebx.CheckBit(BMRE));

        #endregion

        #region edx register

        if (VersionId > 1)
        {
            properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.NumberFixFunctionsCounters, NumberFixFunctionsCounters);
            properties.Add(LeafProperty.ArchitecturalPerformanceMonitoringFeatures.BitWidthFixFunctionsCounters, BitWidthFixFunctionsCounters);
        }

        #endregion
    }

    #endregion
}
