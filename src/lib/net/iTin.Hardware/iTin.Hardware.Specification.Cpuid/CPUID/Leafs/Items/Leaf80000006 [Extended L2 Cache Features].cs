﻿
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x80000006: Extended L2 Cache Features
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x80000006                                                                                                      |
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
// |       Bits  Value                                                                                                     |
// |      07:00  Cache Line size in bytes                                                                                  |
// |      11:08  Reserved (0x00)                                                                                           |
// |      15:12  L2 Associativity field                                                                                    |
// |      31:16  Cache size in 1K units                                                                                    |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Reserved (0x00)                                                                                                 |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Extended L2 Cache Features</strong>.
/// </summary>
internal sealed class Leaf80000006 : LeafBase
{
    #region private constants

    #region register EDX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC = Bits.Bit08; // 08 - nvariant TSC available if 1
    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf80000006"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf80000006(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Cache Line Size</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte CacheLineSize => InvokeResult.ecx.GetByte(Bytes.Byte00);

    /// <summary>
    /// Gets a value representing the <strong>Cache Size</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint CacheSize => CreateUnsignedIntFromValues(InvokeResult.ecx.GetByte(Bytes.Byte03), InvokeResult.ecx.GetByte(Bytes.Byte02));

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.ExtendedL2CacheFeatures.CacheLineSize, CacheLineSize);
        properties.Add(LeafProperty.ExtendedL2CacheFeatures.CacheSize, CacheSize);
    }

    #endregion
}
