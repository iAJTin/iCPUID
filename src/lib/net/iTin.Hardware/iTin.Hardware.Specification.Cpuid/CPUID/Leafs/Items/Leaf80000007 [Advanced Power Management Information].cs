﻿
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x80000007: Advanced Power Management Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x80000007                                                                                                      |
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
// | EDX = Invariant TSC                                                                                                   |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      07:00  Reserved (0x00)                                                                                           |
// |         08  Invariant TSC available if 1                                                                              |
// |      31:09  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Advanced Power Management Information</strong>.
/// </summary>
internal sealed class Leaf80000007 : LeafBase
{
    #region private constants

    #region register EDX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC = Bits.Bit08; // 08 - nvariant TSC available if 1
    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf80000007"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf80000007(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Invariant TSC</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool InvariantTsc => InvokeResult.edx.CheckBit(TSC);

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.AdvancedPowerManagement.InvariantTSC, InvariantTsc);
    }

    #endregion
}
