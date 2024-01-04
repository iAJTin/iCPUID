
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x00000016: Processor Frequency Information
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x00000016                                                                                                      |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Processor Base Frequency (in MHz)                                                                         |
// |      31:16  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Maximum Frequency (in MHz)                                                                                |
// |      31:16  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      15:00  Bus (Reference) Frequency (in MHz)                                                                        |
// |      31:16  Reserved (0x00)                                                                                           |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Reserved.                                                                                                       |
// |                                                                                                                       |
// •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | · Data is returned from this interface in accordance with the processor's specification and does not reflect actual   |
// |   values.                                                                                                             |
// |                                                                                                                       |
// | · Suitable use of this data includes the display of processor information in like manner to the processor brand       |
// |   string and for determining the appropriate range to use when displaying processor information e.g. frequency        |
// |   history graphs. The returned information should not be used for any other purpose as the returned information does  |
// |   not accurately correlate to information / counters returned by other processor interfaces.                          |
// |                                                                                                                       |
// | · While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not  |
// |   supported.                                                                                                          |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Processor Frequency Information</strong>.
/// </summary>
internal sealed class Leaf00000016 : LeafBase
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf00000016"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf00000016(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Processor Base Frequency</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint ProcessorBaseFrequency => InvokeResult.eax & 0xffff;

    /// <summary>
    /// Gets a value representing the <strong>Maximum Frequency</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint MaximumFrequency => InvokeResult.ebx & 0xffff;

    /// <summary>
    /// Gets a value representing the <strong>Bus Reference Frequency</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint BusReferenceFrequency => InvokeResult.ecx & 0xffff;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.ProcessorFrequencyInformation.ProcessorBaseFrequency, ProcessorBaseFrequency);
        properties.Add(LeafProperty.ProcessorFrequencyInformation.MaximumFrequency, MaximumFrequency);
        properties.Add(LeafProperty.ProcessorFrequencyInformation.BusReferenceFrequency, BusReferenceFrequency);
    }

    #endregion
}
