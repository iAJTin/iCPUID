
namespace iTin.Hardware.Specification.Cpuid
{
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines the known leaf values
    /// </summary>
    public enum Leaf : uint
    {
        /// <summary>
        /// Highest Function Parameter and Manufacturer ID
        /// </summary>
        [PropertyName("Basic CPUID Information")]
        [PropertyDescription("The processor returns the highest value the CPUID recognizes for returning basic processor information")]
        BasicInformation = 0x00,

        /// <summary>
        /// Processor Info and Feature Bits
        /// </summary>
        [PropertyName("Processor Info and Feature Bits")]
        [PropertyDescription("")]
        ProcessorInfoAndFeatures,

        /// <summary>
        /// Cache and TLB Descriptor information
        /// </summary>
        [PropertyName("Cache and TLB Descriptor information")]
        [PropertyDescription("")]
        CacheInformation,

        /// <summary>
        /// Processor Serial Number
        /// </summary>
        [PropertyName("Processor Serial Number")]
        [PropertyDescription("")]
        ProcessorSerialNumber,

        /// <summary>
        /// Processor Serial Number
        /// </summary>
        [PropertyName("Deterministic Cache Parameters")]
        [PropertyDescription("")]
        DeterministicCacheParameters,

        /// <summary>
        /// MONITOR and MWAIT Features
        /// </summary>
        [PropertyName("MONITOR and MWAIT Features")]
        [PropertyDescription("")]
        MonitorAndMwaitFeatures,

        /// <summary>
        /// Thermal and Power Management Features
        /// </summary>
        [PropertyName("Thermal and Power Management Features")]
        [PropertyDescription("")]
        ThermalAndPowerManagementFeatures,

        /// <summary>
        /// Extended Features
        /// </summary>
        [PropertyName("Extended Features")]
        [PropertyDescription("")]
        ExtendedFeatures,

        /// <summary>
        /// Direct Cache Access Information
        /// </summary>
        [PropertyName("Direct Cache Access Information")]
        [PropertyDescription("")]
        DirectCacheAccessInformation = 0x09,

        /// <summary>
        /// Architectural Performance Monitoring Features
        /// </summary>
        [PropertyName("Architectural Performance Monitoring Features")]
        [PropertyDescription("")]
        ArchitecturalPerformanceMonitoringFeatures = 0x0a,

        /// <summary>
        /// Extended Topology Information
        /// </summary>
        [PropertyName("Extended Topology Information")]
        ExtendedTopologyInformation = 0x0b,

        /// <summary>
        /// Processor Extended States Enumeration Information
        /// </summary>
        [PropertyName("Processor Extended States Enumeration Information")]
        [PropertyDescription("")]
        ProcessorExtendedStatesInformation = 0x0d,

        /// <summary>
        /// Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information
        /// </summary>
        [PropertyName("Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information")]
        [PropertyDescription("")]
        ResourceDirectorTechnologyMonitoring = 0x0f,

        /// <summary>
        /// Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information
        /// </summary>
        [PropertyName("Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information")]
        [PropertyDescription("")]
        ResourceDirectorTechnologyAllocation = 0x10,

        /// <summary>
        /// Intel SGX Enumeration Information
        /// </summary>
        [PropertyName("Intel SGX Enumeration Information")]
        [PropertyDescription("")]
        Sgx = 0x12,

        /// <summary>
        /// Intel Processor Trace Enumeration Information
        /// </summary>
        [PropertyName("Intel Processor Trace Enumeration Information")]
        [PropertyDescription("")]
        ProcessorTraceEnumerationInformation = 0x14,

        /// <summary>
        /// Time Stamp Counter and Nominal Core Crystal Clock Information
        /// </summary>
        [PropertyName("Time Stamp Counter and Nominal Core Crystal Clock Information")]
        [PropertyDescription("")]
        TimeStampCounterAndNominalCoreCrystalClock = 0x15,

        /// <summary>
        /// Processor Frequency Information
        /// </summary>
        [PropertyName("Processor Frequency Information")]
        [PropertyDescription("")]
        ProcessorFrequencyInformation = 0x16,

        /// <summary>
        /// System-On-Chip Information
        /// </summary>
        [PropertyName("System-On-Chip Information")]
        [PropertyDescription("")]
        SystemOnChipInformation = 0x17,

        /// <summary>
        /// Highest Extended Function Implemented
        /// </summary>
        [PropertyName("Highest Extended Function Implemented")]
        [PropertyDescription("")]
        HighestExtendedFunctionImplemented = 0x80000000,

        /// <summary>
        /// Extended Processor Info and Feature Bits
        /// </summary>
        [PropertyName("Extended Processor Info and Feature Bits")]
        [PropertyDescription("")]
        ExtendedProcessorInfoAndFeatures = 0x80000001,

        /// <summary>
        /// Processor Brand String
        /// </summary>
        [PropertyName("Processor Brand String")]
        [PropertyDescription("")]
        ProcessorBrandString = 0x80000002,

        /// <summary>
        /// Processor Brand String
        /// </summary>
        [PropertyName("Processor Brand String 1")]
        [PropertyDescription("")]
        ProcessorBrandString1 = 0x80000003,

        /// <summary>
        /// Processor Brand String
        /// </summary>
        [PropertyName("Processor Brand String 2")]
        [PropertyDescription("")]
        ProcessorBrandString2 = 0x80000004,

        /// <summary>
        /// L1 Cache and TLB Identifiers
        /// </summary>
        [PropertyName("L1 Cache and TLB Identifiers")]
        [PropertyDescription("")]
        L1CacheAndTlbIdentifiers = 0x80000005,

        /// <summary>
        /// Extended L2 Cache Features
        /// </summary>
        [PropertyName("Extended L2 Cache Features")]
        [PropertyDescription("")]
        ExtendedL2CacheFeatures = 0x80000006,

        /// <summary>
        /// Advanced Power Management Information
        /// </summary>
        [PropertyName("Advanced Power Management Information")]
        [PropertyDescription("")]
        AdvancedPowerManagement = 0x80000007,

        /// <summary>
        /// Advanced Power Management InformationVirtual and Physical address Sizes
        /// </summary>
        [PropertyName("Virtual and Physical address Sizes")]
        [PropertyDescription("")]
        VirtualAndPhysicalAddressSizes = 0x80000008,

        /// <summary>
        /// AMD Easter Egg
        /// </summary>
        [PropertyName("AMD Easter Egg")]
        [PropertyDescription("")]
        AmdEasterEgg = 0x8FFFFFFF,
    }
}
