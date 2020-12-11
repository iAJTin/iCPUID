
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000007: Structured Extended Feature Enumeration Information
    //
    // •—INPUT———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EAX = 0x00000007                                                                                                                                            |
    // | ECX = 0x00000000 (Main Leaf)                                                                                                                                |
    // |                                                                                                                                                             |
    // •—OUTPUT——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EAX = Reports the maximum input value for supported leaf 7 sub-leaves.                                                                                      |
    // |                                                                                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EBX = Information                                                                                                                                           |
    // |                                                                                                                                                             |
    // |       Bits  Value                                                                                                                                           |
    // |         00  FSGSBASE. Supports RDFSBASE/RDGSBASE/WRFSBASE/WRGSBASE if 1.                                                                                    |
    // |         01  IA32_TSC_ADJUST MSR is supported if 1.                                                                                                          |
    // |         02  SGX. Supports Intel® Software Guard Extensions (Intel® SGX Extensions) if 1.                                                                    |
    // |         03  BMI1.                                                                                                                                           |
    // |         04  HLE.                                                                                                                                            |
    // |         05  AVX2.                                                                                                                                           |
    // |         06  FDP_EXCPTN_ONLY. x87 FPU Data Pointer updated only on x87 exceptions if 1.                                                                      |
    // |         07  SMEP. Supports Supervisor-Mode Execution Prevention if 1.                                                                                       |
    // |         08  BMI2.                                                                                                                                           |
    // |         09  Supports Enhanced REP MOVSB/STOSB if 1.                                                                                                         |
    // |         10  INVPCID. If 1, supports INVPCID instruction for system software that manages process-context identifiers.                                       |
    // |         11  RTM.                                                                                                                                            |
    // |         12  RDT-M. Supports Intel® Resource Director Technology (Intel® RDT) Monitoring capability if 1.                                                    |
    // |         13  Deprecates FPU CS and FPU DS values if 1.                                                                                                       |
    // |         14  MPX. Supports Intel® Memory Protection Extensions if 1.                                                                                         |
    // |         15  RDT-A. Supports Intel® Resource Director Technology (Intel® RDT) Allocation capability if 1.                                                    |
    // |         16  AVX-512 Foundation (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                    |
    // |         17  AVX-512 Doubleword and Quadword Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                          |
    // |         18  RDSEED.                                                                                                                                         |
    // |         19  ADX.                                                                                                                                            |
    // |         20  SMAP. Supports Supervisor-Mode Access Prevention (and the CLAC/STAC instructions) if 1.                                                         |
    // |         21  AVX-512 Integer Fused Multiply-Add Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                       |
    // |         22  PCOMMIT instruction (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                   |
    // |         23  CLFLUSHOPT.                                                                                                                                     |
    // |         24  CLWB.                                                                                                                                           |
    // |         25  Intel Processor Trace.                                                                                                                          |
    // |         26  AVX-512 Prefetch Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                         |
    // |         27  AVX-512 Exponential and Reciprocal Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                       |
    // |         28  AVX-512 Conflict Detection Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                               |
    // |         29  SHA. supports Intel® Secure Hash Algorithm Extensions (Intel® SHA Extensions) if 1.                                                             |
    // |         30  AVX-512 Byte and Word Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                    |
    // |         31  AVX-512 Vector Length Extensions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                      |
    // |                                                                                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | ECX = Information                                                                                                                                           |
    // |                                                                                                                                                             |
    // |       Bits  Value                                                                                                                                           |
    // |         00  PREFETCHWT1.                                                                                                                                    |
    // |         01  AVX-512 Vector Bit Manipulation Instructions (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                          |
    // |         02  UMIP. Supports user-mode instruction prevention if 1.                                                                                           |
    // |         03  PKU. Supports protection keys for user-mode pages if 1.                                                                                         |
    // |         04  OSPKE. If 1, OS has set CR4.PKE to enable protection keys (and the RDPKRU/WRPKRU instructions).                                                 |
    // |         05  Timed pause and user-level monitor/wait. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                              |
    // |         06  AVX-512 Vector Bit Manipulation Instructions 2. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                       |
    // |         07  Control flow enforcement (CET) shadow stack. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                          |
    // |         08  Galois Field instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                            |
    // |         09  Vector AES instruction set (VEX-256/EVEX). (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                            |
    // |         10  CLMUL instruction set (VEX-256/EVEX). (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                 |
    // |         11  AVX-512 Vector Neural Network Instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                           |
    // |         12  AVX-512 BITALG instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                          |
    // |         13  Reserved                                                                                                                                        |
    // |         14  AVX-512 Vector Population Count Double and Quad-word. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                 |
    // |         15  Reserved                                                                                                                                        |
    // |         16  5-level paging. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                       |
    // |         22  RDPID. Supports Read Processor ID if 1.                                                                                                         |
    // |         23  Reserved                                                                                                                                        |
    // |         24  Reserved                                                                                                                                        |
    // |         25  Cache line demote. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                    |
    // |         26  Reserved                                                                                                                                        |
    // |         27  MOVDIRI. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                              |
    // |         28  MOVDIR64B. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                            |
    // |         29  Enqueue Stores. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                       |
    // |         30  SGX_LC. Supports SGX Launch Configuration if 1.                                                                                                 |
    // |         31  Protection keys for supervisor-mode pages. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                            |
    // |                                                                                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EDX = Information                                                                                                                                           |
    // |                                                                                                                                                             |
    // |       Bits  Value                                                                                                                                           |
    // |         00  Reserved.                                                                                                                                       |
    // |         01  Reserved.                                                                                                                                       |
    // |         02  AVX-512 4-register Neural Network Instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                       |
    // |         03  AVX-512 4-register Multiply Accumulation Single precision. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)            |
    // |         04  Fast Short REP MOVSB. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                 |
    // |         05  Reserved.                                                                                                                                       |
    // |         06  Reserved.                                                                                                                                       |
    // |         07  Reserved.                                                                                                                                       |
    // |         08  AVX-512 VP2INTERSECT Doubleword and Quadword Instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)            |
    // |         09  Special Register Buffer Data Sampling Mitigations. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                    |
    // |         10  VERW instruction clears CPU buffers. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                  |
    // |         11  Reserved.                                                                                                                                       |
    // |         12  Reserved.                                                                                                                                       |
    // |         13  tsx_force_abort. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                      |
    // |         14  Serialize instruction execution. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                      |
    // |         15  Hybrid. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                               |
    // |         16  TSX suspend load address tracking. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                    |
    // |         17  Reserved.                                                                                                                                       |
    // |         18  Platform configuration (Memory Encryption Technologies Instructions). (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management) |
    // |         19  Architectural Last Branch Records. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                    |
    // |         20  Control flow enforcement (CET) indirect branch tracking. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)              |
    // |         21  Reserved.                                                                                                                                       |
    // |         22  Tile computation on bfloat16 numbers. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                 |
    // |         23  Reserved                                                                                                                                        |
    // |         24  Tile architecture. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                    |
    // |         25  Tile computation on 8-bit integers. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                   |
    // |         26  Speculation Control, part of Indirect Branch Control (IBC): (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)           |
    // |             Indirect Branch Restricted Speculation (IBRS) and Indirect Branch Prediction Barrier (IBPB)                                                     |
    // |         27  Single Thread Indirect Branch Predictor, part of IBC. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                 |
    // |         28  IA32_FLUSH_CMD MSR. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                   |
    // |         29  Speculative Side Channel Mitigations. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                 |
    // |         30  Support for a MSR listing model-specific core capabilities. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)           |
    // |         31  Speculative Store Bypass Disable,[20] as mitigation for Speculative Store Bypass (IA32_SPEC_CTRL).                                              |
    // |             (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                                                       |
    // |                                                                                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EAX = 0x00000007                                                                                                                                            |
    // | ECX = 0x00000001                                                                                                                                            |
    // |                                                                                                                                                             |
    // •—OUTPUT——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | EAX = Information                                                                                                                                           |
    // |                                                                                                                                                             |
    // |       Bits  Value                                                                                                                                           |
    // |      04:00  Reserved.                                                                                                                                       |
    // |         05  AVX-512 BFLOAT16 instructions. (https://en.wikipedia.org/wiki/CPUID#EAX=6:_Thermal_and_power_management)                                        |
    // |      31:06  Reserved                                                                                                                                        |
    // |                                                                                                                                                             |
    // •—NOTES———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                                                             |
    // | · If ECX contains an invalid sub-leaf index, EAX/EBX/ECX/EDX return 0. Sub-leaf index n is invalid if n exceeds the value that sub-leaf 0 returns in EAX.   |
    // |                                                                                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Structured Extended Feature Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf00000007 : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_F = Bits.Bit16;            // 16 - AVX-512 Foundation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_DQ = Bits.Bit17;           // 17 - AVX-512 Doubleword and Quadword Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDSEED = Bits.Bit18;              // 18 - RDSEED
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ADX = Bits.Bit19;                 // 19 - ADX
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SMAP = Bits.Bit20;                // 20 - SMAP
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_IFMA = Bits.Bit21;         // 21 - AVX-512 Integer Fused Multiply-Add Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PCOMMIT = Bits.Bit22;             // 22 - PCOMMIT instruction
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLFLUSHOPT = Bits.Bit23;          // 23 - CLFLUSHOPT
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLWB = Bits.Bit24;                // 24 - CLWB
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IPT = Bits.Bit25;                 // 25 - Intel Processor Trace
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_PF = Bits.Bit26;           // 26 - AVX-512 Prefetch Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_ER = Bits.Bit27;           // 27 - AVX-512 Exponential and Reciprocal Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_CD = Bits.Bit28;           // 28 - AVX-512 Conflict Detection Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SHA = Bits.Bit29;                 // 29 - SHA
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_BW = Bits.Bit30;           // 30 - AVX-512 Byte and Word Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VL = Bits.Bit31;           // 31 - AVX-512 Vector Length Extensions

        #endregion

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PREFETCHWT1 = Bits.Bit00;      // 00 - PREFETCHWT1
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VBMI = Bits.Bit01;      // 01 - AVX-512 Vector Bit Manipulation Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits UMIP = Bits.Bit02;             // 02 - UMIP
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PKU = Bits.Bit03;              // 03 - PKU
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits OSPKE = Bits.Bit04;            // 04 - OSPKE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits WAITPKG = Bits.Bit05;          // 05 - Timed pause and user-level monitor/wait
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VBMI2 = Bits.Bit06;     // 06 - AVX-512 Vector Bit Manipulation Instructions 2
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CET_SS = Bits.Bit07;           // 07 - Control flow enforcement (CET) shadow stack
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits GFNI = Bits.Bit08;             // 08 - Galois Field instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits VAES = Bits.Bit09;             // 09 - Vector AES instruction set (VEX-256/EVEX)
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits VPCLMULQDQ = Bits.Bit10;       // 10 - CLMUL instruction set (VEX-256/EVEX)
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VNNI = Bits.Bit11;      // 11 - AVX-512 Vector Neural Network Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_BITALG = Bits.Bit12;    // 12 - AVX-512 BITALG instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VPOPCNTDQ = Bits.Bit14; // 14 - AVX-512 Vector Population Count Double and Quad-word
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ITL_5_LEVELPG = Bits.Bit16;    // 16 - Intel 5-level paging
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits RDPID = Bits.Bit22;            // 22 - RDPID
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CLDEMOTE = Bits.Bit25;         // 25 - Cache line demote
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MOVDIRI = Bits.Bit27;          // 27 - MOVDIRI
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MOVDIR64B = Bits.Bit28;        // 28 - MOVDIR64B
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ENQCMD = Bits.Bit29;           // 29 - Enqueue Stores
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SGX_LC = Bits.Bit30;           // 30 - SGX_LC
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PKS = Bits.Bit31;              // 31 - Protection keys for supervisor-mode pages

        #endregion

        #region register EDX definition
         
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_4VNNIW = Bits.Bit02;          // 02 - AVX-512 4-register Neural Network Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_4FMAPS = Bits.Bit03;          // 03 - AVX-512 4-register Multiply Accumulation Single precision
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FSRM = Bits.Bit04;                   // 04 - Fast Short REP MOVSB
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_VP2INTERSECT = Bits.Bit08;    // 08 - AVX-512 VP2INTERSECT Doubleword and Quadword Instructions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SRBDS_CTRL = Bits.Bit09;             // 09 - Special Register Buffer Data Sampling Mitigations
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MD_CLEAR = Bits.Bit10;               // 10 - VERW instruction clears CPU buffers
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSX_FORCE_ABORT = Bits.Bit13;        // 13 - TSX_FORCE_ABORT
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SERIALIZE = Bits.Bit14;              // 14 - SERIALIZE
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HYBRID = Bits.Bit15;                 // 15 - Hybrid
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits TSXLDTRK = Bits.Bit16;               // 16 - TSX suspend load address tracking
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PCONFIG = Bits.Bit18;                // 18 - Platform configuration (Memory Encryption Technologies Instructions)
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits LBR = Bits.Bit19;                    // 19 - Architectural Last Branch Records
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CET_IBT = Bits.Bit20;                // 20 - Control flow enforcement (CET) indirect branch tracking
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AMX_BF16 = Bits.Bit22;               // 22 - Tile computation on bfloat16 numbers
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AMX_TILE = Bits.Bit24;               // 24 - Tile architecture
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AMX_INT8 = Bits.Bit25;               // 25 - Tile computation on 8-bit integers
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IBRS_IBPB = Bits.Bit26;              // 26 - Speculation Control, part of Indirect Branch Control (IBC)
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits STIBP = Bits.Bit27;                  // 27 - Single Thread Indirect Branch Predictor, part of IBC
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits L1D_FLUSH = Bits.Bit28;              // 28 - IA32_FLUSH_CMD MSR
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_ARCH_CAPABILITIES = Bits.Bit29; // 29 - Speculative Side Channel Mitigations
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits IA32_CORE_CAPABILITIES = Bits.Bit30; // 30 - Support for a MSR listing model-specific core capabilities
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SSBD = Bits.Bit31;                   // 31 - Speculative Store Bypass Disable

        #endregion

        #endregion

        #region SubLeaf: One

        #region register EAX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits AVX512_BF16 = Bits.Bit05; // 05 - AVX-512 BFLOAT16 instructions

        #endregion

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
            switch (SubLeaf)
            {
                case SubLeaf.Main:

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
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_F, InvokeResult.ebx.CheckBit(AVX512_F));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_DQ, InvokeResult.ebx.CheckBit(AVX512_DQ));
                    properties.Add(LeafProperty.ExtendedFeatures.RDSEED, InvokeResult.ebx.CheckBit(RDSEED));
                    properties.Add(LeafProperty.ExtendedFeatures.ADX, InvokeResult.ebx.CheckBit(ADX));
                    properties.Add(LeafProperty.ExtendedFeatures.SMAP, InvokeResult.ebx.CheckBit(SMAP));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_IFMA, InvokeResult.ebx.CheckBit(AVX512_IFMA));
                    properties.Add(LeafProperty.ExtendedFeatures.PCOMMIT, InvokeResult.ebx.CheckBit(PCOMMIT));
                    properties.Add(LeafProperty.ExtendedFeatures.CLFLUSHOPT, InvokeResult.ebx.CheckBit(CLFLUSHOPT));
                    properties.Add(LeafProperty.ExtendedFeatures.CLWB, InvokeResult.ebx.CheckBit(CLWB));
                    properties.Add(LeafProperty.ExtendedFeatures.IPT, InvokeResult.ebx.CheckBit(IPT));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_PF, InvokeResult.ebx.CheckBit(AVX512_PF));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_ER, InvokeResult.ebx.CheckBit(AVX512_ER));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_CD, InvokeResult.ebx.CheckBit(AVX512_CD));
                    properties.Add(LeafProperty.ExtendedFeatures.SHA, InvokeResult.ebx.CheckBit(SHA));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_BW, InvokeResult.ebx.CheckBit(AVX512_BW));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VL, InvokeResult.ebx.CheckBit(AVX512_VL));

                    #endregion

                    #region ecx register

                    properties.Add(LeafProperty.ExtendedFeatures.PREFETCHWT1, InvokeResult.ecx.CheckBit(PREFETCHWT1));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VBMI, InvokeResult.ecx.CheckBit(AVX512_VBMI));
                    properties.Add(LeafProperty.ExtendedFeatures.UMIP, InvokeResult.ecx.CheckBit(UMIP));
                    properties.Add(LeafProperty.ExtendedFeatures.PKU, InvokeResult.ecx.CheckBit(PKU));
                    properties.Add(LeafProperty.ExtendedFeatures.OSPKE, InvokeResult.ecx.CheckBit(OSPKE));
                    properties.Add(LeafProperty.ExtendedFeatures.WAITPKG, InvokeResult.ecx.CheckBit(WAITPKG));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VBMI2, InvokeResult.ecx.CheckBit(AVX512_VBMI2));
                    properties.Add(LeafProperty.ExtendedFeatures.CET_SS, InvokeResult.ecx.CheckBit(CET_SS));
                    properties.Add(LeafProperty.ExtendedFeatures.GFNI, InvokeResult.ecx.CheckBit(GFNI));
                    properties.Add(LeafProperty.ExtendedFeatures.VAES, InvokeResult.ecx.CheckBit(VAES));
                    properties.Add(LeafProperty.ExtendedFeatures.VPCLMULQDQ, InvokeResult.ecx.CheckBit(VPCLMULQDQ));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VNNI, InvokeResult.ecx.CheckBit(AVX512_VNNI));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_BITALG, InvokeResult.ecx.CheckBit(AVX512_BITALG));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VPOPCNTDQ, InvokeResult.ecx.CheckBit(AVX512_VPOPCNTDQ));
                    properties.Add(LeafProperty.ExtendedFeatures.ITL_5_LEVELPG, InvokeResult.ecx.CheckBit(ITL_5_LEVELPG));
                    properties.Add(LeafProperty.ExtendedFeatures.RDPID, InvokeResult.ecx.CheckBit(RDPID));
                    properties.Add(LeafProperty.ExtendedFeatures.CLDEMOTE, InvokeResult.ecx.CheckBit(CLDEMOTE));
                    properties.Add(LeafProperty.ExtendedFeatures.MOVDIRI, InvokeResult.ecx.CheckBit(MOVDIRI));
                    properties.Add(LeafProperty.ExtendedFeatures.MOVDIR64B, InvokeResult.ecx.CheckBit(MOVDIR64B));
                    properties.Add(LeafProperty.ExtendedFeatures.ENQCMD, InvokeResult.ecx.CheckBit(ENQCMD));
                    properties.Add(LeafProperty.ExtendedFeatures.SGX_LC, InvokeResult.ecx.CheckBit(SGX_LC));
                    properties.Add(LeafProperty.ExtendedFeatures.PKS, InvokeResult.ecx.CheckBit(PKS));

                    #endregion

                    #region edx register

                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_4VNNIW, InvokeResult.ecx.CheckBit(AVX512_4VNNIW));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_4FMAPS, InvokeResult.ecx.CheckBit(AVX512_4FMAPS));
                    properties.Add(LeafProperty.ExtendedFeatures.FSRM, InvokeResult.ecx.CheckBit(FSRM));
                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_VP2INTERSECT, InvokeResult.ecx.CheckBit(AVX512_VP2INTERSECT));
                    properties.Add(LeafProperty.ExtendedFeatures.SRBDS_CTRL, InvokeResult.ecx.CheckBit(SRBDS_CTRL));
                    properties.Add(LeafProperty.ExtendedFeatures.MD_CLEAR, InvokeResult.ecx.CheckBit(MD_CLEAR));
                    properties.Add(LeafProperty.ExtendedFeatures.TSX_FORCE_ABORT, InvokeResult.ecx.CheckBit(TSX_FORCE_ABORT));
                    properties.Add(LeafProperty.ExtendedFeatures.SERIALIZE, InvokeResult.ecx.CheckBit(SERIALIZE));
                    properties.Add(LeafProperty.ExtendedFeatures.HYBRID, InvokeResult.ecx.CheckBit(HYBRID));
                    properties.Add(LeafProperty.ExtendedFeatures.TSXLDTRK, InvokeResult.ecx.CheckBit(TSXLDTRK));
                    properties.Add(LeafProperty.ExtendedFeatures.PCONFIG, InvokeResult.ecx.CheckBit(PCONFIG));
                    properties.Add(LeafProperty.ExtendedFeatures.LBR, InvokeResult.ecx.CheckBit(LBR));
                    properties.Add(LeafProperty.ExtendedFeatures.CET_IBT, InvokeResult.ecx.CheckBit(CET_IBT));
                    properties.Add(LeafProperty.ExtendedFeatures.AMX_BF16, InvokeResult.ecx.CheckBit(AMX_BF16));
                    properties.Add(LeafProperty.ExtendedFeatures.AMX_TILE, InvokeResult.ecx.CheckBit(AMX_TILE));
                    properties.Add(LeafProperty.ExtendedFeatures.AMX_INT8, InvokeResult.ecx.CheckBit(AMX_INT8));
                    properties.Add(LeafProperty.ExtendedFeatures.IBRS_IBPB, InvokeResult.ecx.CheckBit(IBRS_IBPB));
                    properties.Add(LeafProperty.ExtendedFeatures.STIBP, InvokeResult.ecx.CheckBit(STIBP));
                    properties.Add(LeafProperty.ExtendedFeatures.L1D_FLUSH, InvokeResult.ecx.CheckBit(L1D_FLUSH));
                    properties.Add(LeafProperty.ExtendedFeatures.IA32_ARCH_CAPABILITIES, InvokeResult.ecx.CheckBit(IA32_ARCH_CAPABILITIES));
                    properties.Add(LeafProperty.ExtendedFeatures.IA32_CORE_CAPABILITIES, InvokeResult.ecx.CheckBit(IA32_CORE_CAPABILITIES));
                    properties.Add(LeafProperty.ExtendedFeatures.SSBD, InvokeResult.ecx.CheckBit(SSBD));

                    #endregion

                    break;

                case SubLeaf.One:
                    
                    #region eax register

                    properties.Add(LeafProperty.ExtendedFeatures.AVX512_BF16, InvokeResult.ebx.CheckBit(AVX512_BF16));

                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #endregion
    }
}
