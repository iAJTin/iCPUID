
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000001: Processor Info and Feature Bits
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000001                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Processor Version Information (CPU Signature)                                                                   |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      03:00  Stepping ID                                                                                               |
    // |      07:04  Model                                                                                                     |
    // |      11:08  Family ID                                                                                                 |
    // |      13:12  Processor Type                                                                                            |
    // |      15:14  Reserved                                                                                                  |
    // |      19:16  Extended Model ID                                                                                         |
    // |      27:20  Extended Family ID                                                                                        |
    // |      31:28  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Additional Information                                                                                          |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      07:00  Brand Index                                                                                               |
    // |      15:08  CLFLUSH line size (Value ∗ 8 = cache line size in bytes; used also by CLFLUSHOPT)                         |
    // |             The nearest power-of-2 integer that is not smaller than EBX[23:16] is the number of unique initial APIC   |
    // |             IDs reserved for addressing different logical processors in a physical package.                           |
    // |             This field is only valid if CPUID.1.EDX.HTT[bit 28]= 1                                                    |
    // |      23:16  Maximum number of addressable IDs for logical processors in this physical package                         |
    // |      31:24  Initial APIC ID                                                                                           |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Feature Information                                                                                             |
    // |                                                                                                                       |
    // |       Bit  Mnemonic      Description                                                                                  |
    // |        00  sse3          Prescott New Instructions-SSE3 (PNI)                                                         |
    // |        01  pclmulqdq     PCLMULQDQ                                                                                    |
    // |        02  dtes64        64-bit debug store (edx bit 21)                                                              |
    // |        03  monitor       MONITOR and MWAIT instructions                                                               |
    // |        04  ds-cpl        CPL qualified debug store                                                                    |
    // |        05  vmx           Virtual Machine eXtensions                                                                   |
    // |        06  smx           Safer Mode Extensions                                                                        |
    // |        07  est           Enhanced SpeedStep                                                                           |
    // |        08  tm2           Thermal Monitor 2                                                                            |
    // |        09  ssse3         Supplemental SSE3 instructions                                                               |
    // |        10  cnxt-id       L1 Context ID                                                                                |
    // |        11  sdbg          Silicon Debug interface                                                                      |
    // |        12  fma           Fused multiply-add (FMA3)                                                                    |
    // |        13  cx16          CMPXCHG16B instruction                                                                       |
    // |        14  xtpr          Can disable sending task priority messages                                                   |
    // |        15  pdcm          Perfmon & debug capability                                                                   |
    // |        16  ---           Reserved                                                                                     |
    // |        17  pcid          Process context identifiers (CR4 bit 17)                                                     |
    // |        18  dca           Direct cache access for DMA writes                                                           |
    // |        19  sse4.1        SSE4.1 instructions                                                                          |
    // |        20  sse4.2        SSE4.2 instructions                                                                          |
    // |        21  x2apic        x2APIC                                                                                       |
    // |        22  movbe         MOVBE instruction                                                                            |
    // |        23  popcnt        MMX instructions                                                                             |
    // |        24  tsc-deadline  APIC implements one-shot operation using a TSC deadline value                                |
    // |        25  aes           AES instruction set                                                                          |
    // |        26  xsave         XSAVE, XRESTOR, XSETBV, XGETBV                                                               |
    // |        27  osxsave       XSAVE enabled by OS                                                                          |
    // |        28  avx           Advanced Vector Extensions                                                                   |
    // |        29  f16c          F16C (half-precision) FP feature                                                             |
    // |        30  rdrnd         RDRAND (on-chip random number generator) feature                                             |
    // |        31  hypervisor    Hypervisor present (always zero on physical CPUs)                                            |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Feature Information                                                                                             |
    // |                                                                                                                       |
    // |       Bit  Mnemonic      Description                                                                                  |
    // |        00  fpu           Onboard x87 FPU                                                                              |
    // |        01  vme           Virtual 8086 mode extensions (such as VIF, VIP, PIV)                                         |
    // |        02  de            Debugging extensions (CR4 bit 3)                                                             |
    // |        03  pse           Page Size Extension                                                                          |
    // |        04  tsc           Time Stamp Counter                                                                           |
    // |        05  msr           Model-specific registers                                                                     |
    // |        06  pae           Physical Address Extension                                                                   |
    // |        07  mce           Machine Check Exception                                                                      |
    // |        08  cx8           CMPXCHG8 (compare-and-swap) instruction                                                      |
    // |        09  apic          Onboard Advanced Programmable Interrupt Controller                                           |
    // |        10  ---           Reserved                                                                                     |
    // |        11  sep           SYSENTER and SYSEXIT instructions                                                            |
    // |        12  mtrr          Memory Type Range Registers                                                                  |
    // |        13  pge           Page Global Enable bit in CR4                                                                |
    // |        14  mca           Machine check architecture                                                                   |
    // |        15  cmov          Conditional move and FCMOV instructions                                                      |
    // |        16  pat           Page Attribute Table                                                                         |
    // |        17  pse-36        36-bit page size extension                                                                   |
    // |        18  psn           Processor Serial Number                                                                      |
    // |        19  clfsh         CLFLUSH instruction (SSE2)                                                                   |
    // |        20  ---           Reserved                                                                                     |
    // |        21  ds            Debug store: save trace of executed jumps                                                    |
    // |        22  acpi          Onboard thermal control MSRs for ACPI                                                        |
    // |        23  mmx           MMX instructions                                                                             |
    // |        24  fxsr          FXSAVE, FXRESTOR instructions, CR4 bit 9                                                     |
    // |        25  sse           SSE instructions (a.k.a. Katmai New Instructions)                                            |
    // |        26  sse2          SSE2 instructions                                                                            |
    // |        27  ss            CPU cache implements self-snoop                                                              |
    // |        28  htt           Hyper-threading                                                                              |
    // |        29  tm            Thermal monitor automatically limits temperature                                             |
    // |        30  ia64          IA64 processor emulating x86                                                                 |
    // |        31  pbe           Pending Break Enable (PBE# pin) wakeup capability                                            |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Processor Info and Feature Bits</b>.
    /// </summary>
    internal sealed class Leaf00000001 : LeafBase
    {
        #region private constants

        #region register ECX definition
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE3 = Bits.Bit00;         // 00 - SSE3 extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PCLMULQDQ = Bits.Bit01;    // 01 - Instrucción PCLMULQDQ
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DTES64 = Bits.Bit02;       // 02 - DTES64
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MONITOR = Bits.Bit03;      // 03 - MONITOR/MWAIT instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DS_CPL = Bits.Bit04;       // 04 - CPL Qualified Debug Store
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits VMX = Bits.Bit05;          // 05 - Virtual Machine Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SMX = Bits.Bit06;          // 06 - Safer Mode Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits EIST = Bits.Bit07;         // 07 - Enhanced Intel SpeedStep Technology
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TM2 = Bits.Bit08;          // 08 - Thermal Monitor 2
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSSE3 = Bits.Bit09;        // 09 - SSSE3 extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CNXT_ID = Bits.Bit10;      // 10 - L1 context ID
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SDBG = Bits.Bit11;         // 11 - A value of 1 indicates the processor supports IA32_DEBUG_INTERFACE MSR for silicon debug
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FMA = Bits.Bit12;          // 12 - IA FMA
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CMPXCHG16B = Bits.Bit13;   // 13 - CMPXCHG16B instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits xTPR = Bits.Bit14;         // 14 - xTPR update control
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PDCM = Bits.Bit15;         // 15 - Perf/Debug Capability MSR
        // 16 - Reserved
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PCID = Bits.Bit17;         // 17 - Process Context Identifiers
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DCA = Bits.Bit18;          // 18 - Direct Access Cache
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE41 = Bits.Bit19;        // 19 - SSE4.1 extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE42 = Bits.Bit20;        // 20 - SSE4.2 extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits x2APIC = Bits.Bit21;       // 21 - x2APIC
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MOVBE = Bits.Bit22;        // 22 - MOVBE instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits POPCNT = Bits.Bit23;       // 23 - POPCNT instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC_Deadline = Bits.Bit24; // 24 - Time Stamp Counter Deadline
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AES = Bits.Bit25;          // 25 - IA AES Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits XSAVE = Bits.Bit26;        // 26 - XSAVE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits OSXSAVE = Bits.Bit27;      // 27 - OSXSAVE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX = Bits.Bit28;          // 30 - IA AVX
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits F16C = Bits.Bit29;         // 29 - A value of 1 indicates that processor supports 16-bit floating-point conversion instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDRAND = Bits.Bit30;       // 30 - RDRAND instruction supported
        // 31 - Not used. Always returns 0
        #endregion

        #region register EDX definition
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FPU = Bits.Bit00;    // 00 - x87 FPU support
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits VME = Bits.Bit01;    // 01 - Virtual 8086 Mode Enhancement
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DE = Bits.Bit02;     // 02 - Debugging Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PSE = Bits.Bit03;    // 03 - Page Size Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSC = Bits.Bit04;    // 04 - Time Stamp Counter
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MSR = Bits.Bit05;    // 05 - RDMSR and WRMSR
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PAE = Bits.Bit06;    // 06 - Physical Address Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MCE = Bits.Bit07;    // 07 - Machine Check Exception
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CX8 = Bits.Bit08;    // 08 - CMPXCHG8B Instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits APIC = Bits.Bit09;   // 09 - APIC on chip
        // 10 - Reserved
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SEP = Bits.Bit11;    // 11 - SYSENTER/SYSEXIT
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MTRR = Bits.Bit12;   // 12 - Memory Type Range Registers
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PGE = Bits.Bit13;    // 13 - PTE Global Bit
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MCA = Bits.Bit14;    // 14 - Machine Check Architecture
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CMOV = Bits.Bit15;   // 15 - CMOV instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PAT = Bits.Bit16;    // 16 - Page Attribute Table
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PSE_36 = Bits.Bit17; // 17 - Page Size Extension bis
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PSN = Bits.Bit18;    // 18 - Processor Serial Number
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLFSH = Bits.Bit19;  // 19 - CFLUSH instruction
        // 20 - Reserved
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DS = Bits.Bit21;   // 21 - Debug Trace Store
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ACPI = Bits.Bit22;   // 22 - Thermal Monitor and Software Controlled Clock Facilities
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MMX = Bits.Bit23;    // 23 - MMX extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FXSR = Bits.Bit24;   // 24 - FXSAVE and FXRSTOR instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE = Bits.Bit25;    // 25 - Streaming SIMD Extensions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSE2 = Bits.Bit26;   // 26 - Streaming SIMD Extensions 2
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SS = Bits.Bit27;     // 27 - Self Snoop
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HTT = Bits.Bit28;    // 28 - Multi-Threading
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TM = Bits.Bit29;     // 29 - Thermal monitor
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA64 = Bits.Bit30;   // 30 - IA-64
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PBE = Bits.Bit31;    // 31 - Pending Break Enable
        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000001(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000001"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000001(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (string) CpuSignature: Gets a value representing the 'Cpu Signature' field
        /// <summary>
        /// Gets a value representing the <b>Cpu Signature</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string CpuSignature => $"{InvokeResult.eax:X8}";
        #endregion

        #region [private] (byte) BrandIndex: Gets a value representing the 'Brand Index' field
        /// <summary>
        /// Gets a value representing the <b>Brand Index</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BrandIndex => InvokeResult.ebx.GetByte(Bytes.Byte00);
        #endregion

        #region [private] (byte) CLFLUSH_CacheLineSize: Gets a value representing the 'CLFLUSH Cache Line Size' field
        /// <summary>
        /// Gets a value representing the <b>CLFLUSH Cache Line Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CLFLUSH_CacheLineSize => InvokeResult.ebx.GetByte(Bytes.Byte01);
        #endregion

        #region [private] (byte) LocalApicId: Gets a value representing the 'Local APIC ID' field
        /// <summary>
        /// Gets a value representing the <b>Local APIC ID</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LocalApicId => InvokeResult.ebx.GetByte(Bytes.Byte03);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(CpuidPropertiesTable): Populates the property collection for this structure
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(CpuidPropertiesTable properties)
        {
            #region eax register
            
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Processor.CpuSignature, CpuSignature);

            #endregion

            #region ebx register

            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Processor.BrandIndex, BrandIndex);
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Processor.CLFLUSH_CacheLineSize, CLFLUSH_CacheLineSize);
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Processor.LocalApicId, LocalApicId);

            #endregion

            #region ecx register

            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSE3, InvokeResult.ecx.CheckBit(SSE3));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PCLMULQDQ, InvokeResult.ecx.CheckBit(PCLMULQDQ));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.DTES64, InvokeResult.ecx.CheckBit(DTES64));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MONITOR, InvokeResult.ecx.CheckBit(MONITOR));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.DS_CPL, InvokeResult.ecx.CheckBit(DS_CPL));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.VMX, InvokeResult.ecx.CheckBit(VMX));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SMX, InvokeResult.ecx.CheckBit(SMX));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.EIST, InvokeResult.ecx.CheckBit(EIST));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.TM2, InvokeResult.ecx.CheckBit(TM2));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSSE3, InvokeResult.ecx.CheckBit(SSSE3));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.CNXT_ID, InvokeResult.ecx.CheckBit(CNXT_ID));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SDBG, InvokeResult.ecx.CheckBit(SDBG));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.FMA, InvokeResult.ecx.CheckBit(FMA));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.CMPXCHG16B, InvokeResult.ecx.CheckBit(CMPXCHG16B));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.xTPR, InvokeResult.ecx.CheckBit(xTPR));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PDCM, InvokeResult.ecx.CheckBit(PDCM));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PCID, InvokeResult.ecx.CheckBit(PCID));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.DCA, InvokeResult.ecx.CheckBit(DCA));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSE41, InvokeResult.ecx.CheckBit(SSE41));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSE42, InvokeResult.ecx.CheckBit(SSE42));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.x2APIC, InvokeResult.ecx.CheckBit(x2APIC));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MOVBE, InvokeResult.ecx.CheckBit(MOVBE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.POPCNT, InvokeResult.ecx.CheckBit(POPCNT));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.TSC_Deadline, InvokeResult.ecx.CheckBit(TSC_Deadline));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.AES, InvokeResult.ecx.CheckBit(AES));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.XSAVE, InvokeResult.ecx.CheckBit(XSAVE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.OSXSAVE, InvokeResult.ecx.CheckBit(OSXSAVE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.AVX, InvokeResult.ecx.CheckBit(AVX));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.F16C, InvokeResult.ecx.CheckBit(F16C));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.RDRAND, InvokeResult.ecx.CheckBit(RDRAND));

            #endregion

            #region edx register

            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.FPU, InvokeResult.edx.CheckBit(FPU));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.VME, InvokeResult.edx.CheckBit(VME));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.DE, InvokeResult.edx.CheckBit(DE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PSE, InvokeResult.edx.CheckBit(PSE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.TSC, InvokeResult.edx.CheckBit(TSC));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MSR, InvokeResult.edx.CheckBit(MSR));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PAE, InvokeResult.edx.CheckBit(PAE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MCE, InvokeResult.edx.CheckBit(MCE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.CX8, InvokeResult.edx.CheckBit(CX8));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.APIC, InvokeResult.edx.CheckBit(APIC));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SEP, InvokeResult.edx.CheckBit(SEP));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MTRR, InvokeResult.edx.CheckBit(MTRR));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PGE, InvokeResult.edx.CheckBit(PGE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MCA, InvokeResult.edx.CheckBit(MCA));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.CMOV, InvokeResult.edx.CheckBit(CMOV));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PAT, InvokeResult.edx.CheckBit(PAT));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PSE_36, InvokeResult.edx.CheckBit(PSE_36));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PSN, InvokeResult.edx.CheckBit(PSN));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.CLFSH, InvokeResult.edx.CheckBit(CLFSH));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.DS, InvokeResult.edx.CheckBit(DS));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.ACPI, InvokeResult.edx.CheckBit(ACPI));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.MMX, InvokeResult.edx.CheckBit(MMX));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.FXSR, InvokeResult.edx.CheckBit(FXSR));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSE, InvokeResult.edx.CheckBit(SSE));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SSE2, InvokeResult.edx.CheckBit(SSE2));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.SS, InvokeResult.edx.CheckBit(SS));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.HTT, InvokeResult.edx.CheckBit(HTT));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.TM, InvokeResult.edx.CheckBit(TM));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.IA64, InvokeResult.edx.CheckBit(IA64));
            properties.Add(LeafProperty.ProcessorInfoAndFeatures.Features.PBE, InvokeResult.edx.CheckBit(PBE));
            
            #endregion
        }
        #endregion

        #endregion
    }
}
