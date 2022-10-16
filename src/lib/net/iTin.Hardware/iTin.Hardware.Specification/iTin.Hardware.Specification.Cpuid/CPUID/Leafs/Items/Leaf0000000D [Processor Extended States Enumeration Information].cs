
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x0000000D: Processor Extended States Enumeration Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x0000000D                                                                                                      |
    // | ECX = 0x00000000 (Main Leaf)                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reports the supported bits of the lower 32 bits of XCR0. XCR0[n] can be set to 1 only if EAX[n] is 1            |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  x87 state.                                                                                                |
    // |         01  SSE state.                                                                                                |
    // |         02  AVX state.                                                                                                |
    // |      04:03  MPX state.                                                                                                |
    // |      05:07  AVX-512 state.                                                                                            |
    // |         08  Used for IA32_XSS.                                                                                        |
    // |         09  PKRU state.                                                                                               |
    // |      31:10  Reserved.                                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) required by enabled features in XCR0.    |
    // |       May be different than ECX if some features at the end of the XSAVE save area are not enabled.                   |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) of the XSAVE/XRSTOR save area required   |
    // |       by all supported features in the processor, i.e., all the valid bit fields in XCR0.                             |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reports the supported bits of the upper 32 bits of XCR0. XCR0[n+32] can be set to 1 only if EDX[n] is 1, else   |
    // |       reserved.                                                                                                       |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x0000000D                                                                                                      |
    // | ECX = 0x00000001                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  XSAVEOPT is available.                                                                                    |
    // |         01  Supports XSAVEC and the compacted form of XRSTOR if set.                                                  |
    // |         02  Supports XGETBV with ECX = 1 if set.                                                                      |
    // |         03  Supports XSAVES/XRSTORS and IA32_XSS if set.                                                              |
    // |      31:04  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = The size in bytes of the XSAVE area containing all states enabled by XCRO | IA32_XSS.                           |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reports the supported bits of the lower 32 bits of the IA32_XSS MSR. IA32_XSS[n] can be set to 1 only if        |
    // |       ECX[n] is 1.                                                                                                    |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      07:00  Used for XCR0.                                                                                            |
    // |         08  PT state.                                                                                                 |
    // |         09  Used for XCR0.                                                                                            |
    // |      31:10  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reports the supported bits of the upper 32 bits of the IA32_XSS MSR. IA32_XSS[n+32] can be set to 1 only if     |
    // |       EDX[n] is 1, else reserved.                                                                                     |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x0000000D                                                                                                      |
    // | ECX = n, n > 1                                                                                                        |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = he size in bytes (from the offset specified in EBX) of the save area for an extended state feature associated   |
    // |       with a valid sub-leaf index, n.                                                                                 |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = The offset in bytes of this extended state component’s save area from the beginning of the XSAVE/XRSTOR area.   |
    // |       This field reports 0 if the sub-leaf index, n, does not map to a valid bit in the XCR0 register. (see notes)    |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = This field reports 0 if the sub-leaf index, n, is invalid (See Notes).                                          |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  is set if the bit n (corresponding to the sub-leaf index) is supported in the IA32_XSS MSR; it is clear   |
    // |             if bit n is instead supported in XCR0.                                                                    |
    // |         01  Is set if, when the compacted format of an XSAVE area is used, this extended state component located on   |
    // |             the next 64-byte boundary following the preceding state component (otherwise, it is located immediately   |
    // |             following the preceding state component).                                                                 |
    // |      31:02  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = This field reports 0 if the sub-leaf index, n, is invalid (See Notes); otherwise it is reserved.                |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · Each sub-leaf index (starting at position 2) is supported if it corresponds to a supported bit in either the XCR0   |
    // |   register or the IA32_XSS MSR                                                                                        |
    // |                                                                                                                       |
    // | · If ECX contains an invalid sub-leaf index, EAX/EBX/ECX/EDX return 0. Sub-leaf n (0 ≤ n ≤ 31) is invalid if          |
    // |   sub-leaf 0 returns 0 in EAX[n] and sub-leaf 1 returns 0 in ECX[n]. Sub-leaf n (32 ≤ n ≤ 63) is invalid if           |
    // |   sub-leaf 0 returns 0 in EDX[n-32] and sub-leaf 1 returns 0 in EDX[n-32].                                            |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Processor Extended States Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf0000000D : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

        #region register EAX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits x87 = Bits.Bit00; // 00 - x87 State
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE = Bits.Bit01; // 01 - SSE State
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX = Bits.Bit02; // 02 - AVX State
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_XSS = Bits.Bit08; // 08 - Used for IA32_XSS
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PKRU = Bits.Bit09; // 09 - PKRU State

        #endregion

        #region register EDX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits UPPER32BITS_XCR0 = Bits.Bit31; // 31 - Reports the supported bits of the upper 32 bits of XCR0. XCR0[n+32] can be set to 1 only if EDX[n] is 1

        #endregion

        #endregion

        #region SubLeaf: One

        #region register EAX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XSAVEOPT = Bits.Bit00;                // 00 - XSAVEOPT is available
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XSAVEC = Bits.Bit01;                  // 01 - Supports XSAVEC and the compacted form of XRSTOR if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XGETBV = Bits.Bit02;                  // 02 - Supports XGETBV with ECX = 1 if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XSAVES_XRSTORS_IA32_XSS = Bits.Bit03; // 03 - Supports XSAVES/XRSTORS and IA32_XSS if set

        #endregion

        #endregion

        #region SubLeaf: Two or hihger

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ThisLeafSuppoertedInIA32_XSR = Bits.Bit00; // 00 - Is set if the bit n (corresponding to the sub-leaf index)
                                                                                                                        // is supported in the IA32_XSS MSR; it is clear if bit n is instead supported in XCR0

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XSAVEAREAUSED = Bits.Bit01;                // 01 - Is set if, when the compacted format of an XSAVE area is used,
                                                                                                                        // this extended state component located on the next 64-byte boundary following the
                                                                                                                        // preceding state component (otherwise, it is located immediately following the
                                                                                                                        // preceding state component)
        #endregion

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf0000000D(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf0000000D"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf0000000D(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) MPXState: Gets a value representing the 'MPX State' field
        /// <summary>
        /// Gets a value representing the <b>MPX State</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MPXState => (byte)(InvokeResult.eax >> 3 & 0x03);
        #endregion

        #region [private] (byte) AVX512State: Gets a value representing the 'AVX-512 state' field
        /// <summary>
        /// Gets a value representing the <b>AVX-512 state</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AVX512State => (byte)(InvokeResult.eax >> 5 & 0x03);
        #endregion

        #region [private] (uint) MaximumSizeEnabledFeaturesXCR0: Gets a value representing the 'Maximum size enabled features XCRO' field
        /// <summary>
        /// Gets a value representing the <b>Maximum size enabled features XCRO</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumSizeEnabledFeaturesXCR0 => InvokeResult.ebx;
        #endregion

        #region [private] (uint) MaximumSizeAllSupportedFeatures: Gets a value representing the 'Maximum size all supported features' field
        /// <summary>
        /// Gets a value representing the <b>Maximum size all supported features</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumSizeAllSupportedFeatures => InvokeResult.ecx;
        #endregion

        #region [private] (uint) SizeAllStatesEnabled: Gets a value representing the 'Size all states enabled' field
        /// <summary>
        /// Gets a value representing the <b>Size all states enabled</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SizeAllStatesEnabled => InvokeResult.ebx;
        #endregion

        #region [private] (uint) Lower32Bits_IA32_XSS: Gets a value representing the 'Lower 32 Bits IA32_XSS' field
        /// <summary>
        /// Gets a value representing the <b>Lower 32 Bits IA32_XSS</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint Lower32Bits_IA32_XSS => InvokeResult.ecx;
        #endregion

        #region [private] (uint) Upper32Bits_IA32_XSS: Gets a value representing the 'Upper 32 Bits IA32_XSS' field
        /// <summary>
        /// Gets a value representing the <b>Upper 32 Bits IA32_XSS</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint Upper32Bits_IA32_XSS => InvokeResult.edx;
        #endregion

        #region [private] (uint) SizeSaveAreaExtendedStateFeature: Gets a value representing the 'Size Save Area Extended State Feature' field
        /// <summary>
        /// Gets a value representing the <b>Size Save Area Extended State Feature</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SizeSaveAreaExtendedStateFeature => InvokeResult.eax;
        #endregion

        #region [private] (uint) OffsetThisExtenndedStateComponent: Gets a value representing the 'Offset This Extennded State Component' field
        /// <summary>
        /// Gets a value representing the <b>Offset This Extennded State Component</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint OffsetThisExtenndedStateComponent => InvokeResult.ebx;
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
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.x87State, InvokeResult.eax.CheckBit(x87));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.SSEState, InvokeResult.eax.CheckBit(SSE));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.AVXState, InvokeResult.eax.CheckBit(AVX));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.IA32_XSS, InvokeResult.eax.CheckBit(IA32_XSS));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.PKRUState, InvokeResult.eax.CheckBit(PKRU));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.MaximumSizeEnabledFeaturesXCR0, MaximumSizeEnabledFeaturesXCR0);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.MaximumSizeAllSupportedFeatures, MaximumSizeAllSupportedFeatures);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.UPPER32BITS_XCR0, InvokeResult.edx.CheckBit(UPPER32BITS_XCR0));
                    break;

                case SubLeaf.One:
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.XSAVEOPT, InvokeResult.eax.CheckBit(XSAVEOPT));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.XSAVEC, InvokeResult.eax.CheckBit(XSAVEC));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.XGETBV, InvokeResult.eax.CheckBit(XGETBV));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.XSAVES_XRSTORS_IA32_XSS, InvokeResult.eax.CheckBit(XSAVES_XRSTORS_IA32_XSS));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.SizeAllStatesEnabled, SizeAllStatesEnabled);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.Lower32Bits_IA32_XSS, Lower32Bits_IA32_XSS);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.Upper32Bits_IA32_XSS, Upper32Bits_IA32_XSS);
                    break;

                default:
                {
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.SizeSaveAreaExtendedStateFeature, SizeSaveAreaExtendedStateFeature);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.OffsetThisExtenndedStateComponent, OffsetThisExtenndedStateComponent);
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.ThisSubLeafSuppoertedInIA32_XSR, InvokeResult.ecx.CheckBit(ThisLeafSuppoertedInIA32_XSR));
                    properties.Add(LeafProperty.ProcessorExtendedStatesInformation.XSAVEAREAUSED, InvokeResult.ecx.CheckBit(XSAVEAREAUSED));
                    break;
                }
            }
        }
        #endregion

        #endregion
    }
}
