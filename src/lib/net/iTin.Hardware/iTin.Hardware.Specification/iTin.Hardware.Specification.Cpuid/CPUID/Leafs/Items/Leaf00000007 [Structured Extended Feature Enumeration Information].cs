
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000007: Structured Extended Feature Enumeration Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000007                                                                                                      |
    // | ECX = 0x00000000 (Main Leaf)                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reports the maximum input value for supported leaf 7 sub-leaves.                                                |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  FSGSBASE. Supports RDFSBASE/RDGSBASE/WRFSBASE/WRGSBASE if 1.                                              |
    // |         01  IA32_TSC_ADJUST MSR is supported if 1.                                                                    |
    // |         02  SGX. Supports Intel® Software Guard Extensions (Intel® SGX Extensions) if 1.                              |
    // |         03  BMI1.                                                                                                     |
    // |         04  HLE.                                                                                                      |
    // |         05  AVX2.                                                                                                     |
    // |         06  FDP_EXCPTN_ONLY. x87 FPU Data Pointer updated only on x87 exceptions if 1.                                |
    // |         07  SMEP. Supports Supervisor-Mode Execution Prevention if 1.                                                 |
    // |         08  BMI2.                                                                                                     |
    // |         09  Supports Enhanced REP MOVSB/STOSB if 1.                                                                   |
    // |         10  INVPCID. If 1, supports INVPCID instruction for system software that manages process-context identifiers. |
    // |         11  RTM.                                                                                                      |
    // |         12  RDT-M. Supports Intel® Resource Director Technology (Intel® RDT) Monitoring capability if 1.              |
    // |         13  Deprecates FPU CS and FPU DS values if 1.                                                                 |
    // |         14  MPX. Supports Intel® Memory Protection Extensions if 1.                                                   |
    // |         15  RDT-A. Supports Intel® Resource Director Technology (Intel® RDT) Allocation capability if 1.              |
    // |      17:16  Reserved                                                                                                  |
    // |         18  RDSEED.                                                                                                   |
    // |         19  ADX.                                                                                                      |
    // |         20  SMAP. Supports Supervisor-Mode Access Prevention (and the CLAC/STAC instructions) if 1.                   |
    // |      22:21  Reserved                                                                                                  |
    // |         23  CLFLUSHOPT.                                                                                               |
    // |         24  CLWB.                                                                                                     |
    // |         25  Intel Processor Trace.                                                                                    |
    // |      28:26  Reserved                                                                                                  |
    // |         29  SHA. supports Intel® Secure Hash Algorithm Extensions (Intel® SHA Extensions) if 1.                       |
    // |      31:30  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  PREFETCHWT1.                                                                                              |
    // |         01  Reserved                                                                                                  |
    // |         02  UMIP. Supports user-mode instruction prevention if 1.                                                     |
    // |         03  PKU. Supports protection keys for user-mode pages if 1.                                                   |
    // |         04  OSPKE. If 1, OS has set CR4.PKE to enable protection keys (and the RDPKRU/WRPKRU instruc- tions).         |
    // |      16:05  Reserved                                                                                                  |
    // |      21:17  The value of MAWAU used by the BNDLDX and BNDSTX instructions in 64-bit mode.                             |
    // |         22  RDPID. Supports Read Processor ID if 1.                                                                   |
    // |      29:23  Reserved                                                                                                  |
    // |         30  SGX_LC. Supports SGX Launch Configuration if 1.                                                           |
    // |         31  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · If ECX contains an invalid sub-leaf index, EAX/EBX/ECX/EDX return 0. Sub-leaf index n is invalid if n exceeds the   |
    // |   value that sub-leaf 0 returns in EAX.                                                                               |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Structured Extended Feature Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf00000007 : LeafBase
    {
        #region private constants

        #region register EBX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FSGSBASE = Bits.Bit00;            // 00 - FSGSBASE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_TSC_ADJUST_MSR = Bits.Bit01; // IA32_TSC_ADJUST MSR 
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SGX = Bits.Bit02;                 // 02 - SGX
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits BMI1 = Bits.Bit03;                // 03 - BMI1
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HLE = Bits.Bit04;                 // 04 - HLE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX2 = Bits.Bit05;                // 05 - AVX2
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FDP_EXCPTN_ONLY = Bits.Bit06;     // 06 - FDP_EXCPTN_ONLY
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SMEP = Bits.Bit07;                // 07 - SMEP
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits BMI2 = Bits.Bit08;                // 08 - BMI2
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ERMS = Bits.Bit09;                // 09 - Enhanced REP MOVSB/STOSB
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits INVPCID = Bits.Bit10;             // 10 - INVPCID
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RTM = Bits.Bit11;                 // 11 - RTM
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDT_M = Bits.Bit12;               // 12 - RDT-M
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits Deprecates_FPU = Bits.Bit13;      // 13 - Deprecates FPU CS and FPU DS 
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MPX = Bits.Bit14;                 // 14 - MPX
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDT_A = Bits.Bit15;               // 15 - RDT-A
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDSEED = Bits.Bit18;              // 18 - RDSEED
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ADX = Bits.Bit19;                 // 19 - ADX
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SMAP = Bits.Bit20;                // 20 - SMAP
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLFLUSHOPT = Bits.Bit23;          // 23 - CLFLUSHOPT
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLWB = Bits.Bit24;                // 24 - CLWB
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IPT = Bits.Bit25;                 // 25 - Intel Processor Trace
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SHA = Bits.Bit29;                 // 29 - SHA

        #endregion

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PREFETCHWT1 = Bits.Bit00; // 00 - PREFETCHWT1
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits UMIP = Bits.Bit02;        // 02 - UMIP
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PKU = Bits.Bit03;         // 03 - PKU
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits OSPKE = Bits.Bit04;       // 04 - OSPKE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDPID = Bits.Bit22;       // 22 - RDPID
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SGX_LC = Bits.Bit30;      // 30 - SGX_LC

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf07(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000007"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000007(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) MAWAU: Gets a value representing the 'MAWAU' field
        /// <summary>
        /// Gets a value representing the <b>MAWAU</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MAWAU => (InvokeResult.ecx >> 0x11) & 0x1f;
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
            #region ebx register

            properties.Add(LeafProperty.ExtendedFeatures.FSGSBASE, InvokeResult.ebx.CheckBit(FSGSBASE));
            properties.Add(LeafProperty.ExtendedFeatures.IA32_TSC_ADJUST_MSR, InvokeResult.ebx.CheckBit(IA32_TSC_ADJUST_MSR));
            properties.Add(LeafProperty.ExtendedFeatures.SGX, InvokeResult.ebx.CheckBit(SGX));
            properties.Add(LeafProperty.ExtendedFeatures.BMI1, InvokeResult.ebx.CheckBit(BMI1));
            properties.Add(LeafProperty.ExtendedFeatures.HLE, InvokeResult.ebx.CheckBit(HLE));
            properties.Add(LeafProperty.ExtendedFeatures.AVX2, InvokeResult.ebx.CheckBit(AVX2));
            properties.Add(LeafProperty.ExtendedFeatures.FDP_EXCPTN_ONLY, InvokeResult.ebx.CheckBit(FDP_EXCPTN_ONLY));
            properties.Add(LeafProperty.ExtendedFeatures.SMEP, InvokeResult.ebx.CheckBit(SMEP));
            properties.Add(LeafProperty.ExtendedFeatures.BMI2, InvokeResult.ebx.CheckBit(BMI2));
            properties.Add(LeafProperty.ExtendedFeatures.ERMS, InvokeResult.ebx.CheckBit(ERMS));
            properties.Add(LeafProperty.ExtendedFeatures.INVPCID, InvokeResult.ebx.CheckBit(INVPCID));
            properties.Add(LeafProperty.ExtendedFeatures.RTM, InvokeResult.ebx.CheckBit(RTM));
            properties.Add(LeafProperty.ExtendedFeatures.RDT_M, InvokeResult.ebx.CheckBit(RDT_M));
            properties.Add(LeafProperty.ExtendedFeatures.Deprecates_FPU, InvokeResult.ebx.CheckBit(Deprecates_FPU));
            properties.Add(LeafProperty.ExtendedFeatures.MPX, InvokeResult.ebx.CheckBit(MPX));
            properties.Add(LeafProperty.ExtendedFeatures.RDT_A, InvokeResult.ebx.CheckBit(RDT_A));
            properties.Add(LeafProperty.ExtendedFeatures.RDSEED, InvokeResult.ebx.CheckBit(RDSEED));
            properties.Add(LeafProperty.ExtendedFeatures.ADX, InvokeResult.ebx.CheckBit(ADX));
            properties.Add(LeafProperty.ExtendedFeatures.SMAP, InvokeResult.ebx.CheckBit(SMAP));
            properties.Add(LeafProperty.ExtendedFeatures.CLFLUSHOPT, InvokeResult.ebx.CheckBit(CLFLUSHOPT));
            properties.Add(LeafProperty.ExtendedFeatures.CLWB, InvokeResult.ebx.CheckBit(CLWB));
            properties.Add(LeafProperty.ExtendedFeatures.IPT, InvokeResult.ebx.CheckBit(IPT));
            properties.Add(LeafProperty.ExtendedFeatures.SHA, InvokeResult.ebx.CheckBit(SHA));

            #endregion

            #region ecx register

            properties.Add(LeafProperty.ExtendedFeatures.PREFETCHWT1, InvokeResult.ecx.CheckBit(PREFETCHWT1));
            properties.Add(LeafProperty.ExtendedFeatures.UMIP, InvokeResult.ecx.CheckBit(UMIP));
            properties.Add(LeafProperty.ExtendedFeatures.PKU, InvokeResult.ecx.CheckBit(PKU));
            properties.Add(LeafProperty.ExtendedFeatures.OSPKE, InvokeResult.ecx.CheckBit(OSPKE));
            properties.Add(LeafProperty.ExtendedFeatures.RDPID, InvokeResult.ecx.CheckBit(RDPID));
            properties.Add(LeafProperty.ExtendedFeatures.SGX_LC, InvokeResult.ecx.CheckBit(SGX_LC));

            #endregion
        }
        #endregion

        #endregion
    }
}
