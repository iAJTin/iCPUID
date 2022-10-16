
using System.Collections.ObjectModel;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Cpuid
{
    #region [internal] (emun) Leaf00000000Property: Defines the properties available for the leaf 00000000 [Basic CPUID Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000000 [Basic CPUID Information].
    /// </summary>
    internal enum Leaf00000000Property
    {
        [PropertyName("Highest Basic Function")]
        [PropertyDescription("The highest basic calling parameter")]
        [PropertyType(typeof(uint))]
        HighestBasicFunction,

        [PropertyName("Manufacturer")]
        [PropertyDescription("CPU's manufacturer ID string")]
        [PropertyType(typeof(string))]
        Manufacturer
    }
    #endregion

    #region [internal] (emun) Leaf00000001Property: Defines the properties available for the leaf 00000001 [Processor Info and Features]
    /// <summary>
    /// Defines the properties available for the leaf 00000001 [Processor Info and Features].
    /// </summary>
    internal enum Leaf00000001Property
    {
        #region eax register

        [PropertyName("CPU Signature")]
        [PropertyDescription("Signature of a CPU")]
        [PropertyType(typeof(string))]
        CpuSignature,

        #endregion

        #region ebx register

        [PropertyName("Brand Index")]
        [PropertyDescription("This number provides an entry into a brand string table that contains brand strings for IA-32 processors")]
        [PropertyType(typeof(string))]
        BrandIndex,

        [PropertyName("CLFLUSH Cache Line Size")]
        [PropertyDescription("the size of the cache line flushed by the CLFLUSH and CLFLUSHOPT instructions in 8-byte increments")]
        [PropertyType(typeof(byte))]
        CLFLUSH_CacheLineSize,

        [PropertyName("Local APIC ID")]
        [PropertyDescription("The initial APIC-ID is used to identify the executing logical processor")]
        [PropertyType(typeof(string))]
        LocalApicId,

        #endregion

        #region ecx register

        [PropertyName("SSE3")]
        [PropertyDescription("Streaming SIMD Extensions 3 (SSE3)")]
        [PropertyType(typeof(bool))]
        SSE3,

        [PropertyName("PCLMULQDQ")]
        [PropertyDescription("PCLMULQDQ instruction")]
        [PropertyType(typeof(bool))]
        PCLMULQDQ,

        [PropertyName("DTES64")]
        [PropertyDescription("DS area using 64-bit layout")]
        [PropertyType(typeof(bool))]
        DTES64,

        [PropertyName("MONITOR")]
        [PropertyDescription("DS area using 64-bit layout")]
        [PropertyType(typeof(bool))]
        MONITOR,

        [PropertyName("DS-CPL")]
        [PropertyDescription("CPL Qualified Debug Store")]
        [PropertyType(typeof(bool))]
        DS_CPL,

        [PropertyName("VMX")]
        [PropertyDescription("Virtual Machine Extensions")]
        [PropertyType(typeof(bool))]
        VMX,

        [PropertyName("SMX")]
        [PropertyDescription("Safer Mode Extensions")]
        [PropertyType(typeof(bool))]
        SMX,

        [PropertyName("EIST")]
        [PropertyDescription("Enhanced Intel SpeedStep® technology")]
        [PropertyType(typeof(bool))]
        EIST,

        [PropertyName("TM2")]
        [PropertyDescription("Thermal Monitor 2")]
        [PropertyType(typeof(bool))]
        TM2,

        [PropertyName("SSSE3")]
        [PropertyDescription("Supplemental Streaming SIMD Extensions 3 (SSSE3)")]
        [PropertyType(typeof(bool))]
        SSSE3,

        [PropertyName("CNXT-ID")]
        [PropertyDescription("L1 Context ID")]
        [PropertyType(typeof(bool))]
        CNXT_ID,

        [PropertyName("SDBG")]
        [PropertyDescription("Indicates the processor supports IA32_DEBUG_INTERFACE MSR for silicon debug")]
        [PropertyType(typeof(bool))]
        SDBG,

        [PropertyName("FMA")]
        [PropertyDescription("Indicates the processor supports FMA extensions using YMM state")]
        [PropertyType(typeof(bool))]
        FMA,

        [PropertyName("CMPXCHG16B")]
        [PropertyDescription("CMPXCHG16B Instruction Available")]
        [PropertyType(typeof(bool))]
        CMPXCHG16B,

        [PropertyName("xTPR")]
        [PropertyDescription("Indicates the processor supports changing IA32_MISC_ENABLE")]
        [PropertyType(typeof(bool))]
        xTPR,

        [PropertyName("PDCM")]
        [PropertyDescription("Perfmon and Debug Capability")]
        [PropertyType(typeof(bool))]
        PDCM,

        [PropertyName("PCID")]
        [PropertyDescription("Process-context identifiers")]
        [PropertyType(typeof(bool))]
        PCID,

        [PropertyName("DCA")]
        [PropertyDescription("Direct cache access for DMA writes")]
        [PropertyType(typeof(bool))]
        DCA,

        [PropertyName("SSE41")]
        [PropertyDescription("SSE4.1 instructions")]
        [PropertyType(typeof(bool))]
        SSE41,

        [PropertyName("SSE42")]
        [PropertyDescription("SSE4.2 instructions")]
        [PropertyType(typeof(bool))]
        SSE42,

        [PropertyName("x2APIC")]
        [PropertyDescription("x2APIC feature")]
        [PropertyType(typeof(bool))]
        x2APIC,

        [PropertyName("MOVBE")]
        [PropertyDescription("MOVBE instruction")]
        [PropertyType(typeof(bool))]
        MOVBE,

        [PropertyName("POPCNT")]
        [PropertyDescription("POPCNT instruction")]
        [PropertyType(typeof(bool))]
        POPCNT,

        [PropertyName("TSC-Deadline")]
        [PropertyDescription("APIC implements one-shot operation using a TSC deadline value")]
        [PropertyType(typeof(bool))]
        TSC_Deadline,

        [PropertyName("AES")]
        [PropertyDescription("AES instruction set")]
        [PropertyType(typeof(bool))]
        AES,

        [PropertyName("XSAVE")]
        [PropertyDescription("XSAVE, XRESTOR, XSETBV, XGETBV")]
        [PropertyType(typeof(bool))]
        XSAVE,

        [PropertyName("OSXSAVE")]
        [PropertyDescription("XSAVE enabled by OS")]
        [PropertyType(typeof(bool))]
        OSXSAVE,

        [PropertyName("AVX")]
        [PropertyDescription("Advanced Vector Extensions")]
        [PropertyType(typeof(bool))]
        AVX,

        [PropertyName("F16C")]
        [PropertyDescription("16-bit floating-point conversion instructions")]
        [PropertyType(typeof(bool))]
        F16C,

        [PropertyName("RDRAND")]
        [PropertyDescription("On-chip random number generator feature")]
        [PropertyType(typeof(bool))]
        RDRAND,

        [PropertyName("HYPERVISOR")]
        [PropertyDescription("Hypervisor present")]
        [PropertyType(typeof(bool))]
        HYPERVISOR,
        #endregion

        #region edx register

        [PropertyName("FPU")]
        [PropertyDescription("Floating Point Unit On-Chip")]
        [PropertyType(typeof(bool))]
        FPU,

        [PropertyName("VME")]
        [PropertyDescription("Virtual 8086 Mode Enhancements")]
        [PropertyType(typeof(bool))]
        VME,

        [PropertyName("DE")]
        [PropertyDescription("Debugging Extensions")]
        [PropertyType(typeof(bool))]
        DE,

        [PropertyName("PSE")]
        [PropertyDescription("Page Size Extension")]
        [PropertyType(typeof(bool))]
        PSE,

        [PropertyName("TSC")]
        [PropertyDescription("Time Stamp Counter")]
        [PropertyType(typeof(bool))]
        TSC,

        [PropertyName("MSR")]
        [PropertyDescription("Model Specific Registers RDMSR and WRMSR Instructions")]
        [PropertyType(typeof(bool))]
        MSR,

        [PropertyName("PAE")]
        [PropertyDescription("Physical Address Extension")]
        [PropertyType(typeof(bool))]
        PAE,

        [PropertyName("MCE")]
        [PropertyDescription("Machine Check Exception")]
        [PropertyType(typeof(bool))]
        MCE,

        [PropertyName("CX8")]
        [PropertyDescription("CMPXCHG8B Instruction")]
        [PropertyType(typeof(bool))]
        CX8,

        [PropertyName("APIC")]
        [PropertyDescription("APIC On-Chip")]
        [PropertyType(typeof(bool))]
        APIC,

        [PropertyName("SEP")]
        [PropertyDescription("SYSENTER and SYSEXIT Instructions")]
        [PropertyType(typeof(bool))]
        SEP,

        [PropertyName("MTRR")]
        [PropertyDescription("Memory Type Range Registers")]
        [PropertyType(typeof(bool))]
        MTRR,

        [PropertyName("PGE")]
        [PropertyDescription("Page Global Bit")]
        [PropertyType(typeof(bool))]
        PGE,

        [PropertyName("MCA")]
        [PropertyDescription("Machine Check Architecture")]
        [PropertyType(typeof(bool))]
        MCA,

        [PropertyName("CMOV")]
        [PropertyDescription("Conditional Move Instructions")]
        [PropertyType(typeof(bool))]
        CMOV,

        [PropertyName("PAT")]
        [PropertyDescription("Page Attribute Table")]
        [PropertyType(typeof(bool))]
        PAT,

        [PropertyName("PSE_36")]
        [PropertyDescription("36-Bit Page Size Extension")]
        [PropertyType(typeof(bool))]
        PSE_36,

        [PropertyName("PSN")]
        [PropertyDescription("Processor Serial Number")]
        [PropertyType(typeof(bool))]
        PSN,

        [PropertyName("CLFSH")]
        [PropertyDescription("CLFLUSH Instruction")]
        [PropertyType(typeof(bool))]
        CLFSH,

        [PropertyName("DS")]
        [PropertyDescription("Debug Store")]
        [PropertyType(typeof(bool))]
        DS,

        [PropertyName("ACPI")]
        [PropertyDescription("Thermal Monitor and Software Controlled Clock Facilities")]
        [PropertyType(typeof(bool))]
        ACPI,

        [PropertyName("MMX")]
        [PropertyDescription("Intel MMX Technology")]
        [PropertyType(typeof(bool))]
        MMX,

        [PropertyName("FXSR")]
        [PropertyDescription("FXSAVE and FXRSTOR Instructions")]
        [PropertyType(typeof(bool))]
        FXSR,

        [PropertyName("SSE")]
        [PropertyDescription("SSE Instructions")]
        [PropertyType(typeof(bool))]
        SSE,

        [PropertyName("SSE2")]
        [PropertyDescription("SSE2 Instructions")]
        [PropertyType(typeof(bool))]
        SSE2,

        [PropertyName("SS")]
        [PropertyDescription("Self Snoop")]
        [PropertyType(typeof(bool))]
        SS,

        [PropertyName("HTT")]
        [PropertyDescription("Max APIC IDs reserved field is Valid")]
        [PropertyType(typeof(bool))]
        HTT,

        [PropertyName("TM")]
        [PropertyDescription("Thermal Monitor")]
        [PropertyType(typeof(bool))]
        TM,

        [PropertyName("IA64")]
        [PropertyDescription("IA64 processor emulating x86")]
        [PropertyType(typeof(bool))]
        IA64,

        [PropertyName("PBE")]
        [PropertyDescription("Pending Break Enable")]
        [PropertyType(typeof(bool))]
        PBE,

        #endregion
    }
    #endregion

    #region [internal] (emun) Leaf00000002Property: Defines the properties available for the leaf 00000002 [Cache and TLB Descriptor information]
    /// <summary>
    /// Defines the properties available for the leaf 00000002 [Cache and TLB Descriptor information].
    /// </summary>
    internal enum Leaf00000002Property
    {
        [PropertyName("Cache Descriptions")]
        [PropertyDescription("Cache Descriptions")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        CacheDescriptions,
    }
    #endregion

    #region [internal] (emun) Leaf00000003Property: Defines the properties available for the leaf 00000003 [Processor Serial Number]
    /// <summary>
    /// Defines the properties available for the leaf 00000003 [Processor Serial Number].
    /// </summary>
    internal enum Leaf00000003Property
    {
        [PropertyName("Serial Number")]
        [PropertyDescription("Serial Number")]
        [PropertyType(typeof(string))]
        SerialNumber,
    }
    #endregion

    #region [internal] (emun) Leaf00000004Property: Defines the properties available for the leaf 00000004 [Deterministic Cache Parameters]
    /// <summary>
    /// Defines the properties available for the leaf 00000004 [Deterministic Cache Parameters].
    /// </summary>
    internal enum Leaf00000004Property
    {
        [PropertyName("Cache Type")]
        [PropertyDescription("Cache Type")]
        [PropertyType(typeof(string))]
        CacheType,

        [PropertyName("Cache Level")]
        [PropertyDescription("Cache Level")]
        [PropertyType(typeof(byte))]
        CacheLevel,

        [PropertyName("Self Initializing cache level")]
        [PropertyDescription("Self Initializing cache level (does not need SW initialization)")]
        [PropertyType(typeof(bool))]
        IsSelfInitializingCacheLevel,

        [PropertyName("Fully Associative cache")]
        [PropertyDescription("Fully Associative Cache")]
        [PropertyType(typeof(bool))]
        IsFullyAssociativeCache,

        [PropertyName("Maximum Number Addressable Logical Processors")]
        [PropertyDescription("Maximum number of addressable IDs for logical processors sharing this cache")]
        [PropertyType(typeof(byte))]
        MaximumLogicalProcessorCores,

        [PropertyName("Maximum Number Addressable Processor Cores Physical")]
        [PropertyDescription("Maximum number of addressable IDs for processor cores in the physical package")]
        [PropertyType(typeof(byte))]
        MaximumPhysicalProcessorCores,

        [PropertyName("Cache Size")]
        [PropertyDescription("Cache Size in Bytes")]
        [PropertyType(typeof(uint))]
        CacheSize,

        [PropertyName("Write Back")]
        [PropertyDescription("Write-Back Invalidate")]
        [PropertyType(typeof(bool))]
        WriteBack,

        [PropertyName("Cache Inclusiveness")]
        [PropertyDescription("Cache is inclusive of lower cache levels")]
        [PropertyType(typeof(bool))]
        IsCacheInclusiveOfLowerLevels,

        [PropertyName("Use Direct Mapped Cache")]
        [PropertyDescription("Use Direct Mapped Cache or use a complex function is used to index the cache")]
        [PropertyType(typeof(bool))]
        UseDirectMappedCache,
    }
    #endregion

    #region [internal] (emun) Leaf00000005Property: Defines the properties available for the leaf 00000005 [MONITOR-MWAIT]
    /// <summary>
    /// Defines the properties available for the leaf 00000005 [MONITOR-MWAIT].
    /// </summary>
    internal enum Leaf00000005Property
    {
        [PropertyName("C0 Extension")]
        [PropertyDescription("Number of C0 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C0,

        [PropertyName("C1 Extension")]
        [PropertyDescription("Number of C1 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C1,

        [PropertyName("C2 Extension")]
        [PropertyDescription("Number of C2 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C2,

        [PropertyName("C3 Extension")]
        [PropertyDescription("Number of C3 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C3,

        [PropertyName("C4 Extension")]
        [PropertyDescription("Number of C4 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C4,

        [PropertyName("C5 Extension")]
        [PropertyDescription("Number of C5 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C5,

        [PropertyName("C6 Extension")]
        [PropertyDescription("Number of C6 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C6,

        [PropertyName("C7 Extension")]
        [PropertyDescription("Number of C7 sub C-states supported using MWAIT")]
        [PropertyType(typeof(byte))]
        C7,

        [PropertyName("Smallest Monitor Line Size")]
        [PropertyDescription("Smallest monitor-line size in bytes")]
        [PropertyType(typeof(uint))]
        SmallestMonitorLineSize,

        [PropertyName("Largest Monitor Line Size")]
        [PropertyDescription("Largest monitor-line size in bytes")]
        [PropertyType(typeof(uint))]
        LargestMonitorLineSize,

        [PropertyName("MWAIT Supports Treating Interrupts")]
        [PropertyDescription("Supports treating interrupts as break-event for MWAIT, even when interrupts disabled")]
        [PropertyType(typeof(bool))]
        MwaitSupportsTreatingInterrupts,
    }
    #endregion

    #region [internal] (emun) Leaf00000006Property: Defines the properties available for the leaf 00000006 [Thermal and Power Management]
    /// <summary>
    /// Defines the properties available for the leaf 00000006 [Thermal and Power Management].
    /// </summary>
    internal enum Leaf00000006Property
    {
        [PropertyName("Digital temperature sensor")]
        [PropertyDescription("Digital temperature sensor")]
        [PropertyType(typeof(bool))]
        DigitalTemperatureSensor,

        [PropertyName("Intel Turbo Boost")]
        [PropertyDescription("Intel Turbo Boost Technology Available")]
        [PropertyType(typeof(bool))]
        IntelTurboBoost,

        [PropertyName("ARAT")]
        [PropertyDescription("APIC-Timer-always-running feature")]
        [PropertyType(typeof(bool))]
        ARAT,

        [PropertyName("PLN")]
        [PropertyDescription("Power limit notification controls")]
        [PropertyType(typeof(bool))]
        PLN,

        [PropertyName("ECMD")]
        [PropertyDescription("Clock modulation duty cycle extension")]
        [PropertyType(typeof(bool))]
        ECMD,

        [PropertyName("PTM")]
        [PropertyDescription("Package thermal management")]
        [PropertyType(typeof(bool))]
        PTM,

        [PropertyName("HWP")]
        [PropertyDescription("HWP base registers")]
        [PropertyType(typeof(bool))]
        HWP,

        [PropertyName("HWP Notification")]
        [PropertyDescription("IA32_HWP_INTERRUPT MSR")]
        [PropertyType(typeof(bool))]
        HWP_Notification,

        [PropertyName("HWP Activity Window")]
        [PropertyDescription("IA32_HWP_REQUEST[bits 41:32]")]
        [PropertyType(typeof(bool))]
        HWP_Activity_Window,

        [PropertyName("HWP Energy Performance Preference")]
        [PropertyDescription("IA32_HWP_REQUEST[bits 31:24]")]
        [PropertyType(typeof(bool))]
        HWP_Energy_Performance_Preference,

        [PropertyName("HWP Package Level Request")]
        [PropertyDescription("IA32_HWP_REQUEST_PKG MSR")]
        [PropertyType(typeof(bool))]
        HWP_Package_Level_Request,

        [PropertyName("HDC")]
        [PropertyDescription("HDC base registers IA32_PKG_HDC_CTL, IA32_PM_CTL1, IA32_THREAD_STALL MSRs")]
        [PropertyType(typeof(bool))]
        HDC,

        [PropertyName("Number of Interrupt Thresholds in Digital Thermal Sensor")]
        [PropertyDescription("Number of Interrupt Thresholds in Digital Thermal Sensor")]
        [PropertyType(typeof(uint))]
        InterruptNumber,

        [PropertyName("Hardware Coordination Feedback Capability")]
        [PropertyDescription("The capability to provide a measure of delivered processor performance")]
        [PropertyType(typeof(bool))]
        HardwareCoordinationCapability,

        [PropertyName("Performance-energy bias preference")]
        [PropertyDescription("The processor supports performance-energy bias preference and also implies the presence of a new architectural MSR")]
        [PropertyType(typeof(bool))]
        PerformanceEnergyPreference,
    }
    #endregion

    #region [internal] (emun) Leaf00000007Property: Defines the properties available for the leaf 00000007 [Structured Extended Feature Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000007 [Structured Extended Feature Enumeration Information].
    /// </summary>
    internal enum Leaf00000007Property
    {
        #region SubLeaf: Main

        #region ebx register

        [PropertyName("FSGSBASE")]
        [PropertyDescription("FSGSBASE")]
        [PropertyType(typeof(bool))]
        FSGSBASE,

        [PropertyName("IA32_TSC_ADJUST_MSR")]
        [PropertyDescription("IA32_TSC_ADJUST_MSR")]
        [PropertyType(typeof(bool))]
        IA32_TSC_ADJUST_MSR,

        [PropertyName("SGX")]
        [PropertyDescription("Software Protection Extensions")]
        [PropertyType(typeof(bool))]
        SGX,

        [PropertyName("BMI1")]
        [PropertyDescription("Bit manipulation instruction set 1")]
        [PropertyType(typeof(bool))]
        BMI1,

        [PropertyName("HLE")]
        [PropertyDescription("TSX hardware lock bypass")]
        [PropertyType(typeof(bool))]
        HLE,

        [PropertyName("AVX2")]
        [PropertyDescription("Advanced Vector Extensions 2")]
        [PropertyType(typeof(bool))]
        AVX2,

        [PropertyName("FDP_EXCPTN_ONLY")]
        [PropertyDescription("FDP_EXCPTN_ONLY")]
        [PropertyType(typeof(bool))]
        FDP_EXCPTN_ONLY,

        [PropertyName("SMEP")]
        [PropertyDescription("Supervisor Mode Execution Prevention")]
        [PropertyType(typeof(bool))]
        SMEP,

        [PropertyName("BMI2")]
        [PropertyDescription("Bit manipulation instruction set 2")]
        [PropertyType(typeof(bool))]
        BMI2,

        [PropertyName("ERMS")]
        [PropertyDescription("Enhanced REP MOVSB/STOSB")]
        [PropertyType(typeof(bool))]
        ERMS,

        [PropertyName("INVPCID")]
        [PropertyDescription("INVPCID Instruction")]
        [PropertyType(typeof(bool))]
        INVPCID,

        [PropertyName("RTM")]
        [PropertyDescription("TSX Restricted Transactional Memory")]
        [PropertyType(typeof(bool))]
        RTM,

        [PropertyName("RDT-M")]
        [PropertyDescription("Platform Quality of Service Monitoring")]
        [PropertyType(typeof(bool))]
        RDT_M,

        [PropertyName("Deprecates FPU")]
        [PropertyDescription("Deprecates FPU CS and FPU DS")]
        [PropertyType(typeof(bool))]
        Deprecates_FPU,

        [PropertyName("MPX")]
        [PropertyDescription("Intel MPX (Memory Protection Extensions)")]
        [PropertyType(typeof(bool))]
        MPX,

        [PropertyName("RDT-A")]
        [PropertyDescription("Platform Quality of Service Enforcement")]
        [PropertyType(typeof(bool))]
        RDT_A,

        [PropertyName("AVX512_F")]
        [PropertyDescription("AVX-512 Foundation")]
        [PropertyType(typeof(bool))]
        AVX512_F,

        [PropertyName("AVX512_DQ")]
        [PropertyDescription("AVX-512 Doubleword and Quadword Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_DQ,

        [PropertyName("RDSEED")]
        [PropertyDescription("RDSEED Instruction")]
        [PropertyType(typeof(bool))]
        RDSEED,

        [PropertyName("ADX")]
        [PropertyDescription("Intel ADX (Multi-Precision Add-Carry Instruction Extensions)")]
        [PropertyType(typeof(bool))]
        ADX,

        [PropertyName("SMAP")]
        [PropertyDescription("Supervisor Mode Access Prevention")]
        [PropertyType(typeof(bool))]
        SMAP,

        [PropertyName("AVX512_IFMA")]
        [PropertyDescription("AVX-512 Integer Fused Multiply-Add Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_IFMA,

        [PropertyName("PCOMMIT")]
        [PropertyDescription("PCOMMIT instruction")]
        [PropertyType(typeof(bool))]
        PCOMMIT,

        [PropertyName("CLFLUSHOPT")]
        [PropertyDescription("CLFLUSHOPT Instruction")]
        [PropertyType(typeof(bool))]
        CLFLUSHOPT,

        [PropertyName("CLWB")]
        [PropertyDescription("CLWB Instruction")]
        [PropertyType(typeof(bool))]
        CLWB,

        [PropertyName("INTEL-PT")]
        [PropertyDescription("Intel Processor Trace")]
        [PropertyType(typeof(bool))]
        IPT,

        [PropertyName("AVX512_PF")]
        [PropertyDescription("AVX-512 Prefetch Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_PF,

        [PropertyName("AVX512_ER")]
        [PropertyDescription("AVX-512 Exponential and Reciprocal Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_ER,

        [PropertyName("AVX512_CD")]
        [PropertyDescription("AVX-512 Conflict Detection Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_CD,

        [PropertyName("SHA")]
        [PropertyDescription("Intel SHA extensions")]
        [PropertyType(typeof(bool))]
        SHA,

        [PropertyName("AVX512_BW")]
        [PropertyDescription("AVX-512 Byte and Word Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_BW,

        [PropertyName("AVX512_VL")]
        [PropertyDescription("AVX-512 Vector Length Extensions")]
        [PropertyType(typeof(bool))]
        AVX512_VL,

        #endregion

        #region ecx register

        [PropertyName("PREFETCHWT1")]
        [PropertyDescription("PREFETCHWT1 Instruction")]
        [PropertyType(typeof(bool))]
        PREFETCHWT1,

        [PropertyName("AVX512_VBMI")]
        [PropertyDescription("AVX-512 Vector Bit Manipulation Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_VBMI,

        [PropertyName("UMIP")]
        [PropertyDescription("User-mode Instruction Prevention")]
        [PropertyType(typeof(bool))]
        UMIP,

        [PropertyName("PKU")]
        [PropertyDescription("Memory Protection Keys for User-mode pages")]
        [PropertyType(typeof(bool))]
        PKU,

        [PropertyName("OSPKE")]
        [PropertyDescription("PKU enabled by OS")]
        [PropertyType(typeof(bool))]
        OSPKE,

        [PropertyName("WAITPKG")]
        [PropertyDescription("Timed pause and user-level monitor/wait")]
        [PropertyType(typeof(bool))]
        WAITPKG,

        [PropertyName("AVX512_VBMI2")]
        [PropertyDescription("AVX-512 Vector Bit Manipulation Instructions 2")]
        [PropertyType(typeof(bool))]
        AVX512_VBMI2,

        [PropertyName("CET_SS")]
        [PropertyDescription("Control flow enforcement (CET) shadow stack")]
        [PropertyType(typeof(bool))]
        CET_SS,

        [PropertyName("GFNI")]
        [PropertyDescription("Galois Field instructions")]
        [PropertyType(typeof(bool))]
        GFNI,

        [PropertyName("VAES")]
        [PropertyDescription("Vector AES instruction set (VEX-256/EVEX)")]
        [PropertyType(typeof(bool))]
        VAES,

        [PropertyName("VPCLMULQDQ")]
        [PropertyDescription("CLMUL instruction set (VEX-256/EVEX)")]
        [PropertyType(typeof(bool))]
        VPCLMULQDQ,

        [PropertyName("AVX512_VNNI")]
        [PropertyDescription("AVX-512 Vector Neural Network Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_VNNI,

        [PropertyName("AVX512_BITALG")]
        [PropertyDescription("AVX-512 BITALG instructions")]
        [PropertyType(typeof(bool))]
        AVX512_BITALG,

        [PropertyName("AVX512_VPOPCNTDQ")]
        [PropertyDescription("AVX-512 Vector Population Count Double and Quad-word")]
        [PropertyType(typeof(bool))]
        AVX512_VPOPCNTDQ,

        [PropertyName("ITL_5_LEVELPG")]
        [PropertyDescription("Intel 5-level paging")]
        [PropertyType(typeof(bool))]
        ITL_5_LEVELPG,

        [PropertyName("RDPID")]
        [PropertyDescription("Read Processor ID and IA32_TSC_AUX")]
        [PropertyType(typeof(bool))]
        RDPID,

        [PropertyName("CLDEMOTE")]
        [PropertyDescription("Cache line demote")]
        [PropertyType(typeof(bool))]
        CLDEMOTE,

        [PropertyName("MOVDIRI")]
        [PropertyDescription("MOVDIRI")]
        [PropertyType(typeof(bool))]
        MOVDIRI,

        [PropertyName("MOVDIR64B")]
        [PropertyDescription("MOVDIR64B")]
        [PropertyType(typeof(bool))]
        MOVDIR64B,

        [PropertyName("ENQCMD")]
        [PropertyDescription("Enqueue Stores")]
        [PropertyType(typeof(bool))]
        ENQCMD,

        [PropertyName("SGX-LC")]
        [PropertyDescription("SGX Launch Configuration")]
        [PropertyType(typeof(bool))]
        SGX_LC,

        [PropertyName("PKS")]
        [PropertyDescription("Protection keys for supervisor-mode pages")]
        [PropertyType(typeof(bool))]
        PKS,

        #endregion

        #region edx register

        [PropertyName("AVX512_4VNNIW")]
        [PropertyDescription("AVX-512 4-register Neural Network Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_4VNNIW,

        [PropertyName("AVX512_4FMAPS")]
        [PropertyDescription("AVX-512 4-register Multiply Accumulation Single precision")]
        [PropertyType(typeof(bool))]
        AVX512_4FMAPS,

        [PropertyName("FSRM")]
        [PropertyDescription("Fast Short REP MOVSB")]
        [PropertyType(typeof(bool))]
        FSRM,

        [PropertyName("AVX512_VP2INTERSECT")]
        [PropertyDescription("AVX-512 VP2INTERSECT Doubleword and Quadword Instructions")]
        [PropertyType(typeof(bool))]
        AVX512_VP2INTERSECT,

        [PropertyName("SRBDS_CTRL")]
        [PropertyDescription("Special Register Buffer Data Sampling Mitigations")]
        [PropertyType(typeof(bool))]
        SRBDS_CTRL,

        [PropertyName("MD_CLEAR")]
        [PropertyDescription("VERW instruction clears CPU buffers")]
        [PropertyType(typeof(bool))]
        MD_CLEAR,

        [PropertyName("TSX_FORCE_ABORT")]
        [PropertyDescription("TSX_FORCE_ABORT")]
        [PropertyType(typeof(bool))]
        TSX_FORCE_ABORT,

        [PropertyName("SERIALIZE")]
        [PropertyDescription("SERIALIZE")]
        [PropertyType(typeof(bool))]
        SERIALIZE,

        [PropertyName("HYBRID")]
        [PropertyDescription("HYBRID")]
        [PropertyType(typeof(bool))]
        HYBRID,

        [PropertyName("TSXLDTRK")]
        [PropertyDescription("TSX suspend load address tracking")]
        [PropertyType(typeof(bool))]
        TSXLDTRK,

        [PropertyName("PCONFIG")]
        [PropertyDescription("Platform configuration (Memory Encryption Technologies Instructions)")]
        [PropertyType(typeof(bool))]
        PCONFIG,

        [PropertyName("LBR")]
        [PropertyDescription("Architectural Last Branch Records")]
        [PropertyType(typeof(bool))]
        LBR,

        [PropertyName("CET_IBT")]
        [PropertyDescription("Control flow enforcement (CET) indirect branch tracking")]
        [PropertyType(typeof(bool))]
        CET_IBT,

        [PropertyName("AMX_BF16")]
        [PropertyDescription("Tile computation on bfloat16 numbers")]
        [PropertyType(typeof(bool))]
        AMX_BF16,

        [PropertyName("AMX_TILE")]
        [PropertyDescription("Tile architecture")]
        [PropertyType(typeof(bool))]
        AMX_TILE,

        [PropertyName("AMX_INT8")]
        [PropertyDescription("Tile computation on 8-bit integers")]
        [PropertyType(typeof(bool))]
        AMX_INT8,

        [PropertyName("IBRS_IBPB")]
        [PropertyDescription("Speculation Control, part of Indirect Branch Control (IBC)")]
        [PropertyType(typeof(bool))]
        IBRS_IBPB,

        [PropertyName("STIBP")]
        [PropertyDescription("Single Thread Indirect Branch Predictor, part of IBC")]
        [PropertyType(typeof(bool))]
        STIBP,

        [PropertyName("L1D_FLUSH")]
        [PropertyDescription("IA32_FLUSH_CMD MSR")]
        [PropertyType(typeof(bool))]
        L1D_FLUSH,

        [PropertyName("IA32_ARCH_CAPABILITIES")]
        [PropertyDescription("Speculative Side Channel Mitigations")]
        [PropertyType(typeof(bool))]
        IA32_ARCH_CAPABILITIES,

        [PropertyName("IA32_CORE_CAPABILITIES")]
        [PropertyDescription("Support for a MSR listing model-specific core capabilities")]
        [PropertyType(typeof(bool))]
        IA32_CORE_CAPABILITIES,

        [PropertyName("SSBD")]
        [PropertyDescription("Speculative Store Bypass Disable")]
        [PropertyType(typeof(bool))]
        SSBD,

        #endregion

        #endregion

        #region SubLeaf: One

        #region eax register

        [PropertyName("AVX512_BF16")]
        [PropertyDescription("AVX-512 BFLOAT16 instructions")]
        [PropertyType(typeof(bool))]
        AVX512_BF16,

        #endregion

        #endregion
    }
    #endregion

    #region [internal] (emun) Leaf00000009Property: Defines the properties available for the leaf 00000009 [Direct Cache Access Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000009 [Direct Cache Access Information].
    /// </summary>
    internal enum Leaf00000009Property
    {
        [PropertyName("IA32_PLATFORM_DCA_CAP")]
        [PropertyDescription("IA32_PLATFORM_DCA_CAP MSR")]
        [PropertyType(typeof(uint))]
        IA32_PLATFORM_DCA_CAP,
    }
    #endregion

    #region [internal] (emun) Leaf0000000AProperty: Defines the properties available for the leaf 0000000A [Architectural Performance Monitoring Features]
    /// <summary>
    /// Defines the properties available for the leaf 0000000A [Architectural Performance Monitoring Features].
    /// </summary>
    internal enum Leaf0000000AProperty
    {
        [PropertyName("VersionId")]
        [PropertyDescription("Version ID of architectural performance monitoring")]
        [PropertyType(typeof(uint))]
        VersionId,

        [PropertyName("NumberOfGeneralPurposeCounterPerLogicalProcessor")]
        [PropertyDescription("Number of general-purpose performance monitoring counter per logical processor")]
        [PropertyType(typeof(uint))]
        NumberOfGeneralPurposeCounterPerLogicalProcessor,

        [PropertyName("BitWidth")]
        [PropertyDescription("Bit width of general-purpose, performance monitoring counter")]
        [PropertyType(typeof(uint))]
        BitWidth,

        [PropertyName("LenghtBitVector")]
        [PropertyDescription("Length of EBX bit vector to enumerate architectural performance monitoring events")]
        [PropertyType(typeof(uint))]
        LenghtBitVector,

        [PropertyName("CCE")]
        [PropertyDescription("Core cycle event")]
        [PropertyType(typeof(bool))]
        CCE,

        [PropertyName("IRE")]
        [PropertyDescription("Instruction retired event")]
        [PropertyType(typeof(bool))]
        IRE,

        [PropertyName("RCE")]
        [PropertyDescription("Reference cycles event")]
        [PropertyType(typeof(bool))]
        RCE,

        [PropertyName("LLCRE")]
        [PropertyDescription("Last-level cache reference event")]
        [PropertyType(typeof(bool))]
        LLCRE,

        [PropertyName("LLCME")]
        [PropertyDescription("Last-level cache misses event")]
        [PropertyType(typeof(bool))]
        LLCME,

        [PropertyName("BIRE")]
        [PropertyDescription("Branch instruction retired event")]
        [PropertyType(typeof(bool))]
        BIRE,

        [PropertyName("BMRE")]
        [PropertyDescription("Branch mispredict retired event")]
        [PropertyType(typeof(bool))]
        BMRE,

        [PropertyName("NumberFixFunctionsCounters")]
        [PropertyDescription("Number of fixed-function performance counters")]
        [PropertyType(typeof(byte))]
        NumberFixFunctionsCounters,

        [PropertyName("BitWidthFixFunctionsCounters")]
        [PropertyDescription("Bit width of fixed-function performance counters")]
        [PropertyType(typeof(byte))]
        BitWidthFixFunctionsCounters,
    }
    #endregion

    #region [internal] (emun) Leaf0000000BProperty: Defines the properties available for the leaf 0000000B [Extended Topology Information]
    /// <summary>
    /// Defines the properties available for the leaf 0000000B [Extended Topology Information].
    /// </summary>
    internal enum Leaf0000000BProperty
    {
        [PropertyName("BitsShiftRightx2APICID")]
        [PropertyDescription("Number of bits to shift right on x2APIC ID to get a unique topology ID")]
        [PropertyType(typeof(uint))]
        BitsShiftRightx2APICID,

        [PropertyName("NumberOfLogicalProcessorsThisLevel")]
        [PropertyDescription("Number of logical processors at this level type")]
        [PropertyType(typeof(uint))]
        NumberOfLogicalProcessorsThisLevel,

        [PropertyName("LevelType")]
        [PropertyDescription("Level Type")]
        [PropertyType(typeof(string))]
        LevelType,

        [PropertyName("x2APICID")]
        [PropertyDescription("x2APIC ID")]
        [PropertyType(typeof(uint))]
        x2APICID,
    }
    #endregion
    
    #region [internal] (emun) Leaf0000000DProperty: Defines the properties available for the leaf 0000000D [Processor Extended States Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 0000000D [Processor Extended States Enumeration Information].
    /// </summary>
    internal enum Leaf0000000DProperty
    {
        [PropertyName("x87State")]
        [PropertyDescription("x87 State")]
        [PropertyType(typeof(bool))]
        x87State,

        [PropertyName("SSEState")]
        [PropertyDescription("SSE State")]
        [PropertyType(typeof(bool))]
        SSEState,

        [PropertyName("AVXState")]
        [PropertyDescription("AVX State")]
        [PropertyType(typeof(bool))]
        AVXState,

        [PropertyName("IA32_XSS")]
        [PropertyDescription("Used for IA32_XSS")]
        [PropertyType(typeof(bool))]
        IA32_XSS,

        [PropertyName("PKRUState")]
        [PropertyDescription("PKRU State")]
        [PropertyType(typeof(bool))]
        PKRUState,

        [PropertyName("MaximumSizeEnabledFeaturesXCR0")]
        [PropertyDescription("Maximum Size from the begining of the XSAVE/XRSTOR save area required by enabled features in XCR0")]
        [PropertyType(typeof(uint))]
        MaximumSizeEnabledFeaturesXCR0,

        [PropertyName("MaximumSizeXSAVE_XRSTOR")]
        [PropertyDescription("Maximum Size from the begining of the XSAVE/XRSTOR save area required by all supported features in processor")]
        [PropertyType(typeof(uint))]
        MaximumSizeAllSupportedFeatures,

        [PropertyName("UPPER32BITS_XCR0")]
        [PropertyDescription("Reports the supported bits of the upper 32 bits of XCR0. XCR0[n+32] can be set to 1 only if EDX[n] is 1")]
        [PropertyType(typeof(bool))]
        UPPER32BITS_XCR0,

        [PropertyName("XSAVEOPT")]
        [PropertyDescription("XSAVEOPT is available")]
        [PropertyType(typeof(bool))]
        XSAVEOPT,

        [PropertyName("XSAVEC")]
        [PropertyDescription("Supports XSAVEC and the compacted form of XRSTOR")]
        [PropertyType(typeof(bool))]
        XSAVEC,

        [PropertyName("XGETBV")]
        [PropertyDescription("Supports XGETBV with sub-leaf 1")]
        [PropertyType(typeof(bool))]
        XGETBV,

        [PropertyName("XSAVES_XRSTORS_IA32_XSS")]
        [PropertyDescription("Supports XSAVES/XRSTORS and IA32_XSS")]
        [PropertyType(typeof(bool))]
        XSAVES_XRSTORS_IA32_XSS,

        [PropertyName("SizeAllStatesEnabled")]
        [PropertyDescription("The size in bytes of the XSAVE area containing all states enabled by XCRO | IA32_XSS")]
        [PropertyType(typeof(uint))]
        SizeAllStatesEnabled,

        [PropertyName("Lower32Bits_IA32_XSS")]
        [PropertyDescription("Reports the supported bits of the lower 32 bits of the IA32_XSS MSR")]
        [PropertyType(typeof(uint))]
        Lower32Bits_IA32_XSS,

        [PropertyName("Upper32Bits_IA32_XSS")]
        [PropertyDescription("Reports the supported bits of the upper 32 bits of the IA32_XSS MSR")]
        [PropertyType(typeof(uint))]
        Upper32Bits_IA32_XSS,

        [PropertyName("SizeSsveAreaExtendedStateFeature")]
        [PropertyDescription("The size in bytes of the save area for an extended state feature associated with a valid sub-leaf index, n")]
        [PropertyType(typeof(uint))]
        SizeSaveAreaExtendedStateFeature,

        [PropertyName("OffsetThisExtenndedStateComponent")]
        [PropertyDescription("The offset in bytes of this extended state component’s save area from the beginning of the XSAVE/XRSTOR area")]
        [PropertyType(typeof(uint))]
        OffsetThisExtenndedStateComponent,

        [PropertyName("ThisSubLeafSuppoertedInIA32_XSR")]
        [PropertyDescription("Supports XSAVES/XRSTORS and IA32_XSS")]
        [PropertyType(typeof(bool))]
        ThisSubLeafSuppoertedInIA32_XSR,

        [PropertyName("XSAVEAREAUSED")]
        [PropertyDescription("Supports XSAVES/XRSTORS and IA32_XSS")]
        [PropertyType(typeof(bool))]
        XSAVEAREAUSED,
    }
    #endregion

    #region [internal] (emun) Leaf0000000FProperty: Defines the properties available for the leaf 0000000F [Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 0000000F [Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information].
    /// </summary>
    internal enum Leaf0000000FProperty
    {
        [PropertyName("MaximumRangeAllTypes")]
        [PropertyDescription("Maximum range (zero-based) of RMID within this physical processor of all types")]
        [PropertyType(typeof(uint))]
        MaximumRangeAllTypes,

        [PropertyName("L3CacheIntelRDT")]
        [PropertyDescription("Supports L3 Cache Intel RDT Monitoring")]
        [PropertyType(typeof(bool))]
        L3CacheIntelRDT,

        [PropertyName("ConversionFactorThis")]
        [PropertyDescription("Conversion factor from reported IA32_QM_CTR value to occupancy metric (bytes)")]
        [PropertyType(typeof(uint))]
        ConversionFactorThis,

        [PropertyName("MaximumRangeThis")]
        [PropertyDescription("Maximum range (zero-based) of RMID of this resource type")]
        [PropertyType(typeof(uint))]
        MaximumRangeThis,

        [PropertyName("L3OCC")]
        [PropertyDescription("Supports L3 occupancy monitoring")]
        [PropertyType(typeof(bool))]
        L3OCC,

        [PropertyName("L3TBRAND")]
        [PropertyDescription("Supports L3 Total Bandwidth monitoring")]
        [PropertyType(typeof(bool))]
        L3TBRAND,

        [PropertyName("L3LBRAND")]
        [PropertyDescription("Supports L3 Local Bandwidth monitoring")]
        [PropertyType(typeof(bool))]
        L3LBRAND
    }
    #endregion

    #region [internal] (emun) Leaf00000010Property: Defines the properties available for the leaf 00000010 [Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000010 [Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information].
    /// </summary>
    internal enum Leaf00000010Property
    {
        [PropertyName("L3 Cache Allocation")]
        [PropertyDescription("Supports L3 Cache Allocation Technology")]
        [PropertyType(typeof(bool))]
        L3CacheAllocation,

        [PropertyName("L2 Cache Allocation")]
        [PropertyDescription("Supports L2 Cache Allocation Technology")]
        [PropertyType(typeof(bool))]
        L2CacheAllocation,

        [PropertyName("Length Bit Mask")]
        [PropertyDescription("Length of the capacity bit mask for the corresponding ResID using minus-one notation")]
        [PropertyType(typeof(uint))]
        LengthBitMask,

        [PropertyName("Bit-granular map")]
        [PropertyDescription("Bit-granular map of isolation/contention of allocation units")]
        [PropertyType(typeof(uint))]
        BitGranularMap,

        [PropertyName("COS")]
        [PropertyDescription("Updates of COS should be infrequent")]
        [PropertyType(typeof(bool))]
        COS,

        [PropertyName("Code And Data Priorization")]
        [PropertyDescription("Code and Data Prioritization Technology ")]
        [PropertyType(typeof(bool))]
        CodeDataPriorization,

        [PropertyName("Highest COS")]
        [PropertyDescription("Highest COS number supported for this ResID")]
        [PropertyType(typeof(uint))]
        Highest_COS,
    }
    #endregion

    #region [internal] (emun) Leaf00000012Property: Defines the properties available for the leaf 00000012 [Intel SGX Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000012 [Intel SGX Enumeration Information].
    /// </summary>
    internal enum Leaf00000012Property
    {
        [PropertyName("SGX1")]
        [PropertyDescription("Indicates Intel SGX supports the collection of SGX1 leaf functions")]
        [PropertyType(typeof(bool))]
        SGX1,

        [PropertyName("SGX2")]
        [PropertyDescription("Indicates Intel SGX supports the collection of SGX2 leaf functions")]
        [PropertyType(typeof(bool))]
        SGX2,

        [PropertyName("MISCSELECT")]
        [PropertyDescription("Bit vector of supported extended SGX features")]
        [PropertyType(typeof(bool))]
        MISCSELECT,

        [PropertyName("MaxEnclaveSize64")]
        [PropertyDescription("The maximum supported enclave size in 64-bit mode")]
        [PropertyType(typeof(bool))]
        MaxEnclaveSize64,

        [PropertyName("MaxEnclaveSizeNot64")]
        [PropertyDescription("The maximum supported enclave size in non-64-bit mode")]
        [PropertyType(typeof(bool))]
        MaxEnclaveSizeNot64,

        [PropertyName("SecsAttributesAddress")]
        [PropertyDescription("Reports the valid bits of SECS.ATTRIBUTES address (128 bits)")]
        [PropertyType(typeof(string))]
        SecsAttributesAddress,

        [PropertyName("PhysicalAddressEpcSection")]
        [PropertyDescription("Physical address of the base of the EPC section")]
        [PropertyType(typeof(string))]
        PhysicalAddressEpcSection,

        [PropertyName("EpcSectionSize")]
        [PropertyDescription("Size of the corresponding EPC section within the Processor Reserved Memory")]
        [PropertyType(typeof(ulong))]
        EpcSectionSize,

        [PropertyName("EpcSectionEncoding")]
        [PropertyDescription("Defines epc section encoding")]
        [PropertyType(typeof(string))]
        EpcSectionEncoding,
    }
    #endregion

    #region [internal] (emun) Leaf00000014Property: Defines the properties available for the leaf 00000014 [Intel Processor Trace Enumeration Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000014 [Intel Processor Trace Enumeration Information].
    /// </summary>
    internal enum Leaf00000014Property
    {
        [PropertyName("MaximumSubLeafs")]
        [PropertyDescription("Reports the maximum sub-leaf supported")]
        [PropertyType(typeof(uint))]
        MaximumSubLeafs,

        [PropertyName("IA32_RTIT_CTL")]
        [PropertyDescription("Indicates that IA32_RTIT_CTL.CR3Filter can be set to 1, and that IA32_RTIT_CR3_MATCH MSR can be accessed")]
        [PropertyType(typeof(bool))]
        IA32_RTIT_CTL,

        [PropertyName("CPSB")]
        [PropertyDescription("Configurable PSB and Cycle-Accurate Mode")]
        [PropertyType(typeof(bool))]
        CPSB,

        [PropertyName("IPFILTER")]
        [PropertyDescription("IP Filtering, TraceStop filtering, and preservation of Intel PT MSRs across warm reset")]
        [PropertyType(typeof(bool))]
        IPFILTER,

        [PropertyName("MTC_TIMMING")]
        [PropertyDescription("MTC timing packet and suppression of COFI-based packets")]
        [PropertyType(typeof(bool))]
        MTC_TIMMING,

        [PropertyName("PTWRITE")]
        [PropertyDescription("PTWRITE. Writes can set IA32_RTIT_CTL[12] (PTWEn) and IA32_RTIT_CTL[5] (FUPonPTW), and PTWRITE can generate packets")]
        [PropertyType(typeof(bool))]
        PTWRITE,
        
        [PropertyName("PWEVTR")]
        [PropertyDescription("Power Event Trace. Writes can set IA32_RTIT_CTL[4] (PwrEvtEn), enabling Power Event Trace packet generation")]
        [PropertyType(typeof(bool))]
        PWEVTR,

        [PropertyName("IA32_RTIT_CTL_TRC")]
        [PropertyDescription("Tracing can be enabled with IA32_RTIT_CTL.ToPA")]
        [PropertyType(typeof(bool))]
        IA32_RTIT_CTL_TRC,

        [PropertyName("TOPA")]
        [PropertyDescription("ToPA tables can hold any number of output entries")]
        [PropertyType(typeof(bool))]
        TOPA,

        [PropertyName("SNGLRNG")]
        [PropertyDescription("Single-Range Output scheme")]
        [PropertyType(typeof(bool))]
        SNGLRNG,

        [PropertyName("TRCTNPT")]
        [PropertyDescription("Output to Trace Transport subsystem.")]
        [PropertyType(typeof(bool))]
        TRCTNPT,

        [PropertyName("IPPAY")]
        [PropertyDescription("IP payloads have LIP values, which include the CS base component")]
        [PropertyType(typeof(bool))]
        IPPAY,

        [PropertyName("NumberConfigurableAddress")]
        [PropertyDescription("Number of configurable Address Ranges for filtering")]
        [PropertyType(typeof(uint))]
        NumberConfigurableAddress,

        [PropertyName("BitmapMTC")]
        [PropertyDescription("Bitmap of supported MTC period encodings")]
        [PropertyType(typeof(uint))]
        BitmapMTC,

        [PropertyName("BitmapCycle")]
        [PropertyDescription("Bitmap of supported Cycle Threshold value encodings")]
        [PropertyType(typeof(uint))]
        BitmapCycle,

        [PropertyName("BitmapPSB")]
        [PropertyDescription("Bitmap of supported Configurable PSB frequency encodings")]
        [PropertyType(typeof(uint))]
        BitmapPSB,
    }
    #endregion

    #region [internal] (emun) Leaf00000015Property: Defines the properties available for the leaf 00000015 [Time Stamp Counter and Nominal Core Crystal Clock Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000015 [Time Stamp Counter and Nominal Core Crystal Clock Information].
    /// </summary>
    internal enum Leaf00000015Property
    {
        [PropertyName("TSCFrequency")]
        [PropertyDescription("TSC Frequencyr")]
        [PropertyType(typeof(uint))]
        TSCFrequency,
    }
    #endregion

    #region [internal] (emun) Leaf00000016Property: Defines the properties available for the leaf 00000016 [Processor Frequency Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000016 [Processor Frequency Information].
    /// </summary>
    internal enum Leaf00000016Property
    {
        [PropertyName("ProcessorBaseFrequencyr")]
        [PropertyDescription("Processor Base Frequency (MHz)")]
        [PropertyType(typeof(uint))]
        ProcessorBaseFrequency,

        [PropertyName("MaximumFrequency")]
        [PropertyDescription("Maximum Frequency (MHz)")]
        [PropertyType(typeof(uint))]
        MaximumFrequency,

        [PropertyName("BusReferenceFrequency")]
        [PropertyDescription("Bus Reference Frequency (MHz)")]
        [PropertyType(typeof(uint))]
        BusReferenceFrequency,
    }
    #endregion

    #region [internal] (emun) Leaf00000017Property: Defines the properties available for the leaf 00000017 [System-On-Chip Information]
    /// <summary>
    /// Defines the properties available for the leaf 00000017 [System-On-Chip Information].
    /// </summary>
    internal enum Leaf00000017Property
    {
        [PropertyName("MaxSOCID")]
        [PropertyDescription("Maximum input value of supported sub-leaf")]
        [PropertyType(typeof(uint))]
        MaxSOCID,

        [PropertyName("SocVendorId")]
        [PropertyDescription("SOC Vendor ID")]
        [PropertyType(typeof(uint))]
        SocVendorId,

        [PropertyName("IsVendorScheme")]
        [PropertyDescription("If true, SOC Vendor ID field is assigned via an industry standard enumeration scheme. Otherwise, is assigned by Intel")]
        [PropertyType(typeof(bool))]
        IsVendorScheme,

        [PropertyName("ProjectID")]
        [PropertyDescription("A unique number an SOC vendor assigns to its SOC projects")]
        [PropertyType(typeof(uint))]
        ProjectID,

        [PropertyName("SteppingID")]
        [PropertyDescription("A unique number within an SOC project that an SOC vendor assigns")]
        [PropertyType(typeof(uint))]
        SteppingID,

        [PropertyName("SOCVendorBrandString")]
        [PropertyDescription("SOC Vendor Brand String (partial string)")]
        [PropertyType(typeof(string))]
        SOCVendorBrandString
    }
    #endregion

    #region [internal] (emun) Leaf80000000Property: Defines the properties available for the leaf 80000000 [Highest Extended Function Implemented]
    /// <summary>
    /// Defines the properties available for the leaf 80000000 [Highest Extended Function Implemented].
    /// </summary>
    internal enum Leaf80000000Property
    {
        [PropertyName("Maximum Value")]
        [PropertyDescription("Maximum Input Value for Extended Function CPUID Information")]
        [PropertyType(typeof(uint))]
        MaximumValue,
    }
    #endregion

    #region [internal] (emun) Leaf80000001Property: Defines the properties available for the leaf 80000001 [Extended Processor Info And Features]
    /// <summary>
    /// Defines the properties available for the leaf 80000001 [Extended Processor Info And Features].
    /// </summary>
    internal enum Leaf80000001Property
    {
        [PropertyName("LAHF/SAHF")]
        [PropertyDescription("LAHF/SAHF available in 64-bit mode")]
        [PropertyType(typeof(bool))]
        LAHF_SAHF,

        [PropertyName("LZCNT")]
        [PropertyDescription("LZCNT")]
        [PropertyType(typeof(bool))]
        LZCNT,

        [PropertyName("PREFETCHW")]
        [PropertyDescription("PREFETCHW")]
        [PropertyType(typeof(bool))]
        PREFETCHW,

        [PropertyName("SYSCALL/SYSRET")]
        [PropertyDescription("SYSCALL/SYSRET available in 64-bit mode")]
        [PropertyType(typeof(bool))]
        SYSCALL_SYSRET,

        [PropertyName("EXEDISBIT")]
        [PropertyDescription("Execute Disable Bit available")]
        [PropertyType(typeof(bool))]
        EXEDISBIT,

        [PropertyName("PAGE1G")]
        [PropertyDescription("1-GByte pages ")]
        [PropertyType(typeof(bool))]
        PAGE1G,

        [PropertyName("RDTSCP/IA32_TSC_AUX")]
        [PropertyDescription("RDTSCP and IA32_TSC_AUX are available")]
        [PropertyType(typeof(bool))]
        RDTSCP_IA32_TSC_AUX,

        [PropertyName("I64")]
        [PropertyDescription("Intel® 64 Architecture")]
        [PropertyType(typeof(bool))]
        I64,
    }
    #endregion

    #region [internal] (emun) Leaf80000002Property: Defines the properties available for the leaf 80000002 [Processor Brand String]
    /// <summary>
    /// Defines the properties available for the leaf 80000000 [Processor Brand String].
    /// </summary>
    internal enum Leaf80000002Property
    {
        [PropertyName("Processor Brand String")]
        [PropertyDescription("Processor Brand String")]
        [PropertyType(typeof(string))]
        ProcessorName,
    }
    #endregion

    #region [internal] (emun) Leaf80000003Property: Defines the properties available for the leaf 80000003 [Processor Brand String Continued]
    /// <summary>
    /// Defines the properties available for the leaf 80000003 [Processor Brand String Continued].
    /// </summary>
    internal enum Leaf80000003Property
    {
        [PropertyName("Processor Brand String Continued")]
        [PropertyDescription("Processor Brand String Continued")]
        [PropertyType(typeof(string))]
        ProcessorNameContinued,
    }
    #endregion

    #region [internal] (emun) Leaf80000004Property: Defines the properties available for the leaf 80000004 [Processor Brand String Continued]
    /// <summary>
    /// Defines the properties available for the leaf 80000004 [Processor Brand String Continued].
    /// </summary>
    internal enum Leaf80000004Property
    {
        [PropertyName("Processor Brand String Continued")]
        [PropertyDescription("Processor Brand String Continued")]
        [PropertyType(typeof(string))]
        ProcessorNameContinued,
    }
    #endregion

    #region [internal] (emun) Leaf80000005Property: Defines the properties available for the leaf 80000005 [L1 Cache and TLB Identifiers]
    /// <summary>
    /// Defines the properties available for the leaf 80000005 [L1 Cache and TLB Identifiers].
    /// </summary>
    internal enum Leaf80000005Property
    {
        [PropertyName("Valid")]
        [PropertyDescription("Indicates if the CPUId call is valid. Always all registers values are 0x0000")]
        [PropertyType(typeof(bool))]
        Valid,
    }
    #endregion

    #region [internal] (emun) Leaf80000006Property: Defines the properties available for the leaf 80000006 [Extended L2 Cache Features]
    /// <summary>
    /// Defines the properties available for the leaf 80000006 [Extended L2 Cache Features].
    /// </summary>
    internal enum Leaf80000006Property
    {
        [PropertyName("Cache Line Size")]
        [PropertyDescription("Cache Line Size")]
        [PropertyType(typeof(byte))]
        CacheLineSize,

        [PropertyName("Cache Size")]
        [PropertyDescription("Cache Size")]
        [PropertyType(typeof(uint))]
        CacheSize
    }
    #endregion

    #region [internal] (emun) Leaf80000007Property: Defines the properties available for the leaf 80000007 [Advanced Power Management Information]
    /// <summary>
    /// Defines the properties available for the leaf 80000007 [Advanced Power Management Information].
    /// </summary>
    internal enum Leaf80000007Property
    {
        [PropertyName("Invariant TSC")]
        [PropertyDescription("Invariant TSC")]
        [PropertyType(typeof(bool))]
        InvariantTSC
    }
    #endregion

    #region [internal] (emun) Leaf80000008Property: Defines the properties available for the leaf 80000008 [Virtual and Physical address Sizes]
    /// <summary>
    /// Defines the properties available for the leaf 80000008 [Virtual and Physical address Sizes].
    /// </summary>
    internal enum Leaf80000008Property
    {
        [PropertyName("Physical Address")]
        [PropertyDescription("Physical Address Size")]
        [PropertyType(typeof(int))]
        PhysicalAddressSize,

        [PropertyName("Linear Address")]
        [PropertyDescription("Linear Address Bits")]
        [PropertyType(typeof(string))]
        LinearAddress,
    }
    #endregion

    #region [internal] (emun) Leaf8FFFFFFFProperty: Defines the properties available for the leaf 8FFFFFFF [AMD Easter Egg]
    /// <summary>
    /// Defines the properties available for the leaf 8FFFFFFF [AMD Easter Egg].
    /// </summary>
    internal enum Leaf8FFFFFFFProperty
    {
        [PropertyName("AMD Easter Egg")]
        [PropertyDescription("Value")]
        [PropertyType(typeof(string))]
        Value,
    }
    #endregion
}
