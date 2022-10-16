
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Hardware.CrossPlatform.Cpuid;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x00000003: Processor Serial Number
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000003                                                                                                      |
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
    // | ECX = ProcessorSerialNumber. Pentium III processors only, otherwise reserved. Bits[31:00]                             |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = ProcessorSerialNumber. Pentium III processors only, otherwise reserved. Bits[61:32]                             |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | Processor serial number (PSN) is not supported in the Pentium 4 processor or later. On all models, use the PSN flag   |
    // | (returned using CPUID) to check for PSN support before accessing the feature.                                         |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Processor Serial Number</b>.
    /// </summary>
    internal sealed class Leaf00000003 : LeafBase
    {
        #region constructor/s

        #region [public] Leaf00000003(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000003"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000003(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => $"{CreateUnsignedLongFromValues(InvokeResult.edx, InvokeResult.ecx):X8}";
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
            var psn = SafeCpuidNativeMethods.Invoke((uint) Leaf.ProcessorInfoAndFeatures).edx.CheckBit(Bits.Bit18);
            if (psn == false)
            {
                properties.Add(LeafProperty.ProcessorSerialNumber.SerialNumber, "Not applicable. Reserved");
                return;
            }

            properties.Add(LeafProperty.ProcessorSerialNumber.SerialNumber, SerialNumber);
        }
        #endregion

        #endregion
    }
}
