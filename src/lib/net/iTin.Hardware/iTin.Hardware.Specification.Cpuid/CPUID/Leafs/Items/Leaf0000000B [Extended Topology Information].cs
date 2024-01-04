
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x0000000B: Extended Topology Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x0000000B                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      04:00  Number of bits to shift right on x2APIC ID to get a unique topology ID of the next level type (See Notes) |
// |             All logical processors with the same next level ID share current level.                                   |
// |      31:05  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Number of logical processors at this level type. The number reflects configuration as shipped by Intel.   |
// |             (See Notes).                                                                                              |
// |      31:16  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      07:00  Level number. Same value in ECX input.                                                                    |
// |      15:08  Level type                                                                                                |
// |      31:16  Reserved                                                                                                  |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = x2APIC ID the current logical processor.                                                                        |
// |                                                                                                                       |
// •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | · Most of Leaf 0BH output depends on the initial value in ECX.                                                        |
// |                                                                                                                       |
// | · The EDX output of leaf 0BH is always valid and does not vary with input value in ECX.                               |
// |                                                                                                                       |
// | · Output value in ECX[7:0] always equals input value in ECX[7:0].                                                     |
// |                                                                                                                       |
// | · For sub-leaves that return an invalid level-type of 0 in ECX[15:8]; EAX and EBX will return 0.                      |
// |                                                                                                                       |
// | · If an input value n in ECX returns the invalid level-type of 0 in ECX[15:8], other input values with ECX > n also   |
// |   return 0 in ECX[15:8].                                                                                              |
// |                                                                                                                       |
// | · Software should use this field (EAX[4:0]) to enumerate processor topology of the system.                            |
// |                                                                                                                       |
// | · Software must not use EBX[15:0] to enumerate processor topology of the system. This value in this field (EBX[15:0]) |
// |   is only intended for display/diagnostic purposes. The actual number of logical processors available to              |
// |   BIOS/OS/Applications may be different from the value of EBX[15:0], depending on software and platform hardware      |
// |   configurations.                                                                                                     |
// |                                                                                                                       |
// | · Software must not use EBX[15:0] to enumerate processor topology of the system. This value in this field (EBX[15:0]) |
// |   is only intended for display/diagnostic purposes. The actual number of logical processors available to              |
// |   BIOS/OS/Applications may be different from the value of EBX[15:0], depending on software and platform hardware      |
// |   configurations.                                                                                                     |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Extended Topology Information</strong>.
/// </summary>
internal sealed class Leaf0000000B : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf0000000B"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf0000000B(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main)
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Bits Shift Right x2APIC ID</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint BitsShiftRightx2APICID => InvokeResult.eax & 0x1f;

    /// <summary>
    /// Gets a value representing the <strong>Number Of Logical Processors This Level</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint NumberOfLogicalProcessorsThisLevel => InvokeResult.ebx & 0xffff;

    /// <summary>
    /// Gets a value representing the <strong>Level Number</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint LevelNumber => InvokeResult.ecx & 0xff;

    /// <summary>
    /// Gets a value representing the <strong>x2APIC ID</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint x2APICID => InvokeResult.edx;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.ExtendedTopologyInformation.BitsShiftRightx2APICID, BitsShiftRightx2APICID);
        properties.Add(LeafProperty.ExtendedTopologyInformation.NumberOfLogicalProcessorsThisLevel, NumberOfLogicalProcessorsThisLevel);
        properties.Add(LeafProperty.ExtendedTopologyInformation.LevelType, GetLevelType(LevelNumber));
        properties.Add(LeafProperty.ExtendedTopologyInformation.x2APICID, x2APICID);
    }

    #endregion


    #region CPUID Specification

    /// <summary>
    /// Returns the Level Type.
    /// </summary>
    /// <param name="code">Value to analyze</param>
    /// <returns>
    /// A <see cref="string"/> containing the EPC section encoding.
    /// </returns>
    private static string GetLevelType(uint code)
    {
        string[] levelType =
        [
            "Invalid",
            "SMT",
            "Core"
        ];

        return code > 0x02
            ? "Reserved"
            : levelType[code];
    }

    #endregion
}
