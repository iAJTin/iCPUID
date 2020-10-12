
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000014: Intel Processor Trace Enumeration Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000014                                                                                                      |
    // | ECX = 0x00000000 (Main Leaf)                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reports the maximum sub-leaf supported in leaf 14H                                                              |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  If 1, indicates that IA32_RTIT_CTL.CR3Filter can be set to 1, and that IA32_RTIT_CR3_MATCH MSR can be     |
    // |             accessed.                                                                                                 |
    // |         01  If 1, indicates support of Configurable PSB and Cycle-Accurate Mode.                                      |
    // |         02  If 1, indicates support of IP Filtering, TraceStop filtering, and preservation of Intel PT MSRs across    |
    // |             warm reset.                                                                                               |
    // |         03  If 1, indicates support of MTC timing packet and suppression of COFI-based packets.                       |
    // |         04  If 1, indicates support of PTWRITE. Writes can set IA32_RTIT_CTL[12] (PTWEn) and IA32_RTIT_CTL[5]         |
    // |             (FUPonPTW), and PTWRITE can generate packets.                                                             |
    // |         05  If 1, indicates support of Power Event Trace. Writes can set IA32_RTIT_CTL[4] (PwrEvtEn), enabling Power  |
    // |             Event Trace packet generation.                                                                            |
    // |      31:06  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  If 1, Tracing can be enabled with IA32_RTIT_CTL.ToPA = 1, hence utilizing the ToPA output scheme;         |
    // |             IA32_RTIT_OUTPUT_BASE and IA32_RTIT_OUTPUT_MASK_PTRS MSRs can be accessed.                                |
    // |         01  If 1, ToPA tables can hold any number of output entries, up to the maximum allowed by the                 |
    // |             MaskOrTableOffset field of IA32_RTIT_OUTPUT_MASK_PTRS.                                                    |
    // |         02  If 1, indicates support of Single-Range Output scheme.                                                    |
    // |         03  If 1, indicates support of output to Trace Transport subsystem.                                           |
    // |      30:04  Reserved                                                                                                  |
    // |         31  If 1, generated packets which contain IP payloads have LIP values, which include the CS base com- ponent. |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000014                                                                                                      |
    // | ECX = 0x00000001                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      02:00  Number of configurable Address Ranges for filtering.                                                      |
    // |      15:03  Reserved                                                                                                  |
    // |      31:16  Bitmap of supported MTC period encodings.                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      15:00  Bitmap of supported Cycle Threshold value encodings.                                                      |
    // |      31:16  Bitmap of supported Configurable PSB frequency encodings.                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
  
    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Intel Processor Trace Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf00000014 : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

        #region register EBX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_RTIT_CTL = Bits.Bit00; // 00 - If 1, indicates that IA32_RTIT_CTL.CR3Filter can be set to 1, and that IA32_RTIT_CR3_MATCH MSR can be accessed
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CPSB = Bits.Bit01; // 01 - If 1, indicates support of Configurable PSB and Cycle-Accurate Mode
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IPFILTER = Bits.Bit02; // 02 - If 1, indicates support of IP Filtering, TraceStop filtering, and preservation of Intel PT MSRs across warm reset
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MTC_TIMMING = Bits.Bit03; // 03 - If 1, indicates support of MTC timing packet and suppression of COFI-based packets
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PTWRITE = Bits.Bit04; // 04 - If 1, indicates support of PTWRITE. Writes can set IA32_RTIT_CTL[12] (PTWEn) and IA32_RTIT_CTL[5] (FUPonPTW), and PTWRITE can generate packets
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PWEVTR = Bits.Bit05; // 05 - If 1, indicates support of Power Event Trace. Writes can set IA32_RTIT_CTL[4] (PwrEvtEn), enabling Power Event Trace packet generation

        #endregion

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_RTIT_CTL_TRC = Bits.Bit00; // 00 - If 1, Tracing can be enabled with IA32_RTIT_CTL.ToPA = 1, hence utilizing the ToPA output scheme; IA32_RTIT_OUTPUT_BASE and IA32_RTIT_OUTPUT_MASK_PTRS MSRs can be accessed
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TOPA = Bits.Bit01; // 01 - If 1, ToPA tables can hold any number of output entries, up to the maximum allowed by the Mas- kOrTableOffset field of IA32_RTIT_OUTPUT_MASK_PTRS
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SNGLRNG = Bits.Bit02; // 02 - If 1, indicates support of Single-Range Output scheme
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TRCTNPT = Bits.Bit03; // 03 - If 1, indicates support of output to Trace Transport subsystem
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IPPAY = Bits.Bit31; // 31 - If 1, generated packets which contain IP payloads have LIP values, which include the CS base com- ponent

        #endregion

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000014(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000014"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000014(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) MaximumSubLeafs: Gets a value representing the 'Maximum sub-leafs' field
        /// <summary>
        /// Gets a value representing the <b>Maximum sub-leafs</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumSubLeafs => InvokeResult.eax;
        #endregion

        #region [private] (uint) NumberConfigurableAddress: Gets a value representing the 'Number Of Configurable Address' field
        /// <summary>
        /// Gets a value representing the <b>Number Of Configurable Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint NumberConfigurableAddress => InvokeResult.eax & 0x7;
        #endregion

        #region [private] (uint) BitmapMTC: Gets a value representing the 'Bitmap of supported MTC period encodings' field
        /// <summary>
        /// Gets a value representing the <b>Bitmap of supported MTC period encodings</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint BitmapMTC => (InvokeResult.eax >> 10) & 0xffff;
        #endregion

        #region [private] (uint) BitmapCycle: Gets a value representing the 'Bitmap of supported Cycle Threshold value encodings' field
        /// <summary>
        /// Gets a value representing the <b>Bitmap of supported Cycle Threshold value encodings</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint BitmapCycle => InvokeResult.ebx & 0xffff;
        #endregion

        #region [private] (uint) BitmapPSB: Gets a value representing the 'Bitmap of supported Configurable PSB frequency encodings.' field
        /// <summary>
        /// Gets a value representing the <b>Bitmap of supported Configurable PSB frequency encodings.</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint BitmapPSB => (InvokeResult.ebx >> 10) & 0xffff;
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
            switch (SubLeaf)
            {
                case SubLeaf.Main:
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.MaximumSubLeafs, MaximumSubLeafs);
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.IA32_RTIT_CTL, InvokeResult.ebx.CheckBit(IA32_RTIT_CTL));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.CPSB, InvokeResult.ebx.CheckBit(CPSB));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.IPFILTER, InvokeResult.ebx.CheckBit(IPFILTER));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.MTC_TIMMING, InvokeResult.ebx.CheckBit(MTC_TIMMING));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.PTWRITE, InvokeResult.ebx.CheckBit(PTWRITE));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.PWEVTR, InvokeResult.ebx.CheckBit(PWEVTR));

                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.IA32_RTIT_CTL_TRC, InvokeResult.ecx.CheckBit(IA32_RTIT_CTL_TRC));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.TOPA, InvokeResult.ecx.CheckBit(TOPA));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.SNGLRNG, InvokeResult.ecx.CheckBit(SNGLRNG));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.TRCTNPT, InvokeResult.ecx.CheckBit(TRCTNPT));
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.IPPAY, InvokeResult.ecx.CheckBit(IPPAY));

                    break;

                case SubLeaf.One:
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.Item.NumberConfigurableAddress, NumberConfigurableAddress);
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.Item.BitmapMTC, BitmapMTC);
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.Item.BitmapCycle, BitmapCycle);
                    properties.Add(LeafProperty.ProcessorTraceEnumerationInformation.Item.BitmapPSB, BitmapPSB);
                    break;
            }
        }
        #endregion

        #endregion
    }
}
