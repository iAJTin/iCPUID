﻿
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x80000003: Processor Brand String Continued
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x80000003                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Processor Brand String Continued                                                                                |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Processor Brand String Continued                                                                                |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Processor Brand String Continued                                                                                |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Processor Brand String Continued                                                                                |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Processor Brand String Continued</strong>.
/// </summary>
internal sealed class Leaf80000003 : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf80000003"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf80000003(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Processor Brand String</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string ProcessorName => $"{Word2Str((int)InvokeResult.eax)}{Word2Str((int)InvokeResult.ebx)}{Word2Str((int)InvokeResult.ecx)}{Word2Str((int)InvokeResult.edx)}";

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.ProcessorBrandString1.ProcessorNameContinued, ProcessorName);
    }

    #endregion
}
