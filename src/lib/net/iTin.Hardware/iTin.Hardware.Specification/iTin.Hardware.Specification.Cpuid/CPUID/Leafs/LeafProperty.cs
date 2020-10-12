
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Collections.ObjectModel;

    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines available keys for the available leafs of a system.
    /// </summary>
    public static class LeafProperty
    {
        #region [public] {static} (class) BasicInformation: Contains the key definitions available for a leaf 00000000 [Basic CPUID Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000000 [<see cref="Leaf.BasicInformation"/>].
        /// </summary>
        public static class BasicInformation
        {
            #region [public] {static} (IPropertyKey) HighestBasicFunction: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the BIOS Vendor’s Name.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.BasicInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000000Property.HighestBasicFunction"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HighestBasicFunction => new PropertyKey(Leaf.BasicInformation, Leaf00000000Property.HighestBasicFunction);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// String number of the BIOS Version.<br/>
            /// This value is a free-form string that may contain core and <b>OEM</b> version information.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.BasicInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000000Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(Leaf.BasicInformation, Leaf00000000Property.Manufacturer);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorInfoAndFeatures: Contains the key definitions available for a leaf 00000001 [Processor Info and Features]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000001 [<see cref="Leaf.ProcessorInfoAndFeatures"/> Information].
        /// </summary>
        public static class ProcessorInfoAndFeatures
        {
            #region [public] {static} (class) Processor: Contains the key definition for the 'Processor' section
            /// <summary>
            /// Contains the key definition for the <b>Processor</b> section.
            /// </summary>
            public static class Processor
            {
                #region [public] {static} (IPropertyKey) CpuSignature: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cpu Signature.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CpuSignature"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CpuSignature => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CpuSignature);
                #endregion

                #region [public] {static} (IPropertyKey) BrandIndex: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Brand Index.<br/>
                /// This number provides an entry into a brand string table that contains brand strings for IA-32 processors.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.BrandIndex"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BrandIndex => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.BrandIndex);
                #endregion

                #region [public] {static} (IPropertyKey) CLFLUSH_CacheLineSize: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CLFLUSH Cache Line Size.<br/>
                /// This number indicates the size of the cache line flushed by the CLFLUSH and CLFLUSHOPT instructions in 8-byte increments.<br/>
                /// This field was introduced in the Pentium 4 processor.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CLFLUSH_CacheLineSize"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CLFLUSH_CacheLineSize => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CLFLUSH_CacheLineSize, PropertyUnit.Bytes);
                #endregion

                #region [public] {static} (IPropertyKey) LocalApicId: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Local APIC ID.<br/>
                /// The initial APIC-ID is used to identify the executing logical processor.<br/>
                /// This number is the 8-bit ID that is assigned to the local APIC on the processor during power up.<br/>
                /// This field was introduced in the Pentium 4 processor.<br/>
                /// It can also be identified via the <see cref="LeafProperty.ExtendedTopologyInformation.x2APICID"/>.<br />
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.LocalApicId"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey LocalApicId => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.LocalApicId);
                #endregion

            }
            #endregion

            #region [public] {static} (class) Features: Contains the key definition for the 'Features' section
            /// <summary>
            /// Contains the key definition for the <b>Features</b> section.
            /// </summary>
            public static class Features
            {
                #region ecx register

                #region [public] {static} (IPropertyKey) SSE3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Streaming SIMD Extensions 3 (SSE3).<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CpuSignature"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSE3 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSE3);
                #endregion

                #region [public] {static} (IPropertyKey) PCLMULQDQ: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// PCLMULQDQ.<br/>
                /// A value of <b>true</b> indicates the processor supports PCLMULQDQ instruction.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PCLMULQDQ"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PCLMULQDQ => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PCLMULQDQ);
                #endregion

                #region [public] {static} (IPropertyKey) DTES64: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// 64-bit DS Area.<br/>
                /// A value of <b>true</b> indicates the processor supports DS area using 64-bit layout.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DTES64"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DTES64 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.DTES64);
                #endregion

                #region [public] {static} (IPropertyKey) MONITOR: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// MONITOR/MWAIT.<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MONITOR"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MONITOR => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MONITOR);
                #endregion

                #region [public] {static} (IPropertyKey) DS_CPL: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CPL Qualified Debug Store.<br/>
                /// A value of <b>true</b> indicates the processor supports the the extensions to the Debug Store feature to allow for branch message storage qualified by CPL.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DS_CPL"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DS_CPL => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.DS_CPL);

                #endregion

                #region [public] {static} (IPropertyKey) VMX: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Virtual Machine Extensions.<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.VMX"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey VMX => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.VMX);
                #endregion

                #region [public] {static} (IPropertyKey) SMX: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Safer Mode Extensions.<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SMX"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SMX => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SMX);
                #endregion

                #region [public] {static} (IPropertyKey) EIST: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Enhanced Intel SpeedStep® technology.<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.EIST"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey EIST => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.EIST);
                #endregion

                #region [public] {static} (IPropertyKey) TM2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Thermal Monitor 2.<br/>
                /// A value of <b>true</b> indicates the processor supports this technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.TM2"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TM2 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.TM2);
                #endregion

                #region [public] {static} (IPropertyKey) SSSE3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Supplemental Streaming SIMD Extensions 3 (SSSE3).<br/>
                /// A value of <b>true</b> indicates the presence of the Supplemental Streaming SIMD Extensions 3 (SSSE3).
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SSSE3"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSSE3 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSSE3);
                #endregion

                #region [public] {static} (IPropertyKey) CNXT_ID: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// L1 Context ID.<br/>
                /// A value of <b>true</b> indicates the L1 data cache mode can be set to either adaptive mode or shared mode.<br/>
                /// A value of <b>false</b> indicates this feature is not supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CNXT_ID"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CNXT_ID => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CNXT_ID);
                #endregion

                #region [public] {static} (IPropertyKey) SDBG: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Silicon Debug interface.<br/>
                /// A value of <b>true</b> indicates the processor supports IA32_DEBUG_INTERFACE MSR for silicon debug.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SDBG"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SDBG => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SDBG);
                #endregion

                #region [public] {static} (IPropertyKey) FMA: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Fused multiply-add.<br/>
                /// A value of <b>true</b> indicates the processor supports FMA extensions using YMM state.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.FMA"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey FMA => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.FMA);
                #endregion

                #region [public] {static} (IPropertyKey) CMPXCHG16B: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CMPXCHG16B Instruction Available.<br/>
                /// A value of <b>true</b> indicates that the feature is available.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CMPXCHG16B"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CMPXCHG16B => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CMPXCHG16B);
                #endregion

                #region [public] {static} (IPropertyKey) xTPR: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CMPXCHG16B Instruction Available.<br/>
                /// A value of <b>true</b> indicates that the processor supports changing IA32_MISC_ENABLE.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.xTPR"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey xTPR => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.xTPR);
                #endregion

                #region [public] {static} (IPropertyKey) PDCM: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Perfmon and Debug Capability.<br/>
                /// A value of <b>true</b> indicates that the processor supports the performance and debug feature indication MSR IA32_PERF_CAPABILITIES.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PDCM"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PDCM => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PDCM);
                #endregion

                #region [public] {static} (IPropertyKey) PCID: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Process-context identifiers.<br/>
                /// A value of <b>true</b> indicates that the processor supports PCIDs.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PCID"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PCID => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PCID);
                #endregion

                #region [public] {static} (IPropertyKey) DCA: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Direct cache access for DMA writes.<br/>
                /// A value of <b>true</b> indicates the processor supports the ability to prefetch data from a memory mapped device.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DCA"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DCA => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.DCA);
                #endregion

                #region [public] {static} (IPropertyKey) SSE41: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SSE4.1 instructions.<br/>
                /// A value of <b>true</b> indicates that the processor supports SSE4.1.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SSE41"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSE41 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSE41);
                #endregion

                #region [public] {static} (IPropertyKey) SSE42: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SSE4.2 instructions.<br/>
                /// A value of <b>true</b> indicates that the processor supports SSE4.2.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SSE42"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSE42 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSE42);
                #endregion

                #region [public] {static} (IPropertyKey) x2APIC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// x2APIC feature.<br/>
                /// A value of <b>true</b> indicates that the processor supports x2APIC feature.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.x2APIC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey x2APIC => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.x2APIC);
                #endregion

                #region [public] {static} (IPropertyKey) MOVBE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// MOVBE instruction.<br/>
                /// A value of <b>true</b> indicates that the processor supports MOVBE instruction.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MOVBE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MOVBE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MOVBE);
                #endregion

                #region [public] {static} (IPropertyKey) POPCNT: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// POPCNT instruction.<br/>
                /// A value of <b>true</b> indicates that the processor supports POPCNT instruction.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.POPCNT"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey POPCNT => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.POPCNT);
                #endregion

                #region [public] {static} (IPropertyKey) TSC_Deadline: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// TSC-Deadline instruction.<br/>
                /// A value of <b>true</b> indicates that the processor’s local APIC timer supports one-shot operation using a TSC deadline value.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.TSC_Deadline"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TSC_Deadline => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.TSC_Deadline);
                #endregion

                #region [public] {static} (IPropertyKey) AES: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// AES instruction set.<br/>
                /// A value of <b>true</b> indicates that the processor supports the AES instruction extensions.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.AES"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey AES => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.AES);
                #endregion

                #region [public] {static} (IPropertyKey) XSAVE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// AES instruction set.<br/>
                /// A value of <b>true</b> indicates that the processor supports the XSAVE/XRSTOR processor extended states feature, the XSETBV/XGETBV instructions, and XCR0.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.XSAVE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey XSAVE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.XSAVE);
                #endregion

                #region [public] {static} (IPropertyKey) OSXSAVE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// XSAVE enabled by OS.<br/>
                /// A value of <b>true</b> indicates that the XSAVE enabled by OS.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.OSXSAVE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey OSXSAVE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.OSXSAVE);
                #endregion

                #region [public] {static} (IPropertyKey) AVX: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Advanced Vector Extensions.<br/>
                /// A value of <b>true</b> indicates the processor supports the AVX instruction extensions.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.AVX"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey AVX => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.AVX);
                #endregion

                #region [public] {static} (IPropertyKey) F16C: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// 16-bit floating-point conversion instructions.<br/>
                /// A value of <b>true</b> indicates that processor supports 16-bit floating-point conversion instructions.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.F16C"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey F16C => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.F16C);
                #endregion

                #region [public] {static} (IPropertyKey) RDRAND: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// On-chip random number generator feature.<br/>
                /// A value of <b>true</b> indicates that processor supports RDRAND instruction.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.RDRAND"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey RDRAND => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.RDRAND);
                #endregion

                #endregion

                #region edx register

                #region [public] {static} (IPropertyKey) FPU: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Floating Point Unit On-Chip.<br/>
                /// A value of <b>true</b> indicates that processor contains an x87 FPU.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.FPU"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey FPU => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.FPU);
                #endregion

                #region [public] {static} (IPropertyKey) VME: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Virtual 8086 Mode Enhancements.<br/>
                /// A value of <b>true</b> indicates Virtual 8086 mode enhancements.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.VME"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey VME => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.VME);
                #endregion

                #region [public] {static} (IPropertyKey) DE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Debugging Extensions.<br/>
                /// A value of <b>true</b> indicates Support for I/O breakpoints.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.DE);
                #endregion

                #region [public] {static} (IPropertyKey) PSE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Page Size Extension.<br/>
                /// A value of <b>true</b> indicates Large pages of size 4 MByte are supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PSE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PSE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PSE);
                #endregion

                #region [public] {static} (IPropertyKey) TSC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Time Stamp Counter.<br/>
                /// A value of <b>true</b> indicates the RDTSC instruction is supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.TSC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TSC => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.TSC);
                #endregion

                #region [public] {static} (IPropertyKey) MSR: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Model Specific Registers RDMSR and WRMSR Instructions.<br/>
                /// A value of <b>true</b> indicates the RDMSR and WRMSR instructions are supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MSR"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MSR => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MSR);
                #endregion

                #region [public] {static} (IPropertyKey) PAE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Physical Address Extension.<br/>
                /// A value of <b>true</b> indicates physical addresses greater than 32 bits are supported: extended page table entry formats, an extra level in the page translation tables is defined, 2-MByte pages are supported instead of 4 Mbyte pages.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PAE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PAE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PAE);
                #endregion

                #region [public] {static} (IPropertyKey) MCE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Machine Check Exception.<br/>
                /// Exception 18 is defined for Machine Checks, including CR4.MCE for controlling the feature.<br/>
                /// This feature does not define the model-specific implementations of machine-check error logging, reporting, and processor shutdowns.<br/>
                /// Machine Check exception handlers may have to depend on processor version to do model specific processing of the exception, or test for the presence of the Machine Check feature.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MCE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MCE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MCE);
                #endregion

                #region [public] {static} (IPropertyKey) CX8: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CMPXCHG8B Instruction.<br/>
                /// The compare-and-exchange 8 bytes (64 bits) instruction is supported (implicitly locked and atomic).
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CX8"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CX8 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CX8);
                #endregion

                #region [public] {static} (IPropertyKey) APIC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// APIC On-Chip.<br/>
                /// The processor contains an Advanced Programmable Interrupt Controller (APIC).
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.APIC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey APIC => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.APIC);
                #endregion

                #region [public] {static} (IPropertyKey) SEP: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SYSENTER and SYSEXIT Instructions.<br/>
                /// The SYSENTER and SYSEXIT and associated MSRs are supported.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SEP"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SEP => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SEP);
                #endregion

                #region [public] {static} (IPropertyKey) MTRR: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Memory Type Range Registers.<br/>
                /// MTRRs are supported.<br/>
                /// The MTRRcap MSR contains feature bits that describe what memory types are supported, how many variable MTRRs are supported, and whether fixed MTRRs are supported.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MTRR"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MTRR => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MTRR);
                #endregion

                #region [public] {static} (IPropertyKey) PGE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Page Global Bit.<br/>
                /// The global bit is supported in paging-structure entries that map a page, indicating TLB entries that are common
                /// to different processes and need not be flushed. The CR4.PGE bit controls this feature.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PGE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PGE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PGE);
                #endregion

                #region [public] {static} (IPropertyKey) MCA: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Machine Check Architecture.<br/>
                /// A value of <b>true</b> indicates the Machine Check Architecture of reporting machine errors is supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MCA"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MCA => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MCA);
                #endregion

                #region [public] {static} (IPropertyKey) CMOV: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Conditional Move Instructions.<br/>
                /// A value of <b>true</b> indicates the conditional move instruction CMOV is supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CMOV"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CMOV => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CMOV);
                #endregion

                #region [public] {static} (IPropertyKey) PAT: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Page Attribute Table.<br/>
                /// A value of <b>true</b> indicates the Page Attribute Table is supported.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PAT"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PAT => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PAT);
                #endregion

                #region [public] {static} (IPropertyKey) PSE_36: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// 36-Bit Page Size Extension.<br/>
                /// 4-MByte pages addressing physical memory beyond 4 GBytes are supported with 32-bit paging.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PSE_36"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PSE_36 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PSE_36);
                #endregion

                #region [public] {static} (IPropertyKey) PSN: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Processor Serial Number.<br/>
                /// The processor supports the 96-bit processor identification number feature and the feature is enabled.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PSN"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PSN => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PSN);
                #endregion

                #region [public] {static} (IPropertyKey) CLFSH: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// CLFLUSH Instruction.<br/>
                /// A value of <b>true</b> indicates the CLFLUSH Instruction is supported.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.CLFSH"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CLFSH => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.CLFSH);
                #endregion

                #region [public] {static} (IPropertyKey) DS: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Debug Store.<br/>
                /// The processor supports the ability to write debug information into a memory resident buffer.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DS"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DS => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.DS);
                #endregion

                #region [public] {static} (IPropertyKey) ACPI: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Thermal Monitor and Software Controlled Clock Facilities.<br/>
                /// The processor implements internal MSRs that allow processor temperature to be monitored and processor performance
                /// to be modulated in predefined duty cycles under software control.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.DS"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ACPI => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.ACPI);
                #endregion

                #region [public] {static} (IPropertyKey) MMX: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Intel MMX Technology.<br/>
                /// A value of <b>true</b> indicates the processor supports the Intel MMX technology.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.MMX"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MMX => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.MMX);
                #endregion

                #region [public] {static} (IPropertyKey) FXSR: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// FXSAVE and FXRSTOR Instructions.<br/>
                /// The FXSAVE and FXRSTOR instructions are supported for fast save and restore of the floating point context.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.FXSR"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey FXSR => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.FXSR);
                #endregion

                #region [public] {static} (IPropertyKey) SSE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SSE Instructions.<br/>
                /// A value of <b>true</b> indicates the processor supports the SSE extensions.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SSE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSE);
                #endregion

                #region [public] {static} (IPropertyKey) SSE2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SSE2 Instructions.<br/>
                /// A value of <b>true</b> indicates the processor supports the SSE2 extensions.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SSE2"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SSE2 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SSE2);
                #endregion

                #region [public] {static} (IPropertyKey) SS: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Self Snoop.<br/>
                /// The processor supports the management of conflicting memory types by performing a snoop of its own
                /// cache structure for transactions issued to the bus.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.SS"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SS => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.SS);
                #endregion

                #region [public] {static} (IPropertyKey) HTT: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Max APIC IDs reserved field is Valid.<br/>
                /// A value of <b>false</b> indicates there is only a single logical processor in the package and software should assume only a single APIC ID is reserved.<br/>
                /// A value of <b>true</b> indicates the value in CPUID.1.EBX[23:16] (the Maximum number of addressable IDs for logical processors in this package) is valid for the package.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.HTT"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey HTT => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.HTT);
                #endregion

                #region [public] {static} (IPropertyKey) TM: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Thermal Monitor.<br/>
                /// The processor implements the thermal monitor automatic thermal control circuitry (TCC).
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.TM"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TM => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.TM);
                #endregion

                #region [public] {static} (IPropertyKey) IA64: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// IA64 processor emulating x86.<br/>
                /// A value of <b>true</b> indicates the processor supports IA64 processor emulating x86.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.IA64"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IA64 => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.IA64);
                #endregion

                #region [public] {static} (IPropertyKey) PBE: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Pending Break Enable.<br/>
                /// A value of <b>false</b> indicates there is only a single logical processor in the package and software should assume only a single APIC ID is reserved.<br/>
                /// A value of <b>true</b> indicates the value in CPUID.1.EBX[23:16] (the Maximum number of addressable IDs for logical processors in this package) is valid for the package.<br/>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorInfoAndFeatures"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000001Property.PBE"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PBE => new PropertyKey(Leaf.ProcessorInfoAndFeatures, Leaf00000001Property.PBE);
                #endregion

                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) CacheInformation: Contains the key definitions available for a leaf 00000002 [Cache and TLB Descriptor information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000002 [<see cref="Leaf.CacheInformation"/>].
        /// </summary>
        public static class CacheInformation
        {
            #region [public] {static} (IPropertyKey) CacheDescriptions: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// TLB/Cache/Prefetch Information.<br/>
            /// Information about the processor’s internal TLBs, cache and prefetch hardware.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.CacheInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000002Property.CacheDescriptions"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheDescriptions => new PropertyKey(Leaf.CacheInformation, Leaf00000002Property.CacheDescriptions);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorSerialNumber: Contains the key definitions available for a leaf 00000003 [Processor Serial Number]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000003 [<see cref="Leaf.ProcessorSerialNumber"/> Information].
        /// </summary>
        public static class ProcessorSerialNumber
        {
            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor's serial number.<br/>
            /// The processor serial number was introduced on Intel Pentium III, but due to privacy concerns, this feature is no longer implemented on later models.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorSerialNumber"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000003Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>The processor serial number feature must be enabled in the <b>BIOS</b> setting in order to function.</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(Leaf.ProcessorSerialNumber, Leaf00000003Property.SerialNumber);
            #endregion
        }
        #endregion

        #region [public] {static} (class) DeterministicCacheParameters: Contains the key definitions available for a leaf 00000004 [Deterministic Cache Parameters]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000004 [<see cref="Leaf.DeterministicCacheParameters"/> Information].
        /// </summary>
        public static class DeterministicCacheParameters
        {
            #region [public] {static} (IPropertyKey) CacheType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cache Type.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.CacheType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheType => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.CacheType);
            #endregion

            #region [public] {static} (IPropertyKey) CacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cache Size in Bytes.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.CacheSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheSize => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.CacheSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) CacheLevel: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cache Level.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.CacheLevel"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheLevel => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.CacheLevel);
            #endregion

            #region [public] {static} (IPropertyKey) IsSelfInitializingCacheLevel: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Self Initializing cache level.<br/>
            /// Self Initializing cache level (does not need SW initialization).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.IsSelfInitializingCacheLevel"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsSelfInitializingCacheLevel => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.IsSelfInitializingCacheLevel);
            #endregion

            #region [public] {static} (IPropertyKey) IsFullyAssociativeCache: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Fully Associative cache.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.IsFullyAssociativeCache"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsFullyAssociativeCache => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.IsFullyAssociativeCache);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumLogicalProcessorCores: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum number of addressable IDs for logical processors sharing this cache.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.MaximumLogicalProcessorCores"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumLogicalProcessorCores => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.MaximumLogicalProcessorCores);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumPhysicalProcessorCores: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum number of addressable IDs for processor cores in the physical package.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.MaximumPhysicalProcessorCores"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumPhysicalProcessorCores => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.MaximumPhysicalProcessorCores);
            #endregion

            #region [public] {static} (IPropertyKey) IsCacheInclusiveOfLowerLevels: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// <b>true</b> indicates WBINVD/INVD from threads sharing this cache acts upon lower level caches for threads sharing this cache.
            /// <b>false</b> indicates WBINVD/INVD is not guaranteed to act upon lower level caches of non-originating threads sharing this cache.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.WriteBack"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey WriteBack => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.WriteBack);
            #endregion

            #region [public] {static} (IPropertyKey) IsCacheInclusiveOfLowerLevels: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Determines if the cache is inclusive of lower cache levels.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.IsCacheInclusiveOfLowerLevels"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsCacheInclusiveOfLowerLevels => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.IsCacheInclusiveOfLowerLevels);
            #endregion

            #region [public] {static} (IPropertyKey) UseDirectMappedCache: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Determines if use direct mapped cache or not (A complex function is used to index the cache, potentially using all address bits).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DeterministicCacheParameters"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000004Property.UseDirectMappedCache"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UseDirectMappedCache => new PropertyKey(Leaf.DeterministicCacheParameters, Leaf00000004Property.UseDirectMappedCache);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MonitorAndMwaitFeatures: Contains the key definitions available for a leaf 00000005 [MONITOR-MWAIT]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000005 [<see cref="Leaf.MonitorAndMwaitFeatures"/> Information].
        /// </summary>
        public static class MonitorAndMwaitFeatures
        {
            #region [public] {static} (IPropertyKey) C0: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C0 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C0"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C0 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C0);
            #endregion

            #region [public] {static} (IPropertyKey) C1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C1 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C1"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C1 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C1);
            #endregion

            #region [public] {static} (IPropertyKey) C2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C2 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C2 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C2);
            #endregion

            #region [public] {static} (IPropertyKey) C3: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C3 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C3"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C3 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C3);
            #endregion

            #region [public] {static} (IPropertyKey) C4: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C4 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C4"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C4 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C4);
            #endregion

            #region [public] {static} (IPropertyKey) C5: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C5 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C5"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C5 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C5);
            #endregion

            #region [public] {static} (IPropertyKey) C6: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C6 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C6"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C6 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C6);
            #endregion

            #region [public] {static} (IPropertyKey) C7: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of C7 extension.<br/>
            /// This extension is a processor-specific C-state, not ACPIC-state.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.C7"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey C7 => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.C7);
            #endregion

            #region [public] {static} (IPropertyKey) SmallestMonitorLineSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Smallest monitor-line size in bytes.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.SmallestMonitorLineSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SmallestMonitorLineSize => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.SmallestMonitorLineSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) LargestMonitorLineSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Largest monitor-line size in bytes.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.LargestMonitorLineSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LargestMonitorLineSize => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.LargestMonitorLineSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) MwaitSupportsTreatingInterrupts: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Supports treating interrupts as break-event for MWAIT, even when interrupts disabled.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.MonitorAndMwaitFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000005Property.MwaitSupportsTreatingInterrupts"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MwaitSupportsTreatingInterrupts => new PropertyKey(Leaf.MonitorAndMwaitFeatures, Leaf00000005Property.MwaitSupportsTreatingInterrupts);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ThermalAndPowerManagementFeatures: Contains the key definitions available for a leaf 00000006 [Thermal and Power Management]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000006 [<see cref="Leaf.ThermalAndPowerManagementFeatures"/>].
        /// </summary>
        public static class ThermalAndPowerManagementFeatures
        {
            #region [public] {static} (IPropertyKey) DigitalTemperatureSensor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Digital Temperature Sensor.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.DigitalTemperatureSensor"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DigitalTemperatureSensor => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.DigitalTemperatureSensor);
            #endregion

            #region [public] {static} (IPropertyKey) IntelTurboBoost: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Intel Turbo Boost Technology.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.IntelTurboBoost"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IntelTurboBoost => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.IntelTurboBoost);
            #endregion

            #region [public] {static} (IPropertyKey) ARAT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// ARAT.<br/>
            /// APIC-Timer-always-running feature.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.ARAT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ARAT => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.ARAT);
            #endregion

            #region [public] {static} (IPropertyKey) PLN: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PLN.<br/>
            /// Power limit notification controls.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.PLN"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PLN => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.PLN);
            #endregion

            #region [public] {static} (IPropertyKey) ECMD: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// ECMD.<br/>
            /// Clock modulation duty cycle extension.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.ECMD"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ECMD => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.ECMD);
            #endregion

            #region [public] {static} (IPropertyKey) PTM: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PTM.<br/>
            /// Package thermal management.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.PTM"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PTM => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.PTM);
            #endregion

            #region [public] {static} (IPropertyKey) HWP: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HWP.<br/>
            /// HWP base registers.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HWP"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HWP => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HWP);
            #endregion

            #region [public] {static} (IPropertyKey) HWP_Notification: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HWP Notification.<br/>
            /// IA32_HWP_INTERRUPT MSR.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HWP_Notification"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HWP_Notification => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HWP_Notification);
            #endregion

            #region [public] {static} (IPropertyKey) HWP_Activity_Window: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HWP Notification.<br/>
            /// IA32_HWP_REQUEST[bits 41:32].
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HWP_Activity_Window"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HWP_Activity_Window => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HWP_Activity_Window);
            #endregion

            #region [public] {static} (IPropertyKey) HWP_Energy_Performance_Preference: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HWP Energy Performance Preference.<br/>
            /// IA32_HWP_REQUEST[bits 31:24].
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HWP_Energy_Performance_Preference"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HWP_Energy_Performance_Preference => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HWP_Energy_Performance_Preference);
            #endregion

            #region [public] {static} (IPropertyKey) HWP_Package_Level_Request: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HWP Package Level Request.<br/>
            /// IA32_HWP_REQUEST_PKG MSR.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HWP_Package_Level_Request"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HWP_Package_Level_Request => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HWP_Package_Level_Request);
            #endregion

            #region [public] {static} (IPropertyKey) HDC: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HDC.<br/>
            /// HDC base registers IA32_PKG_HDC_CTL, IA32_PM_CTL1, IA32_THREAD_STALL MSRs.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HDC"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HDC => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HDC);
            #endregion

            #region [public] {static} (IPropertyKey) InterruptNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of Interrupt Thresholds in Digital Thermal Sensor.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.InterruptNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterruptNumber => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.InterruptNumber);
            #endregion

            #region [public] {static} (IPropertyKey) HardwareCoordinationCapability: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Hardware Coordination Feedback Capability (Presence of IA32_MPERF and IA32_APERF).<br/>
            /// The capability to provide a measure of delivered processor performance (since last reset of the counters) as a percentage of the<br/>
            /// expected processor performance when running at the TSC frequency. 
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.HardwareCoordinationCapability"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HardwareCoordinationCapability => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.HardwareCoordinationCapability);
            #endregion

            #region [public] {static} (IPropertyKey) PerformanceEnergyPreference: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Performance Energy Preference.<br/>
            /// The processor supports performance-energy bias preference and also implies the presence of a new architectural MSR<br/>
            /// called IA32_ENERGY_PERF_BIAS.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ThermalAndPowerManagementFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000006Property.PerformanceEnergyPreference"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PerformanceEnergyPreference => new PropertyKey(Leaf.ThermalAndPowerManagementFeatures, Leaf00000006Property.PerformanceEnergyPreference);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ExtendedFeatures: Contains the key definitions available for a leaf 00000007 [Structured Extended Feature Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000007 [<see cref="Leaf.ExtendedFeatures"/> Information].
        /// </summary>
        public static class ExtendedFeatures
        {
            #region ebx register

            #region [public] {static} (IPropertyKey) FSGSBASE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// FSGSBASE.<br/>
            /// Access to base of %fs and %gs.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.FSGSBASE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey FSGSBASE => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.FSGSBASE);
            #endregion

            #region [public] {static} (IPropertyKey) IA32_TSC_ADJUST_MSR: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IA32_TSC_ADJUST_MSR.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.IA32_TSC_ADJUST_MSR"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IA32_TSC_ADJUST_MSR => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.IA32_TSC_ADJUST_MSR);
            #endregion

            #region [public] {static} (IPropertyKey) SGX: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SGX.<br/>
            /// Software Protection Extensions.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.SGX"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SGX => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.SGX);
            #endregion

            #region [public] {static} (IPropertyKey) BMI1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BMI1.<br/>
            /// Bit manipulation instruction set 1.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.BMI1"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BMI1 => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.BMI1);
            #endregion

            #region [public] {static} (IPropertyKey) HLE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// HLE.<br/>
            /// TSX hardware lock bypass.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.HLE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey HLE => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.HLE);
            #endregion

            #region [public] {static} (IPropertyKey) AVX2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// AVX2.<br/>
            /// Advanced Vector Extensions 2.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.AVX2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AVX2 => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.AVX2);
            #endregion

            #region [public] {static} (IPropertyKey) FDP_EXCPTN_ONLY: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// FDP_EXCPTN_ONLY
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.FDP_EXCPTN_ONLY"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey FDP_EXCPTN_ONLY => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.FDP_EXCPTN_ONLY);
            #endregion

            #region [public] {static} (IPropertyKey) SMEP: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SMEP.<br/>
            /// Supervisor Mode Execution Prevention.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.SMEP"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SMEP => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.SMEP);
            #endregion

            #region [public] {static} (IPropertyKey) BMI2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BMI2.<br/>
            /// Bit manipulation instruction set 2.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.BMI2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BMI2 => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.BMI2);
            #endregion

            #region [public] {static} (IPropertyKey) ERMS: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// ERMS.<br/>
            /// Enhanced REP MOVSB/STOSB.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.ERMS"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ERMS => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.ERMS);
            #endregion

            #region [public] {static} (IPropertyKey) INVPCID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// INVPCID.<br/>
            /// INVPCID Instruction.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.INVPCID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey INVPCID => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.INVPCID);
            #endregion

            #region [public] {static} (IPropertyKey) RTM: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RTM.<br/>
            /// TSX Restricted Transactional Memory.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.RTM"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RTM => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.RTM);
            #endregion

            #region [public] {static} (IPropertyKey) RDT_M: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RDT_M.<br/>
            /// Platform Quality of Service Monitoring.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.RDT_M"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RDT_M => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.RDT_M);
            #endregion

            #region [public] {static} (IPropertyKey) Deprecates_FPU: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Deprecates_FPU.<br/>
            /// Deprecates FPU CS and FPU DS.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.Deprecates_FPU"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Deprecates_FPU => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.Deprecates_FPU);
            #endregion

            #region [public] {static} (IPropertyKey) MPX: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// MPX.<br/>
            /// Intel MPX (Memory Protection Extensions).<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.MPX"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MPX => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.MPX);
            #endregion

            #region [public] {static} (IPropertyKey) RDT_A: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RDT_A.<br/>
            /// Platform Quality of Service Enforcement.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.RDT_A"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RDT_A => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.RDT_A);
            #endregion

            #region [public] {static} (IPropertyKey) RDSEED: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RDSEED.<br/>
            /// RDSEED Instruction.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.RDSEED"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RDSEED => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.RDSEED);
            #endregion

            #region [public] {static} (IPropertyKey) ADX: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// ADX.<br/>
            /// Intel ADX (Multi-Precision Add-Carry Instruction Extensions).<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.ADX"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ADX => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.ADX);
            #endregion

            #region [public] {static} (IPropertyKey) SMAP: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SMAP.<br/>
            /// Supervisor Mode Access Prevention.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.SMAP"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SMAP => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.SMAP);
            #endregion

            #region [public] {static} (IPropertyKey) CLFLUSHOPT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// CLFLUSHOPT.<br/>
            /// CLFLUSHOPT Instruction.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.CLFLUSHOPT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CLFLUSHOPT => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.CLFLUSHOPT);
            #endregion

            #region [public] {static} (IPropertyKey) CLWB: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// CLWB.<br/>
            /// CLWB Instruction.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.CLWB"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CLWB => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.CLWB);
            #endregion

            #region [public] {static} (IPropertyKey) IPT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IPT.<br/>
            /// Intel Processor Trace.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.IPT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IPT => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.IPT);
            #endregion

            #region [public] {static} (IPropertyKey) SHA: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SHA.<br/>
            /// Intel SHA extensions.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.SHA"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SHA => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.SHA);
            #endregion

            #endregion

            #region ecx register

            #region [public] {static} (IPropertyKey) PREFETCHWT1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PREFETCHWT1.<br/>
            /// PREFETCHWT1 Instruction.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.PREFETCHWT1"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PREFETCHWT1 => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.PREFETCHWT1);
            #endregion

            #region [public] {static} (IPropertyKey) UMIP: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// UMIP.<br/>
            /// User-mode Instruction Prevention.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.UMIP"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UMIP => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.UMIP);
            #endregion

            #region [public] {static} (IPropertyKey) PKU: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PKU.<br/>
            /// Memory Protection Keys for User-mode pages.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.PKU"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PKU => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.PKU);
            #endregion

            #region [public] {static} (IPropertyKey) OSPKE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// OSPKE.<br/>
            /// PKU enabled by OS.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.OSPKE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OSPKE => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.OSPKE);
            #endregion

            #region [public] {static} (IPropertyKey) OSPKE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RDPID.<br/>
            /// Read Processor ID and IA32_TSC_AUX.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.RDPID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RDPID => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.RDPID);
            #endregion

            #region [public] {static} (IPropertyKey) SGX_LC: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SGX_LC.<br/>
            /// SGX Launch Configuration.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000007Property.SGX_LC"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SGX_LC => new PropertyKey(Leaf.ExtendedFeatures, Leaf00000007Property.SGX_LC);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) DirectCacheAccessInformation: Contains the key definitions available for a leaf 00000009 [Direct Cache Access Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000009 [<see cref="Leaf.DirectCacheAccessInformation"/>].
        /// </summary>
        public static class DirectCacheAccessInformation
        {
            #region [public] {static} (IPropertyKey) IA32_PLATFORM_DCA_CAP: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IA32_PLATFORM_DCA_CAP.<br/>
            /// Value of bits [31:0] of IA32_PLATFORM_DCA_CAP MSR (address 1F8H).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.DirectCacheAccessInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000009Property.IA32_PLATFORM_DCA_CAP"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IA32_PLATFORM_DCA_CAP => new PropertyKey(Leaf.DirectCacheAccessInformation, Leaf00000009Property.IA32_PLATFORM_DCA_CAP);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorSerialNumber: Contains the key definitions available for a leaf 0000000A [Architectural Performance Monitoring Features]
        /// <summary>
        /// Contains the key definitions available for a leaf 0000000A [<see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/> Information].
        /// </summary>
        public static class ArchitecturalPerformanceMonitoringFeatures
        {
            #region [public] {static} (IPropertyKey) VersionId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// VersionId.<br/>
            /// Version ID of architectural performance monitoring.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.VersionId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VersionId => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.VersionId);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfGeneralPurposeCounterPerLogicalProcessor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// NumberOfGeneralPurposeCounterPerLogicalProcessor.<br/>
            /// Number of general-purpose performance monitoring counter per logical processor.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.NumberOfGeneralPurposeCounterPerLogicalProcessor"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfGeneralPurposeCounterPerLogicalProcessor => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.NumberOfGeneralPurposeCounterPerLogicalProcessor);
            #endregion

            #region [public] {static} (IPropertyKey) BitWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BitWidth.<br/>
            /// Bit width of general-purpose, performance monitoring counter.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.BitWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BitWidth => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.BitWidth);
            #endregion

            #region [public] {static} (IPropertyKey) LenghtBitVector: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// LenghtBitVector.<br/>
            /// Length of EBX bit vector to enumerate architectural performance monitoring events.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.LenghtBitVector"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LenghtBitVector => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.LenghtBitVector);
            #endregion

            #region [public] {static} (IPropertyKey) CCE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// CCE.<br/>
            /// Core cycle event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.CCE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CCE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.CCE);
            #endregion

            #region [public] {static} (IPropertyKey) IRE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IRE.<br/>
            /// Instruction retired event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.IRE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IRE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.IRE);
            #endregion

            #region [public] {static} (IPropertyKey) RCE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RCE.<br/>
            /// Reference cycles event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.RCE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RCE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.RCE);
            #endregion

            #region [public] {static} (IPropertyKey) LLCRE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// LLCRE.<br/>
            /// Last-level cache reference event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.LLCRE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LLCRE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.LLCRE);
            #endregion

            #region [public] {static} (IPropertyKey) LLCME: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// LLCME.<br/>
            /// Last-level cache misses event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.LLCME"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LLCME => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.LLCME);
            #endregion

            #region [public] {static} (IPropertyKey) BIRE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BIRE.<br/>
            /// Branch instruction retired event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.BIRE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BIRE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.BIRE);
            #endregion

            #region [public] {static} (IPropertyKey) BMRE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BMRE.<br/>
            /// Branch mispredict retired event.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.BMRE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BMRE => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.BMRE);
            #endregion

            #region [public] {static} (IPropertyKey) NumberFixFunctionsCounters: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// NumberFixFunctionsCounters.<br/>
            /// Number of fixed-function performance counters, if Version ID > 1.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.NumberFixFunctionsCounters"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberFixFunctionsCounters => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.NumberFixFunctionsCounters);
            #endregion

            #region [public] {static} (IPropertyKey) BitWidthFixFunctionsCounters: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// BitWidthFixFunctionsCounters.<br/>
            /// Bit width of fixed-function performance counters, if Version ID > 1.<br/>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ArchitecturalPerformanceMonitoringFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000AProperty.BitWidthFixFunctionsCounters"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BitWidthFixFunctionsCounters => new PropertyKey(Leaf.ArchitecturalPerformanceMonitoringFeatures, Leaf0000000AProperty.BitWidthFixFunctionsCounters);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ExtendedTopologyInformation: Contains the key definitions available for a leaf 0000000B [Extended Topology Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 0000000B [<see cref="Leaf.ExtendedTopologyInformation"/>].
        /// </summary>
        public static class ExtendedTopologyInformation
        {
            #region [public] {static} (IPropertyKey) BitsShiftRightx2APICID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of bits to shift right on x2APIC ID to get a unique topology ID of the next level type.<br/>
            /// All logical processors with the same next level ID share current level.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedTopologyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000BProperty.BitsShiftRightx2APICID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BitsShiftRightx2APICID => new PropertyKey(Leaf.ExtendedTopologyInformation, Leaf0000000BProperty.BitsShiftRightx2APICID);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfLogicalProcessorsThisLevel: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of logical processors at this level type. The number reflects configuration as shipped by Intel.<br/>
            /// This value in this field is only intended for display/diagnostic purposes.<br/>
            /// The actual number of logical processors available to BIOS/OS/Applications may be different from this value, depending on software and platform hardware configurations.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedTopologyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000BProperty.NumberOfLogicalProcessorsThisLevel"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfLogicalProcessorsThisLevel => new PropertyKey(Leaf.ExtendedTopologyInformation, Leaf0000000BProperty.NumberOfLogicalProcessorsThisLevel);
            #endregion

            #region [public] {static} (IPropertyKey) LevelType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Level type string.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedTopologyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000BProperty.LevelType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LevelType => new PropertyKey(Leaf.ExtendedTopologyInformation, Leaf0000000BProperty.LevelType);
            #endregion

            #region [public] {static} (IPropertyKey) x2APICID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// x2APIC ID the current logical processor.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedTopologyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000BProperty.x2APICID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey x2APICID => new PropertyKey(Leaf.ExtendedTopologyInformation, Leaf0000000BProperty.x2APICID);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorExtendedStatesInformation: Contains the key definitions available for a leaf 0000000D [Processor Extended States Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 0000000D [<see cref="Leaf.ProcessorExtendedStatesInformation"/>].
        /// </summary>
        public static class ProcessorExtendedStatesInformation
        {
            #region [public] {static} (IPropertyKey) x87State: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// x87 State.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.x87State"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey x87State => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.x87State);
            #endregion

            #region [public] {static} (IPropertyKey) SSEState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SSE State.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.SSEState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SSEState => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.SSEState);
            #endregion

            #region [public] {static} (IPropertyKey) AVXState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// AVX State.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.AVXState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AVXState => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.AVXState);
            #endregion

            #region [public] {static} (IPropertyKey) IA32_XSS: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Used for IA32_XSS.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.IA32_XSS"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IA32_XSS => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.IA32_XSS);
            #endregion

            #region [public] {static} (IPropertyKey) PKRUState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PKRU State.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.PKRUState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PKRUState => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.PKRUState);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumSizeEnabledFeaturesXCR0: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) required by enabled features in XCR0.<br/>
            /// May be different than ECX if some features at the end of the XSAVE save area are not enabled.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.MaximumSizeEnabledFeaturesXCR0"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumSizeEnabledFeaturesXCR0 => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.MaximumSizeEnabledFeaturesXCR0, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumSizeAllSupportedFeatures: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) of the XSAVE/XRSTOR save area required by all <br/>
            /// supported features in the processor, i.e., all the valid bit fields in XCR0.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.MaximumSizeAllSupportedFeatures"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumSizeAllSupportedFeatures => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.MaximumSizeAllSupportedFeatures, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) UPPER32BITS_XCR0: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Reports the supported bits of the upper 32 bits of XCR0.<br/>
            /// XCR0[n+32] can be set to 1 only if EDX[n] is 1.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.UPPER32BITS_XCR0"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UPPER32BITS_XCR0 => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.UPPER32BITS_XCR0);
            #endregion

            #region [public] {static} (IPropertyKey) XSAVEOPT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// XSAVEOPT is available.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.XSAVEOPT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey XSAVEOPT => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.XSAVEOPT);
            #endregion

            #region [public] {static} (IPropertyKey) XSAVEC: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Supports XSAVEC and the compacted form of XRSTOR if is <b>true</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.XSAVEC"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey XSAVEC => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.XSAVEC);
            #endregion

            #region [public] {static} (IPropertyKey) XGETBV: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Supports XGETBV with sub-leaf 1.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.XGETBV"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey XGETBV => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.XGETBV);
            #endregion

            #region [public] {static} (IPropertyKey) XSAVES_XRSTORS_IA32_XSS: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Supports XSAVES/XRSTORS and IA32_XSS if is <b>true</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.XSAVES_XRSTORS_IA32_XSS"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey XSAVES_XRSTORS_IA32_XSS => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.XSAVES_XRSTORS_IA32_XSS);
            #endregion

            #region [public] {static} (IPropertyKey) SizeAllStatesEnabled: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The size in bytes of the XSAVE area containing all states enabled by XCRO | IA32_XSS.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.SizeAllStatesEnabled"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SizeAllStatesEnabled => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.SizeAllStatesEnabled, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) Lower32Bits_IA32_XSS: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Reports the supported bits of the lower 32 bits of the IA32_XSS MSR.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.Lower32Bits_IA32_XSS"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Lower32Bits_IA32_XSS => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.Lower32Bits_IA32_XSS, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) Upper32Bits_IA32_XSS: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Reports the supported bits of the upper 32 bits of the IA32_XSS MSR.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.Upper32Bits_IA32_XSS"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Upper32Bits_IA32_XSS => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.Upper32Bits_IA32_XSS, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) SizeSaveAreaExtendedStateFeature: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The size in bytes (from the offset specified in EBX) of the save area for an extended state feature<b/>
            /// associated with a valid sub-leaf index, n.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.SizeSaveAreaExtendedStateFeature"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SizeSaveAreaExtendedStateFeature => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.SizeSaveAreaExtendedStateFeature, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) OffsetThisExtenndedStateComponent: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The offset in bytes of this extended state component’s save area from the beginning of the XSAVE/XRSTOR area.<b/>
            /// This field reports 0 if the sub-leaf index, n, does not map to a valid bit in the XCR0 register.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.OffsetThisExtenndedStateComponent"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OffsetThisExtenndedStateComponent => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.OffsetThisExtenndedStateComponent, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) ThisSubLeafSuppoertedInIA32_XSR: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Is set if the bit n (corresponding to the sub-leaf index) is supported in the IA32_XSS MSR; it is clear if bit n is instead supported in XCR0.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.ThisSubLeafSuppoertedInIA32_XSR"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThisSubLeafSuppoertedInIA32_XSR => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.ThisSubLeafSuppoertedInIA32_XSR);
            #endregion

            #region [public] {static} (IPropertyKey) XSAVEAREAUSED: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Is set if, when the compacted format of an XSAVE area is used, this extended state component located on the next 64-byte boundary<br/>
            /// following the preceding state component (otherwise, it is located immediately following the preceding state component).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorExtendedStatesInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000DProperty.XSAVEAREAUSED"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey XSAVEAREAUSED => new PropertyKey(Leaf.ProcessorExtendedStatesInformation, Leaf0000000DProperty.XSAVEAREAUSED);
            #endregion

        }
        #endregion

        #region [public] {static} (class) ResourceDirectorTechnologyMonitoring: Contains the key definitions available for a leaf 0000000F [Intel Resource Director Technology (Intel RDT) Monitoring Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 0000000F [<see cref="Leaf.ResourceDirectorTechnologyMonitoring"/>].
        /// </summary>
        public static class ResourceDirectorTechnologyMonitoring
        {
            #region [public] {static} (IPropertyKey) MaximumRangeAllTypes: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum range (zero-based) of RMID within this physical processor of all types.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000FProperty.MaximumRangeAllTypes"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumRangeAllTypes => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.MaximumRangeAllTypes);
            #endregion

            #region [public] {static} (IPropertyKey) L3CacheIntelRDT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// L3 Cache Intel RDT.<br/>
            /// Supports L3 Cache Intel RDT Monitoring.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
            ///   <item><description>Property: <see cref="Leaf0000000FProperty.L3CacheIntelRDT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey L3CacheIntelRDT => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.L3CacheIntelRDT);
            #endregion


            #region [public] {static} (class) Item: Contains the key definition for the 'Item' section
            /// <summary>
            /// Contains the key definition for the <b>Item</b> section.
            /// </summary>
            public static class Item
            {
                #region [public] {static} (IPropertyKey) ConversionFactorThis: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Conversion factor from reported IA32_QM_CTR value to occupancy metric (bytes)
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
                ///   <item><description>Property: <see cref="Leaf0000000FProperty.ConversionFactorThis"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ConversionFactorThis => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.ConversionFactorThis, PropertyUnit.Bytes);
                #endregion

                #region [public] {static} (IPropertyKey) MaximumRangeThis: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Maximum range (zero-based) of RMID of this resource type.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
                ///   <item><description>Property: <see cref="Leaf0000000FProperty.MaximumRangeThis"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey MaximumRangeThis => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.MaximumRangeThis);
                #endregion

                #region [public] {static} (IPropertyKey) L3OCC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// L3OCC.<br/>
                /// Supports L3 occupancy monitoring.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
                ///   <item><description>Property: <see cref="Leaf0000000FProperty.L3OCC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey L3OCC => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.L3OCC);
                #endregion

                #region [public] {static} (IPropertyKey) L3TBRAND: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// L3TBRAND.<br/>
                /// Supports L3 Total Bandwidth monitoring.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
                ///   <item><description>Property: <see cref="Leaf0000000FProperty.L3TBRAND"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey L3TBRAND => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.L3TBRAND);
                #endregion

                #region [public] {static} (IPropertyKey) L3LBRAND: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// L3LBRAND.<br/>
                /// Supports L3 Local Bandwidth monitoring.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyMonitoring"/></description></item>
                ///   <item><description>Property: <see cref="Leaf0000000FProperty.L3LBRAND"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey L3LBRAND => new PropertyKey(Leaf.ResourceDirectorTechnologyMonitoring, Leaf0000000FProperty.L3LBRAND);
                #endregion
            }
            #endregion

        }
        #endregion

        #region [public] {static} (class) ResourceDirectorTechnologyAllocation: Contains the key definitions available for a leaf 00000010 [Intel Resource Director Technology (Intel RDT) Allocation Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000010 [<see cref="Leaf.ResourceDirectorTechnologyAllocation"/>].
        /// </summary>
        public static class ResourceDirectorTechnologyAllocation
        {
            #region [public] {static} (IPropertyKey) L3CacheAllocation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// L3 Cache Allocation.<br/>
            /// Supports L3 Cache Allocation Technology.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000010Property.L3CacheAllocation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey L3CacheAllocation => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.L3CacheAllocation);
            #endregion

            #region [public] {static} (IPropertyKey) L2CacheAllocation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// L2 Cache Allocation.<br/>
            /// Supports L2 Cache Allocation Technology.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000010Property.L2CacheAllocation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey L2CacheAllocation => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.L2CacheAllocation);
            #endregion


            #region [public] {static} (class) ResId: Contains the key definition for the 'ResId' items
            /// <summary>
            /// Contains the key definition for the <b>ResId</b> items.
            /// </summary>
            public static class ResId
            {
                #region [public] {static} (IPropertyKey) LengthBitMask: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Length of the capacity bit mask for the corresponding ResID using minus-one notation.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000010Property.LengthBitMask"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey LengthBitMask => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.LengthBitMask);
                #endregion

                #region [public] {static} (IPropertyKey) BitGranularMap: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Bit-granular map of isolation/contention of allocation units.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000010Property.BitGranularMap"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BitGranularMap => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.BitGranularMap);
                #endregion

                #region [public] {static} (IPropertyKey) COS: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Updates of COS should be infrequent.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000010Property.COS"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey COS => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.COS);
                #endregion

                #region [public] {static} (IPropertyKey) CodeDataPriorization: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Code and Data Prioritization Technology.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000010Property.CodeDataPriorization"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey CodeDataPriorization => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.CodeDataPriorization);
                #endregion

                #region [public] {static} (IPropertyKey) Highest_COS: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Highest COS number supported for this ResID.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ResourceDirectorTechnologyAllocation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000010Property.Highest_COS"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Highest_COS => new PropertyKey(Leaf.ResourceDirectorTechnologyAllocation, Leaf00000010Property.Highest_COS);
                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) Sgx: Contains the key definitions available for a leaf 00000012 [Intel SGX Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000012 [<see cref="Leaf.Sgx"/> Information].
        /// </summary>
        public static class Sgx
        {
            #region [public] {static} (IPropertyKey) SGX1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SGX1.<br/>
            /// If <b>true</b>, Indicates Intel SGX supports the collection of SGX1 leaf functions (Subleaf 1)
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.SGX1"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SGX1 => new PropertyKey(Leaf.Sgx, Leaf00000012Property.SGX1);
            #endregion

            #region [public] {static} (IPropertyKey) SGX2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SGX2.<br/>
            /// If <b>true</b>, Indicates Intel SGX supports the collection of SGX2 leaf functions (Subleaf 2 or higher)
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.SGX2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SGX2 => new PropertyKey(Leaf.Sgx, Leaf00000012Property.SGX2);
            #endregion

            #region [public] {static} (IPropertyKey) MISCSELECT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// MISCSELECT.<br/>
            /// Bit vector of supported extended SGX features.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.MISCSELECT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MISCSELECT => new PropertyKey(Leaf.Sgx, Leaf00000012Property.MISCSELECT);
            #endregion

            #region [public] {static} (IPropertyKey) MaxEnclaveSize64: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The maximum supported enclave size in 64-bit mode.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.MaxEnclaveSize64"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaxEnclaveSize64 => new PropertyKey(Leaf.Sgx, Leaf00000012Property.MaxEnclaveSize64);
            #endregion

            #region [public] {static} (IPropertyKey) MaxEnclaveSizeNot64: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The maximum supported enclave size in non-64-bit mode.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.MaxEnclaveSizeNot64"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaxEnclaveSizeNot64 => new PropertyKey(Leaf.Sgx, Leaf00000012Property.MaxEnclaveSizeNot64);
            #endregion

            #region [public] {static} (IPropertyKey) SecsAttributesAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Reports the valid bits of SECS.ATTRIBUTES address (128 bits).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.SecsAttributesAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SecsAttributesAddress => new PropertyKey(Leaf.Sgx, Leaf00000012Property.SecsAttributesAddress);
            #endregion

            #region [public] {static} (IPropertyKey) PhysicalAddressEpcSection: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical address of the base of the EPC section.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.PhysicalAddressEpcSection"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PhysicalAddressEpcSection => new PropertyKey(Leaf.Sgx, Leaf00000012Property.PhysicalAddressEpcSection);
            #endregion

            #region [public] {static} (IPropertyKey) EpcSectionSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Size of the corresponding EPC section within the Processor Reserved Memory.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.EpcSectionSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey EpcSectionSize => new PropertyKey(Leaf.Sgx, Leaf00000012Property.EpcSectionSize);
            #endregion

            #region [public] {static} (IPropertyKey) EpcSectionEncoding: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Defines EPC section encoding.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.Sgx"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000012Property.EpcSectionEncoding"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey EpcSectionEncoding => new PropertyKey(Leaf.Sgx, Leaf00000012Property.EpcSectionEncoding);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorTraceEnumerationInformation: Contains the key definitions available for a leaf 00000014 [Intel Processor Trace Enumeration Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000014 [<see cref="Leaf.ProcessorTraceEnumerationInformation"/>].
        /// </summary>
        public static class ProcessorTraceEnumerationInformation
        {
            #region [public] {static} (IPropertyKey) MaximumSubLeafs: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum sub-leaf supported.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.MaximumSubLeafs"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumSubLeafs => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.MaximumSubLeafs);
            #endregion

            #region [public] {static} (IPropertyKey) IA32_RTIT_CTL: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IA32_RTIT_CTL.<br/>
            /// If <b>true</b>, indicates that IA32_RTIT_CTL.CR3Filter can be set to 1, and that IA32_RTIT_CR3_MATCH MSR can be accessed.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.IA32_RTIT_CTL"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IA32_RTIT_CTL => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.IA32_RTIT_CTL);
            #endregion

            #region [public] {static} (IPropertyKey) CPSB: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// CPSB.<br/>
            /// If <b>true</b>, indicates support of Configurable PSB and Cycle-Accurate Mode.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.CPSB"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CPSB => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.CPSB);
            #endregion

            #region [public] {static} (IPropertyKey) IPFILTER: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IPFILTER.<br/>
            /// If <b>true</b>, indicates support of IP Filtering, TraceStop filtering, and preservation of Intel PT MSRs across warm reset.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.IPFILTER"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IPFILTER => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.IPFILTER);
            #endregion

            #region [public] {static} (IPropertyKey) MTC_TIMMING: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// MTC_TIMMING.<br/>
            /// If <b>true</b>, indicates support of MTC timing packet and suppression of COFI-based packets.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.MTC_TIMMING"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MTC_TIMMING => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.MTC_TIMMING);
            #endregion

            #region [public] {static} (IPropertyKey) PTWRITE: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PTWRITE.<br/>
            /// If <b>true</b>, indicates support of PTWRITE. Writes can set IA32_RTIT_CTL[12] (PTWEn) and IA32_RTIT_CTL[5] (FUPonPTW), and PTWRITE can generate packets.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.PTWRITE"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PTWRITE => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.PTWRITE);
            #endregion

            #region [public] {static} (IPropertyKey) PWEVTR: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PWEVTR.<br/>
            /// If <b>true</b>, indicates support of Power Event Trace. Writes can set IA32_RTIT_CTL[4] (PwrEvtEn), enabling Power Event Trace packet generation.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.PWEVTR"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PWEVTR => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.PWEVTR);
            #endregion

            #region [public] {static} (IPropertyKey) IA32_RTIT_CTL_TRC: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IA32_RTIT_CTL_TRC.<br/>
            /// If <b>true</b>, tracing can be enabled with IA32_RTIT_CTL.ToPA = 1, hence utilizing the ToPA output scheme; IA32_RTIT_OUTPUT_BASE and IA32_RTIT_OUTPUT_MASK_PTRS MSRs can be accessed.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.IA32_RTIT_CTL_TRC"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IA32_RTIT_CTL_TRC => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.IA32_RTIT_CTL_TRC);
            #endregion

            #region [public] {static} (IPropertyKey) TOPA: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// TOPA.<br/>
            /// If <b>true</b>, ToPA tables can hold any number of output entries, up to the maximum allowed by the Mas- kOrTableOffset field of IA32_RTIT_OUTPUT_MASK_PTRS.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.TOPA"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey TOPA => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.TOPA);
            #endregion

            #region [public] {static} (IPropertyKey) SNGLRNG: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SNGLRNG.<br/>
            /// If <b>true</b>, indicates support of Single-Range Output scheme.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.SNGLRNG"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SNGLRNG => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.SNGLRNG);
            #endregion

            #region [public] {static} (IPropertyKey) TRCTNPT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// TRCTNPT.<br/>
            /// If <b>true</b>, indicates support of output to Trace Transport subsystem.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.TRCTNPT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey TRCTNPT => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.TRCTNPT);
            #endregion

            #region [public] {static} (IPropertyKey) IPPAY: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IPPAY.<br/>
            /// If <b>true</b>, generated packets which contain IP payloads have LIP values, which include the CS base component.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000014Property.IPPAY"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IPPAY => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.IPPAY);
            #endregion


            #region [public] {static} (class) ResId: Contains the key definition for the 'Item' section
            /// <summary>
            /// Contains the key definition for the <b>Item</b> section.
            /// </summary>
            public static class Item
            {
                #region [public] {static} (IPropertyKey) NumberConfigurableAddress: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Number of configurable Address Ranges for filtering.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000014Property.NumberConfigurableAddress"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey NumberConfigurableAddress => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.NumberConfigurableAddress);
                #endregion

                #region [public] {static} (IPropertyKey) BitmapMTC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Bitmap of supported MTC period encodings.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000014Property.BitmapMTC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BitmapMTC => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.BitmapMTC);
                #endregion

                #region [public] {static} (IPropertyKey) BitmapCycle: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Bitmap of supported Cycle Threshold value encodings.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000014Property.BitmapCycle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BitmapCycle => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.BitmapCycle);
                #endregion

                #region [public] {static} (IPropertyKey) BitmapPSB: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Bitmap of supported Configurable PSB frequency encodings.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.ProcessorTraceEnumerationInformation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000014Property.BitmapPSB"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="uint"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BitmapPSB => new PropertyKey(Leaf.ProcessorTraceEnumerationInformation, Leaf00000014Property.BitmapPSB);
                    #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) TimeStampCounterAndNominalCoreCrystalClock: Contains the key definitions available for a leaf 00000015 [Time Stamp Counter and Nominal Core Crystal Clock Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000015 [<see cref="Leaf.TimeStampCounterAndNominalCoreCrystalClock"/> Information].
        /// </summary>
        public static class TimeStampCounterAndNominalCoreCrystalClock
        {
            #region [public] {static} (IPropertyKey) TSCFrequency: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// TSC Frequency in Hz.<br/>
            /// If is invalid value, always returns <b>-1</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.TimeStampCounterAndNominalCoreCrystalClock"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000015Property.TSCFrequency"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey TSCFrequency => new PropertyKey(Leaf.TimeStampCounterAndNominalCoreCrystalClock, Leaf00000015Property.TSCFrequency, PropertyUnit.Hz);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorFrequencyInformation: Contains the key definitions available for a leaf 00000016 [Processor Frequency Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000016 [<see cref="Leaf.ProcessorFrequencyInformation"/> Information].
        /// </summary>
        public static class ProcessorFrequencyInformation
        {
            #region [public] {static} (IPropertyKey) ProcessorBaseFrequency: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor Base Frequency (in MHz).<br/>
            /// Data is returned from this interface in accordance with the processor's specification and does not reflect actual values.<br/>
            /// While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorFrequencyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000016Property.ProcessorBaseFrequency"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorBaseFrequency => new PropertyKey(Leaf.ProcessorFrequencyInformation, Leaf00000016Property.ProcessorBaseFrequency, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumFrequency: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum Frequency (in MHz).<br/>
            /// Data is returned from this interface in accordance with the processor's specification and does not reflect actual values.<br/>
            /// While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorFrequencyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000016Property.MaximumFrequency"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumFrequency => new PropertyKey(Leaf.ProcessorFrequencyInformation, Leaf00000016Property.MaximumFrequency, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) BusReferenceFrequency: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Bus (Reference) Frequency (in MHz).<br/>
            /// Data is returned from this interface in accordance with the processor's specification and does not reflect actual values.<br/>
            /// While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorFrequencyInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000016Property.BusReferenceFrequency"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BusReferenceFrequency => new PropertyKey(Leaf.ProcessorFrequencyInformation, Leaf00000016Property.BusReferenceFrequency, PropertyUnit.MHz);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemOnChipInformation: Contains the key definitions available for a leaf 00000017 [System-On-Chip Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 00000017 [<see cref="Leaf.SystemOnChipInformation"/>].
        /// </summary>
        public static class SystemOnChipInformation
        {
            #region [public] {static} (IPropertyKey) MaxSOCID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// MaxSOCID.<br/>
            /// Maximum input value of supported sub-leaf.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000017Property.MaxSOCID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaxSOCID => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.MaxSOCID);
            #endregion

            #region [public] {static} (IPropertyKey) SocVendorId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SocVendorId.<br/>
            /// SOC Vendor ID.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000017Property.SocVendorId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SocVendorId => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.SocVendorId);
            #endregion

            #region [public] {static} (IPropertyKey) IsVendorScheme: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// IsVendorScheme.<br/>
            /// If true, SOC Vendor ID field is assigned via an industry standard enumeration scheme. Otherwise, is assigned by Intel.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000017Property.IsVendorScheme"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsVendorScheme => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.IsVendorScheme);
            #endregion

            #region [public] {static} (IPropertyKey) ProjectID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// ProjectID.<br/>
            /// A unique number an SOC vendor assigns to its SOC projects.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000017Property.ProjectID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProjectID => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.ProjectID);
            #endregion

            #region [public] {static} (IPropertyKey) SteppingID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SteppingID.<br/>
            /// A unique number within an SOC project that an SOC vendor assigns.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
            ///   <item><description>Property: <see cref="Leaf00000017Property.SteppingID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SteppingID => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.SteppingID);
            #endregion


            #region [public] {static} (class) Chip: Contains the key definition for the 'Chip' section
            /// <summary>
            /// Contains the key definition for the <b>Chip</b> section.
            /// </summary>
            public static class Chip
            {
                #region [public] {static} (IPropertyKey) SOCVendorBrandString: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// SOCVendorBrandString.<br/>
                /// SOC Vendor Brand String (partial string).<br/>
                /// You must concatenate all <b>SOCVendorBrandString</b> property from all sub-leafs to get full name.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Leaf: <see cref="Leaf.SystemOnChipInformation"/></description></item>
                ///   <item><description>Property: <see cref="Leaf00000017Property.SOCVendorBrandString"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SOCVendorBrandString => new PropertyKey(Leaf.SystemOnChipInformation, Leaf00000017Property.SOCVendorBrandString);
                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) HighestExtendedFunctionImplemented: Contains the key definitions available for a leaf 8000000 [Highest Extended Function Implemented]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000000 [<see cref="Leaf.HighestExtendedFunctionImplemented"/> Information].
        /// </summary>
        public static class HighestExtendedFunctionImplemented
        {
            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum Input Value for Extended Function <see cref="CPUID"/> Information.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.HighestExtendedFunctionImplemented"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000000Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(Leaf.HighestExtendedFunctionImplemented, Leaf80000000Property.MaximumValue);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ExtendedProcessorInfoAndFeatures: Contains the key definitions available for a leaf 8000001 [Extended Processor Info And Features]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000001 [<see cref="Leaf.ExtendedProcessorInfoAndFeatures"/> Information].
        /// </summary>
        public static class ExtendedProcessorInfoAndFeatures
        {
            #region [public] {static} (IPropertyKey) LAHF_SAHF: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// LAHF/SAHF.<br/>
            /// A value of <b>true</b> indicates that LAHF/SAHF available in 64-bit mode.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.LAHF_SAHF"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LAHF_SAHF => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.LAHF_SAHF);
            #endregion

            #region [public] {static} (IPropertyKey) LZCNT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// LZCNT
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.LZCNT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LZCNT => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.LZCNT);
            #endregion

            #region [public] {static} (IPropertyKey) PREFETCHW: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// PREFETCHW
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.PREFETCHW"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PREFETCHW => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.PREFETCHW);
            #endregion

            #region [public] {static} (IPropertyKey) SYSCALL_SYSRET: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// SYSCALL/SYSRET.<br/>
            /// A value of <b>true</b> indicates that SYSCALL/SYSRET available in 64-bit mode.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.SYSCALL_SYSRET"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SYSCALL_SYSRET => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.SYSCALL_SYSRET);
            #endregion

            #region [public] {static} (IPropertyKey) EXEDISBIT: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Execute Disable Bit available.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.EXEDISBIT"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey EXEDISBIT => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.EXEDISBIT);
            #endregion

            #region [public] {static} (IPropertyKey) PAGE1G: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// 1-GByte pages are available.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.PAGE1G"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PAGE1G => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.PAGE1G);
            #endregion

            #region [public] {static} (IPropertyKey) RDTSCP_IA32_TSC_AUX: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// RDTSCP/IA32_TSC_AUX.<br/>
            /// RDTSCP and IA32_TSC_AUX are available.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.RDTSCP_IA32_TSC_AUX"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RDTSCP_IA32_TSC_AUX => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.RDTSCP_IA32_TSC_AUX);
            #endregion

            #region [public] {static} (IPropertyKey) I64: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Intel® 64 Architecture.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedProcessorInfoAndFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000001Property.I64"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey I64 => new PropertyKey(Leaf.ExtendedProcessorInfoAndFeatures, Leaf80000001Property.I64);
            #endregion

        }
        #endregion

        #region [public] {static} (class) ProcessorBrandString: Contains the key definitions available for a leaf 8000002 [Processor Brand String]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000002 [<see cref="Leaf.ProcessorBrandString"/> Information].
        /// </summary>
        public static class ProcessorBrandString
        {
            #region [public] {static} (IPropertyKey) ProcessorName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor Brand String.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorBrandString"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000002Property.ProcessorName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorName => new PropertyKey(Leaf.ProcessorBrandString, Leaf80000002Property.ProcessorName);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorBrandString1: Contains the key definitions available for a leaf 8000003 [Processor Brand String Continued Continued]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000003 [<see cref="Leaf.ProcessorBrandString1"/> Information].
        /// </summary>
        public static class ProcessorBrandString1
        {
            #region [public] {static} (IPropertyKey) ProcessorNameContinued: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor Brand String Continued.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorBrandString1"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000003Property.ProcessorNameContinued"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorNameContinued => new PropertyKey(Leaf.ProcessorBrandString1, Leaf80000003Property.ProcessorNameContinued);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorBrandString2: Contains the key definitions available for a leaf 8000004 [Processor Brand String Continued Continued]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000004 [<see cref="Leaf.ProcessorBrandString2"/> Information].
        /// </summary>
        public static class ProcessorBrandString2
        {
            #region [public] {static} (IPropertyKey) ProcessorNameContinued: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor Brand String Continued.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ProcessorBrandString2"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000004Property.ProcessorNameContinued"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorNameContinued => new PropertyKey(Leaf.ProcessorBrandString2, Leaf80000004Property.ProcessorNameContinued);
            #endregion
        }
        #endregion

        #region [public] {static} (class) L1CacheAndTlbIdentifiers: Contains the key definitions available for a leaf 80000005 [L1 Cache and TLB Identifiers]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000005 [<see cref="Leaf.L1CacheAndTlbIdentifiers"/> Information].
        /// </summary>
        public static class L1CacheAndTlbIdentifiers
        {
            #region [public] {static} (IPropertyKey) Valid: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Indicates if the CPUId call is valid.<br/>
            /// Always all registers values are 0x0000.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.L1CacheAndTlbIdentifiers"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000005Property.Valid"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Valid => new PropertyKey(Leaf.L1CacheAndTlbIdentifiers, Leaf80000005Property.Valid);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ExtendedL2CacheFeatures: Contains the key definitions available for a leaf 80000006 [Extended L2 Cache Features]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000006 [<see cref="Leaf.ExtendedL2CacheFeatures"/> Information].
        /// </summary>
        public static class ExtendedL2CacheFeatures
        {
            #region [public] {static} (IPropertyKey) CacheLineSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cache Line Size in bytes.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedL2CacheFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000006Property.CacheLineSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheLineSize => new PropertyKey(Leaf.ExtendedL2CacheFeatures, Leaf80000006Property.CacheLineSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) CacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cache Size in 1K.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.ExtendedL2CacheFeatures"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000006Property.CacheLineSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheSize => new PropertyKey(Leaf.ExtendedL2CacheFeatures, Leaf80000006Property.CacheSize, PropertyUnit.KB);
            #endregion
        }
        #endregion

        #region [public] {static} (class) AdvancedPowerManagement: Contains the key definitions available for a leaf 80000007 [Advanced Power Management Information]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000007 [<see cref="Leaf.AdvancedPowerManagement"/> Information].
        /// </summary>
        public static class AdvancedPowerManagement
        {
            #region [public] {static} (IPropertyKey) InvariantTSC: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Processor's serial number.<br/>
            /// Invariant TSC available if <b>true</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.AdvancedPowerManagement"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000007Property.InvariantTSC"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InvariantTSC => new PropertyKey(Leaf.AdvancedPowerManagement, Leaf80000007Property.InvariantTSC);
            #endregion
        }
        #endregion

        #region [public] {static} (class) VirtualAndPhysicalAddressSizes: Contains the key definitions available for a leaf 80000008 [Virtual and Physical address Sizes]
        /// <summary>
        /// Contains the key definitions available for a leaf 80000008 [<see cref="Leaf.VirtualAndPhysicalAddressSizes"/> Information].
        /// </summary>
        public static class VirtualAndPhysicalAddressSizes
        {
            #region [public] {static} (IPropertyKey) PhysicalAddressSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical Address Size.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.VirtualAndPhysicalAddressSizes"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000008Property.PhysicalAddressSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PhysicalAddressSize => new PropertyKey(Leaf.VirtualAndPhysicalAddressSizes, Leaf80000008Property.PhysicalAddressSize);
            #endregion

            #region [public] {static} (IPropertyKey) LinearAddressBits: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Linear Address Bits.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.VirtualAndPhysicalAddressSizes"/></description></item>
            ///   <item><description>Property: <see cref="Leaf80000008Property.LinearAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LinearAddressBits => new PropertyKey(Leaf.VirtualAndPhysicalAddressSizes, Leaf80000008Property.LinearAddress);
            #endregion

        }
        #endregion

        #region [public] {static} (class) AmdEasterEgg: Contains the key definitions available for a leaf 8FFFFFFF [AMD Easter Egg]
        /// <summary>
        /// Contains the key definitions available for a leaf 8FFFFFFF [<see cref="Leaf.AmdEasterEgg"/> Information].
        /// </summary>
        public static class AmdEasterEgg
        {
            #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// AMD Easter Egg.<br/>
            /// Specific to AMD K7 and K8 CPUs, this returns the string <b>IT'S HAMMER TIME</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Leaf: <see cref="Leaf.AmdEasterEgg"/></description></item>
            ///   <item><description>Property: <see cref="Leaf8FFFFFFFProperty.Value"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Value => new PropertyKey(Leaf.HighestExtendedFunctionImplemented, Leaf8FFFFFFFProperty.Value);
            #endregion
        }
        #endregion
    }
}
