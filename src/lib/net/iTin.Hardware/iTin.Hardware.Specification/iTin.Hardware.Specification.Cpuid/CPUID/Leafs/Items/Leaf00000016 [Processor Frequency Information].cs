
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

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
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Processor Frequency Information</b>.
    /// </summary>
    internal sealed class Leaf00000016 : LeafBase
    {
        #region constructor/s

        #region [public] Leaf00000016(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000016"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000016(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) ProcessorBaseFrequency: Gets a value representing the 'Processor Base Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Processor Base Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint ProcessorBaseFrequency => InvokeResult.eax & 0xffff;
        #endregion

        #region [private] (uint) MaximumFrequency: Gets a value representing the 'Maximum Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumFrequency => InvokeResult.ebx & 0xffff;
        #endregion

        #region [private] (uint) BusReferenceFrequency: Gets a value representing the 'Bus Reference Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Bus Reference Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint BusReferenceFrequency => InvokeResult.ecx & 0xffff;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(CpuidPropertiesTable): Populates the property collection for this leaf
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

        #endregion
    }
}
