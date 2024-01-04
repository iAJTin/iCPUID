
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x00000000: Basic CPUID Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x00000000                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = The highest basic calling parameter                                                                             |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = CPU's manufacturer ID string - [ Order 1 ]                                                                      |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = CPU's manufacturer ID string - [ Order 3 ]                                                                      |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = CPU's manufacturer ID string - [ Order 2 ]                                                                      |
// |                                                                                                                       |
// •—REMARKS———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | The following are known processor manufacturer ID strings: (https://en.wikipedia.org/wiki/CPUID#History)              |
// | - 'AMDisbetter!'                                                                                                      |
// | - 'AuthenticAMD'                                                                                                      |
// | - 'CentaurHauls'                                                                                                      |
// | - 'CyrixInstead'                                                                                                      |
// | - 'GenuineIntel'                                                                                                      |
// | - 'TransmetaCPU'                                                                                                      |
// | - 'GenuineTMx86'                                                                                                      |
// | - 'Geode by NSC'                                                                                                      |
// | - 'NexGenDriven'                                                                                                      |
// | - 'RiseRiseRise'                                                                                                      |
// | - 'SiS SiS SiS '                                                                                                      |
// | - 'VIA VIA VIA '                                                                                                      |
// | - 'Vortex86 SoC'                                                                                                      |
// | - '  Shanghai  '                                                                                                      |
// | - 'HygonGenuine'                                                                                                      |
// | - 'E2K MACHINE'                                                                                                       |
// | - 'GenuineAO486'                                                                                                      |
// | - 'bhyve bhyve '                                                                                                      |
// | - ' KVMKVMKVM '                                                                                                       |
// | - 'TCGTCGTCGTCG'                                                                                                      |
// | - 'Microsoft Hv'                                                                                                      |
// | - ' lrpepyh vr'                                                                                                       |
// | - 'VMwareVMware'                                                                                                      |
// | - 'XenVMMXenVMM'                                                                                                      |
// | - 'ACRNACRNACRN'                                                                                                      |
// | - ' QNXQVMBSQG '                                                                                                      |
// | - 'VirtualApple'                                                                                                      |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Basic CPUID Information</strong>.
/// </summary>
internal sealed class Leaf00000000 : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf00000000"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf00000000(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Highest Basic Function</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint HighestBasicFunction => InvokeResult.eax;

    /// <summary>
    /// Gets a value representing the <b>Manufacturer</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string Manufacturer => $"{Word2Str((int)InvokeResult.ebx)}{Word2Str((int)InvokeResult.edx)}{Word2Str((int)InvokeResult.ecx)}";

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    { 
        properties.Add(LeafProperty.BasicInformation.HighestBasicFunction, HighestBasicFunction);
        properties.Add(LeafProperty.BasicInformation.Manufacturer, Manufacturer);
    }

    #endregion
}
