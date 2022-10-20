
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x00000012: Intel SGX Enumeration Information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000012                                                                                                      |
    // | ECX = 0x00000000 (Main Leaf)                                                                                          |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |         00  SGX1. If 1, Indicates Intel SGX supports the collection of SGX1 leaf functions.                           |
    // |         01  SGX2. If 1, Indicates Intel SGX supports the collection of SGX2 leaf functions.                           |
    // |      31:02  Reserved (0x00)                                                                                           |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = MISCSELECT. Bit vector of supported extended SGX features.                                                      |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reserved                                                                                                        |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      07:00  MaxEnclaveSize_Not64. The maximum supported enclave size in non-64-bit mode is 2^(EDX[7:0])               |
    // |      15:08  MaxEnclaveSize_64. The maximum supported enclave size in 64-bit mode is 2^(EDX[15:8])                     |
    // |      31:16  Reserved (0x00)                                                                                           |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · Leaf 12H sub-leaf 0 (ECX = 0) is supported if CPUID.(EAX=07H, ECX=0H):EBX[SGX] = 1                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000012                                                                                                      |
    // | ECX = 0x00000001                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Reports the valid bits of SECS.ATTRIBUTES[31:0] that software can set with ECREATE                              |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Reports the valid bits of SECS.ATTRIBUTES[63:32] that software can set with ECREATE                             |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Reports the valid bits of SECS.ATTRIBUTES[95:64] that software can set with ECREATE                             |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Reports the valid bits of SECS.ATTRIBUTES[127:96] that software can set with ECREATE                            |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · Leaf 12H sub-leaf 1 (ECX = 1) is supported if CPUID.(EAX=07H, ECX=0H):EBX[SGX] = 1                                  |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000012                                                                                                      |
    // | ECX = 0x00000002 or higher                                                                                            |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Information                                                                                                     |
    // |                                                                                                                       |
    // |       Bits  Value                                                                                                     |
    // |      03:00  Sub-leaf Type                                                                                             |
    // |             0000b: Indicates this sub-leaf is invalid                                                                 |
    // |                    EDX:ECX:EBX:EAX return 0                                                                           |
    // |                                                                                                                       |
    // |             0001b: This sub-leaf enumerates an EPC section. EBX:EAX and EDX:ECX provide information on the Enclave    |
    // |                    Page Cache (EPC) section.                                                                          |
    // |                                                                                                                       |
    // |                    EAX                                                                                                |
    // |                         Bits  Value                                                                                   |
    // |                        11:04  Reserved (enumerate 0)                                                                  |
    // |                        31:12  Bits 31:12 of the physical address of the base of the EPC section                       |
    // |                                                                                                                       |
    // |                    EBX                                                                                                |
    // |                         Bits  Value                                                                                   |
    // |                        19:00  Bits 51:32 of the physical address of the base of the EPC section                       |
    // |                        31:20  Reserved                                                                                |
    // |                                                                                                                       |
    // |                    ECX                                                                                                |
    // |                         Bits  Value                                                                                   |
    // |                        03:00  EPC section property encoding defined as follows:                                       |
    // |                               0000b: then all bits of the EDX:ECX pair are enumerated as 0                            |
    // |                               0000b: then this section has confidentiality and integrity protection.                  |
    // |                               All other encodings are reserved                                                        |
    // |                        11:04  Reserved (enumerate 0)                                                                  |
    // |                        31:12  Bits 31:12 of the size of the corresponding EPC section within the Processor Reserved   |
    // |                               Memory                                                                                  |
    // |                                                                                                                       |
    // |                    EDX                                                                                                |
    // |                         Bits  Value                                                                                   |
    // |                        19:00  Bits 51:32 of the size of the corresponding EPC section within the Processor Reserved   |
    // |                               Memory                                                                                  |
    // |                        31:20  Reserved                                                                                |
    // |                                                                                                                       |
    // •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | · Leaf 12H sub-leaf 2 or higher (ECX >= 2) is supported if CPUID.(EAX=07H, ECX=0H):EBX[SGX] = 1                       |
    // |                                                                                                                       |
    // | · For sub-leaves (ECX = 2 or higher), definition of EDX,ECX,EBX,EAX[31:4] depends on the sub-leaf type listed above   |
    // |   see EAX values.                                                                                                     |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Intel SGX Enumeration Information</b>.
    /// </summary>
    internal sealed class Leaf00000012 : LeafBase
    {
        #region private constants

        #region SubLeaf: Main

        #region register EAX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SGX1 = Bits.Bit01; // 00 - Indicates Intel SGX supports the collection of SGX1 leaf functions
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SGX2 = Bits.Bit02; // 01 - Indicates Intel SGX supports the collection of SGX2 leaf functions

        #endregion

        #region register EBX definition

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits MISCSELECT = Bits.Bit31; // 31 - Bit vector of supported extended SGX features

        #endregion

        #endregion

        #endregion

        #region constructor/s

        #region [public] Leaf00000012(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000012"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000012(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (uint) MaxEnclaveSize_Not64: Gets a value representing the 'MaxEnclaveSize_Not64' field
        /// <summary>
        /// Gets a value representing the <b>MaxEnclaveSize_Not64</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaxEnclaveSize_Not64 => InvokeResult.edx & 0xff;
        #endregion

        #region [private] (uint) MaxEnclaveSize_64: Gets a value representing the 'MaxEnclaveSize_64' field
        /// <summary>
        /// Gets a value representing the <b>MaxEnclaveSize_64</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaxEnclaveSize_64 => (InvokeResult.edx >> 0x08) & 0xff;
        #endregion

        #region [private] (string) SecsAttributesAddress: Gets a value representing the 'SECS ATTRIBUTES ADDRESS' field
        /// <summary>
        /// Gets a value representing the <b>SECS ATTRIBUTES ADDRESS</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SecsAttributesAddress => $"{InvokeResult.edx:X8}{InvokeResult.ecx:X8}{InvokeResult.ebx:X8}{InvokeResult.eax:X8}";
        #endregion

        #region [private] (uint) SubLeafType: Gets a value representing the 'Sub Leaf Type' field
        /// <summary>
        /// Gets a value representing the <b>Sub Leaf Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SubLeafType => InvokeResult.eax & 0x0f;
        #endregion

        #region [private] (string) PhysicalAddressEpcSection: Gets a value representing the 'Physical Address EPC Section' field
        /// <summary>
        /// Gets a value representing the <b>Physical Address EPC Section</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string PhysicalAddressEpcSection => $"{InvokeResult.ebx & 0xfffff}{(InvokeResult.eax >> 0x0c) & 0xfffff}";
        #endregion

        #region [private] (ulong) EpcSectionSize: Gets a value representing the 'EPC Section Size' field
        /// <summary>
        /// Gets a value representing the <b>EPC Section Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong EpcSectionSize => CreateUnsignedLongFromValues(InvokeResult.edx & 0xfffff, (InvokeResult.ecx >> 0x0c) & 0xfffff);
        #endregion

        #region [private] (byte) EpcSectionEncoding: Gets a value representing the 'EPC Section Encoding' field
        /// <summary>
        /// Gets a value representing the <b>EPC Section Encoding</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EpcSectionEncoding => (byte)(InvokeResult.ecx & 0x0f);
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
                    properties.Add(LeafProperty.Sgx.SGX1, InvokeResult.eax.CheckBit(SGX1));
                    properties.Add(LeafProperty.Sgx.SGX2, InvokeResult.eax.CheckBit(SGX2));
                    properties.Add(LeafProperty.Sgx.MISCSELECT, InvokeResult.eax.CheckBit(MISCSELECT));
                    properties.Add(LeafProperty.Sgx.MaxEnclaveSize64, 2 ^ MaxEnclaveSize_64);
                    properties.Add(LeafProperty.Sgx.MaxEnclaveSizeNot64, 2 ^ MaxEnclaveSize_Not64);
                    break;

                case SubLeaf.One:
                    properties.Add(LeafProperty.Sgx.SecsAttributesAddress, SecsAttributesAddress);
                    break;
                
                default:
                {
                    if (SubLeaf >= SubLeaf.Two)
                    {
                        switch (SubLeafType)
                        {
                            case 0:
                                // Invalid Sub-leaf, nothing to do.
                                break;

                            case 1:
                                properties.Add(LeafProperty.Sgx.PhysicalAddressEpcSection, PhysicalAddressEpcSection);
                                properties.Add(LeafProperty.Sgx.EpcSectionSize, EpcSectionSize);
                                properties.Add(LeafProperty.Sgx.EpcSectionEncoding, GetEpcSectionEncoding(EpcSectionEncoding));
                                break;
                        }
                    }
                    break;
                }
            }
        }
        #endregion

        #endregion


        #region CPUID Specification

        #region [private] {static} (string) GetEpcSectionEncoding(byte): Returns the EPC section encoding
        /// <summary>
        /// Returns the EPC section encoding.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A <see cref="string"/> containing the EPC section encoding.
        /// </returns>
        private static string GetEpcSectionEncoding(byte code)
        {
            string[] epcSectionEncoding =
            {
                "No encoding information",
                "This section has confidentiality and integrity protection"
            };

            return code > 0x01
                ? "Reserved"
                : epcSectionEncoding[code];
        }
        #endregion

        #endregion
    }
}
