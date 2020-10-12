
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // Leaf 0x00000006: Thermal and Power Management 
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000006                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  Digital temperature sensor is supported if set.                                                           |
    // |         01  Intel Turbo Boost Technology Available (see description of IA32_MISC_ENABLE[38]).                         |
    // |         02  ARAT. APIC-Timer-always-running feature is supported if set.                                              |
    // |         03  Reserved.                                                                                                 |
    // |         04  PLN. Power limit notification controls are supported if set.                                              |
    // |         05  ECMD. Clock modulation duty cycle extension is supported if set.                                          |
    // |         06  PTM. Package thermal management is supported if set.                                                      |
    // |         07  HWP. HWP base registers (IA32_PM_ENABLE[bit 0], IA32_HWP_CAPABILITIES, IA32_HWP_REQUEST, IA32_HWP_STATUS) |
    // |             are supported if set.                                                                                     |
    // |         08  HWP_Notification. IA32_HWP_INTERRUPT MSR is supported if set.                                             |
    // |         09  HWP_Activity_Window. IA32_HWP_REQUEST[bits 41:32] is supported if set.                                    |
    // |         10  HWP_Energy_Performance_Preference. IA32_HWP_REQUEST[bits 31:24] is supported if set.                      |
    // |         11  HWP_Package_Level_Request. IA32_HWP_REQUEST_PKG MSR is supported if set.                                  |
    // |         12  Reserved.                                                                                                 |
    // |         13  HDC. HDC base registers IA32_PKG_HDC_CTL, IA32_PM_CTL1, IA32_THREAD_STALL MSRs are supported if set.      |
    // |      31:15  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      03:00  Number of Interrupt Thresholds in Digital Thermal Sensor.                                                 |
    // |      31:04  Reserved                                                                                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  Hardware Coordination Feedback Capability (Presence of IA32_MPERF and IA32_APERF).                        |
    // |             The capability to provide a measure of delivered processor performance (since last reset of the counters),|
    // |             as a percentage of the expected processor performance when running at the TSC frequency.                  |
    // |      02:01  Reserved (0)                                                                                              |
    // |         03  The processor supports performance-energy bias preference if CPUID.06H:ECX.SETBH[bit 3] is set and it     |
    // |             also implies the presence of a new architectural MSR called IA32_ENERGY_PERF_BIAS (1B0H).                 |
    // |      31:04  Reserved (0)                                                                                              |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Thermal and Power Management</b>.
    /// </summary>
    internal sealed class Leaf00000006 : LeafBase
    {
        #region private constants

        #region register EAX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits DIGITAL_TEMPERATURE_SENSOR = Bits.Bit00;        // 00 - Digital temperature sensor
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits INTEL_TURBO_BOOST = Bits.Bit01;                 // 01 - Intel Turbo Boost Technology Available
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ARAT = Bits.Bit02;                              // 02 - APIC-Timer-always-running feature is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PLN = Bits.Bit04;                               // 04 - Power limit notification controls are supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits ECMD = Bits.Bit05;                              // 05 - Clock modulation duty cycle extension is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PTM = Bits.Bit06;                               // 06 - Package thermal management is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HWP = Bits.Bit07;                               // 07 - HWP base registers (IA32_PM_ENABLE[bit 0], IA32_HWP_CAPABILITIES, IA32_HWP_REQUEST, IA32_HWP_STATUS) are supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HWP_Notification = Bits.Bit08;                  // 08 - IA32_HWP_INTERRUPT MSR is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HWP_Activity_Window = Bits.Bit09;               // 09 - IA32_HWP_REQUEST[bits 41:32] is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HWP_Energy_Performance_Preference = Bits.Bit10; // 10 - IA32_HWP_REQUEST[bits 31:24] is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HWP_Package_Level_Request = Bits.Bit11;         // 11 - IA32_HWP_REQUEST_PKG MSR is supported if set
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HDC = Bits.Bit13;                               // 13 - HDC base registers IA32_PKG_HDC_CTL, IA32_PM_CTL1, IA32_THREAD_STALL MSRs are supported if set
     
        #endregion

        #region register ECX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits HARD_COORD_CAP = Bits.Bit00; // 00 - Hardware Coordination Feedback Capability
                                                                                                          //      (Presence of IA32_MPERF and IA32_APERF)

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits PERFORM_ENERGY = Bits.Bit03; // 03 - The processor supports performance-energy
                                                                                                          //      bias preference if set and it also implies
                                                                                                          //      the presence of a new architectural
                                                                                                          //      MSR called IA32_ENERGY_PERF_BIAS (1B0H).
        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000006(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000006"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000006(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) InterruptNumber: Gets a value representing the 'Interrupt Number Thresholds' field
        /// <summary>
        /// Gets a value representing the <b>Interrupt Number Thresholds</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint InterruptNumber => InvokeResult.ebx & 0xf;
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
            #region ecx register

            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.DigitalTemperatureSensor, InvokeResult.eax.CheckBit(DIGITAL_TEMPERATURE_SENSOR));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.IntelTurboBoost, InvokeResult.eax.CheckBit(INTEL_TURBO_BOOST));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.ARAT, InvokeResult.eax.CheckBit(ARAT));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.PLN, InvokeResult.eax.CheckBit(PLN));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.ECMD, InvokeResult.eax.CheckBit(ECMD));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.PTM, InvokeResult.eax.CheckBit(PTM));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HWP, InvokeResult.eax.CheckBit(HWP));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HWP_Notification, InvokeResult.eax.CheckBit(HWP_Notification));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HWP_Activity_Window, InvokeResult.eax.CheckBit(HWP_Activity_Window));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HWP_Energy_Performance_Preference, InvokeResult.eax.CheckBit(HWP_Energy_Performance_Preference));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HWP_Package_Level_Request, InvokeResult.eax.CheckBit(HWP_Package_Level_Request));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HDC, InvokeResult.eax.CheckBit(HDC));

            #endregion

            #region ebx register

            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.InterruptNumber, InterruptNumber);

            #endregion

            #region ecx register

            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.HardwareCoordinationCapability, InvokeResult.ecx.CheckBit(HARD_COORD_CAP));
            properties.Add(LeafProperty.ThermalAndPowerManagementFeatures.PerformanceEnergyPreference, InvokeResult.ecx.CheckBit(PERFORM_ENERGY));

            #endregion
        }
        #endregion

        #endregion
    }
}
