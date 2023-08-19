
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x80000001: Extended Processor Info And Features
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x80000001                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Reserved                                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Reserved                                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Feature Information                                                                                             |
// |                                                                                                                       |
// |       Bit  Mnemonic   Description                                                                                     |
// |        00  LAHF/SAHF  LAHF/SAHF available in 64-bit mode                                                              |
// |     04:01  ---        Reserved                                                                                        |
// |        05  LZCNT                                                                                                      |
// |     07:06  ---        Reserved                                                                                        |
// |        08  PREFETCHW                                                                                                  |
// |     31:09  ---        Reserved                                                                                        |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Feature Information                                                                                             |
// |                                                                                                                       |
// |       Bit  Mnemonic             Description                                                                           |
// |     10:00  ---                  Reserved                                                                              |
// |        11  SYSCALL/SYSRET       Available in 64-bit mode                                                              |
// |     19:12  ---                  Reserved                                                                              |
// |        20  EXEDISBIT            Execute Disable Bit available                                                         |
// |     25:21  ---                  Reserved                                                                              |
// |        26  PAGE1G               1-GByte pages are available if 1                                                      |
// |        27  RDTSCP/IA32_TSC_AUX  RDTSCP and IA32_TSC_AUX are available if 1                                            |
// |        28  ---                  Reserved                                                                              |
// |        29  I64                  Intel® 64 Architecture available if 1                                                 |
// |     31:30  ---                  Reserved (0)                                                                          |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Extended Processor Info And Features</b>.
/// </summary>
internal sealed class Leaf80000001 : LeafBase
{
    #region private constants

    #region register ECX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits LAHF_SAHF = Bits.Bit00;  // 00 - LAHF/SAHF available in 64-bit mode 
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits LZCNT = Bits.Bit05;      // 05 - LZCNT
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PREFETCHW = Bits.Bit08;  // 08 - PREFETCHW
    #endregion

    #region register EDX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SYSCALL_SYSRET = Bits.Bit11;       // 11 - SYSCALL/SYSRET Available in 64-bit mode 
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits EXEDISBIT = Bits.Bit20;            // 20 - Execute Disable Bit available
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PAGE1G = Bits.Bit26;               // 26 - 1-GByte pages are available if 1
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDTSCP_IA32_TSC_AUX = Bits.Bit27;  // 27 - RDTSCP and IA32_TSC_AUX are available if 1 
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits I64 = Bits.Bit29;                  // 29 - Intel® 64 Architecture available if 1 
    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf80000001"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf80000001(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        #region ecx register

        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.LAHF_SAHF, InvokeResult.ecx.CheckBit(LAHF_SAHF));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.LZCNT, InvokeResult.ecx.CheckBit(LZCNT));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.PREFETCHW, InvokeResult.ecx.CheckBit(PREFETCHW));

        #endregion

        #region edx register

        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.SYSCALL_SYSRET, InvokeResult.ecx.CheckBit(SYSCALL_SYSRET));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.EXEDISBIT, InvokeResult.ecx.CheckBit(EXEDISBIT));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.PAGE1G, InvokeResult.ecx.CheckBit(PAGE1G));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.RDTSCP_IA32_TSC_AUX, InvokeResult.ecx.CheckBit(RDTSCP_IA32_TSC_AUX));
        properties.Add(LeafProperty.ExtendedProcessorInfoAndFeatures.I64, InvokeResult.ecx.CheckBit(I64));

        #endregion
    }

    #endregion
}
