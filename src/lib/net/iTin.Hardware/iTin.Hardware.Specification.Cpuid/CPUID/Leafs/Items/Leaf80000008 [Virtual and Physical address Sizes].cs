
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x80000008: Virtual and Physical address Sizes
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x80000008                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Linear/Physical Address size                                                                                    |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      07:00  Physical Address Bits                                                                                     |
// |      15:08  Linear Address Bits                                                                                       |
// |      31:16  Reserved (0x00)                                                                                           |
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
// | EDX = Reserved (0x00)                                                                                                 |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Virtual and Physical address Sizes</b>.
/// </summary>
internal sealed class Leaf80000008 : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf80000008"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf80000008(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Physical Address Size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte PhysicalAddressSize => InvokeResult.eax.GetByte(Bytes.Byte00);

    /// <summary>
    /// Gets a value representing the <b>Linear Address Bits</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte LinearAddress => InvokeResult.eax.GetByte(Bytes.Byte01);

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.VirtualAndPhysicalAddressSizes.PhysicalAddressSize, PhysicalAddressSize);
        properties.Add(LeafProperty.VirtualAndPhysicalAddressSizes.LinearAddressBits, LinearAddress);
    }

    #endregion
}
