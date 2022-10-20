
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;
using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

namespace iTin.Hardware.Specification.Cpuid
{
    // Leaf 0x00000002: Cache and TLB Descriptor information
    //
    // •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = 0x00000002                                                                                                      |
    // |                                                                                                                       |
    // •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EAX = Cache and TLB Information.                                                                                      |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EBX = Cache and TLB Information                                                                                       |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | ECX = Cache and TLB Information                                                                                       |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                                       |
    // | EDX = Cache and TLB Information                                                                                       |
    // |                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <b>Cache and TLB Descriptor information</b>.
    /// </summary>
    internal sealed class Leaf00000002 : LeafBase
    {
        #region constructor/s

        #region [public] Leaf00000002(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf00000002"/> class.
        /// </summary>
        /// <param name="data">Current leaf information.</param>
        /// <param name="subLeaf">Current sub-leaf information.</param>
        public Leaf00000002(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) : base(data, subLeaf)
        {
        }
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
            properties.Add(LeafProperty.CacheInformation.CacheDescriptions, GetCacheDescriptions(InvokeResult));
        }
        #endregion

        #endregion


        #region CPUID Specification

        #region [private] {static} (string) GetCacheDescription(byte): Returns the cache description for a given value
        /// <summary>
        /// Returns the cache description for a given value.
        /// </summary>
        /// <param name="value">Target value</param>
        /// <returns>
        /// A <see cref="string"/> that contains the cache description for a given value.
        /// </returns>
        private static string GetCacheDescription(byte value)
        {
            var cacheTable = new Collection<Tuple<byte, string, string>>
            {
                new Tuple<byte, string, string>(0x00, "General", "Null descriptor"),
                new Tuple<byte, string, string>(0x01, "TLB", "Instruction TLB: 4 KByte pages, 4-way set associative, 32 entries"),
                new Tuple<byte, string, string>(0x02, "TLB", "Instruction TLB: 4 MByte pages, fully associative, 2 entries"),
                new Tuple<byte, string, string>(0x03, "TLB", "Data TLB: 4 KByte pages, 4-way set associative, 64 entries"),
                new Tuple<byte, string, string>(0x04, "TLB", "Data TLB: 4 MByte pages, 4-way set associative, 8 entries"),
                new Tuple<byte, string, string>(0x05, "TLB", "Data TLB1: 4 MByte pages, 4-way set associative, 32 entries"),
                new Tuple<byte, string, string>(0x06, "Cache", "1st-level instruction cache: 8 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x08, "Cache", "1st-level instruction cache: 16 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x09, "Cache", "1st-level instruction cache: 32KBytes, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x0A, "Cache", "1st-level data cache: 8 KBytes, 2-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x0B, "TLB", "Instruction TLB: 4 MByte pages, 4-way set associative, 4 entries"),
                new Tuple<byte, string, string>(0x0C, "Cache", "1st-level data cache: 16 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x0D, "Cache", "1st-level data cache: 16 KBytes, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x0E, "Cache", "1st-level data cache: 24 KBytes, 6-way set associative, 64 byte line size"),
                // 0x0F
                // 0x10
                // 0x11
                // 0x12
                // 0x13
                // 0x14
                // 0x15
                // 0x16
                // 0x17
                // 0x18
                // 0x19
                // 0x1A
                // 0x1B
                // 0x1C
                new Tuple<byte, string, string>(0x1D, "Cache", "2nd-level cache: 128 KBytes, 2-way set associative, 64 byte line size"),
                // 0x1E
                // 0x1F
                // 0x20
                new Tuple<byte, string, string>(0x21, "Cache", "2nd-level cache: 256 KBytes, 8-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x22, "Cache", "3rd-level cache: 512 KBytes, 4-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x23, "Cache", "3rd-level cache: 1 MBytes, 8-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x24, "Cache", "2nd-level cache: 1 MBytes, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x25, "Cache", "3rd-level cache: 2 MBytes, 8-way set associative, 64 byte line size, 2 lines per sector"),
                // 0x26
                // 0x27
                // 0x28
                new Tuple<byte, string, string>(0x29, "Cache", "3rd-level cache: 4 MBytes, 8-way set associative, 64 byte line size, 2 lines per sector"),
                // 0x2A
                // 0x2B
                new Tuple<byte, string, string>(0x2C, "Cache", "1st-level data cache: 32 KBytes, 8-way set associative, 64 byte line size"),
                // 0x2D
                // 0x2E
                // 0x2F
                new Tuple<byte, string, string>(0x30, "Cache", "1st-level instruction cache: 32 KBytes, 8-way set associative, 64 byte line size"),
                // 0x31
                // 0x32
                // 0x33
                // 0x34
                // 0x35
                // 0x36
                // 0x37
                // 0x38
                // 0x39
                // 0x3A
                // 0x3B
                // 0x3C
                // 0x3D
                // 0x3E
                // 0x3F
                new Tuple<byte, string, string>(0x40, "Cache", "No 2nd-level cache or, if processor contains a valid 2nd-level cache, no 3rd-level cache"),
                new Tuple<byte, string, string>(0x41, "Cache", "2nd-level cache: 128 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x42, "Cache", "2nd-level cache: 256 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x43, "Cache", "2nd-level cache: 512 KBytes, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x44, "Cache", "2nd-level cache: 1 MByte, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x45, "Cache", "2nd-level cache: 2 MByte, 4-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x46, "Cache", "3rd-level cache: 4 MByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x47, "Cache", "3rd-level cache: 8 MByte, 8-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x48, "Cache", "2nd-level cache: 3MByte, 12-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x49, "Cache", "3rd-level cache: 4MB, 16-way set associative, 64-byte line size (Intel Xeon processor MP, Family 0FH, Model 06H); 2nd-level cache: 4 MByte, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4A, "Cache", "3rd-level cache: 6MByte, 12-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4B, "Cache", "3rd-level cache: 8MByte, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4C, "Cache", "3rd-level cache: 12MByte, 12-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4D, "Cache", "3rd-level cache: 16MByte, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4E, "Cache", "2nd-level cache: 6MByte, 24-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x4F, "TLB", "Instruction TLB: 4 KByte pages, 32 entries"),
                new Tuple<byte, string, string>(0x50, "TLB", "Instruction TLB: 4 KByte and 2-MByte or 4-MByte pages, 64 entries"),
                new Tuple<byte, string, string>(0x51, "TLB", "Instruction TLB: 4 KByte and 2-MByte or 4-MByte pages, 128 entries"),
                new Tuple<byte, string, string>(0x52, "TLB", "Instruction TLB: 4 KByte and 2-MByte or 4-MByte pages, 256 entries"),
                // 0x53
                // 0x54
                new Tuple<byte, string, string>(0x55, "TLB", "Instruction TLB: 2-MByte or 4-MByte pages, fully associative, 7 entries"),
                new Tuple<byte, string, string>(0x56, "TLB", "Data TLB0: 4 MByte pages, 4-way set associative, 16 entries"),
                new Tuple<byte, string, string>(0x57, "TLB", "Data TLB0: 4 KByte pages, 4-way associative, 16 entries"),
                // 0x58
                new Tuple<byte, string, string>(0x59, "TLB", "Data TLB0: 4 KByte pages, fully associative, 16 entries"),
                new Tuple<byte, string, string>(0x5A, "TLB", "Data TLB0: 2 MByte or 4 MByte pages, 4-way set associative, 32 entries"),
                new Tuple<byte, string, string>(0x5B, "TLB", "Data TLB: 4 KByte and 4 MByte pages, 64 entries"),
                new Tuple<byte, string, string>(0x5C, "TLB", "Data TLB: 4 KByte and 4 MByte pages, 128 entries"),
                new Tuple<byte, string, string>(0x5D, "TLB", "Data TLB: 4 KByte and 4 MByte pages, 256 entries"),
                // 0x5E
                // 0x5F
                new Tuple<byte, string, string>(0x60, "Cache", "1st-level data cache: 16 KByte, 8-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x61, "TLB", "Instruction TLB: 4 KByte pages, fully associative, 48 entries"),
                // 0x62
                new Tuple<byte, string, string>(0x63, "TLB", "Data TLB: 2 MByte or 4 MByte pages, 4-way set associative, 32 entries and a separate array with 1 GByte pages, 4-way set associative, 4 entries"),
                new Tuple<byte, string, string>(0x64, "TLB", "Data TLB: 4 KByte pages, 4-way set associative, 512 entries"),
                // 0x65
                new Tuple<byte, string, string>(0x66, "Cache", "1st-level data cache: 8 KByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x67, "Cache", "1st-level data cache: 16 KByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x68, "Cache", "1st-level data cache: 32 KByte, 4-way set associative, 64 byte line size"),
                // 0x69
                new Tuple<byte, string, string>(0x6A, "Cache", "uTLB: 4 KByte pages, 8-way set associative, 64 entries"),
                new Tuple<byte, string, string>(0x6B, "Cache", "DTLB: 4 KByte pages, 8-way set associative, 256 entries"),
                new Tuple<byte, string, string>(0x6C, "Cache", "DTLB: 2M/4M pages, 8-way set associative, 128 entries"),
                new Tuple<byte, string, string>(0x6D, "Cache", "DTLB: 1 GByte pages, fully associative, 16 entries"),
                // 0x6E
                // 0x6F
                new Tuple<byte, string, string>(0x70, "Cache", "Trace cache: 12 K-μop, 8-way set associative"),
                new Tuple<byte, string, string>(0x71, "Cache", "Trace cache: 16 K-μop, 8-way set associative"),
                new Tuple<byte, string, string>(0x72, "Cache", "Trace cache: 32 K-μop, 8-way set associative"),
                // 0x73
                // 0x74
                // 0x75
                new Tuple<byte, string, string>(0x76, "TLB", "Instruction TLB: 2M/4M pages, fully associative, 8 entries"),
                // 0x77
                new Tuple<byte, string, string>(0x78, "Cache", "2nd-level cache: 1 MByte, 4-way set associative, 64byte line size"),
                new Tuple<byte, string, string>(0x79, "Cache", "2nd-level cache: 128 KByte, 8-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x7A, "Cache", "2nd-level cache: 256 KByte, 8-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x7B, "Cache", "2nd-level cache: 512 KByte, 8-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x7C, "Cache", "2nd-level cache: 1 MByte, 8-way set associative, 64 byte line size, 2 lines per sector"),
                new Tuple<byte, string, string>(0x7D, "Cache", "2nd-level cache: 2 MByte, 8-way set associative, 64byte line size"),
                // 0x7E
                new Tuple<byte, string, string>(0x7F, "Cache", "2nd-level cache: 512 KByte, 2-way set associative, 64-byte line size"),
                new Tuple<byte, string, string>(0x80, "Cache", "2nd-level cache: 512 KByte, 8-way set associative, 64-byte line size"),
                // 0x81
                new Tuple<byte, string, string>(0x82, "Cache", "2nd-level cache: 256 KByte, 8-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x83, "Cache", "2nd-level cache: 512 KByte, 8-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x84, "Cache", "2nd-level cache: 1 MByte, 8-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x85, "Cache", "2nd-level cache: 2 MByte, 8-way set associative, 32 byte line size"),
                new Tuple<byte, string, string>(0x86, "Cache", "2nd-level cache: 512 KByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0x87, "Cache", "2nd-level cache: 1 MByte, 8-way set associative, 64 byte line size"),
                // 0x88
                // 0x89
                // 0x8A
                // 0x8B
                // 0x8C
                // 0x8D
                // 0x8E
                // 0x8F
                // 0x90
                // 0x91
                // 0x92
                // 0x93
                // 0x94
                // 0x95
                // 0x96
                // 0x97
                // 0x98
                // 0x99
                // 0x9A
                // 0x9B
                // 0x9C
                // 0x9D
                // 0x9E
                // 0x9F
                new Tuple<byte, string, string>(0xA0, "DTLB", "DTLB: 4k pages, fully associative, 32 entries"),
                // 0xA1
                // 0xA2
                // 0xA3
                // 0xA4
                // 0xA5
                // 0xA6
                // 0xA7
                // 0xA8
                // 0xA9
                // 0xAA
                // 0xAB
                // 0xAC
                // 0xAD
                // 0xAE
                // 0xAF
                new Tuple<byte, string, string>(0xB0, "TLB", "Instruction TLB: 4 KByte pages, 4-way set associative, 128 entries"),
                new Tuple<byte, string, string>(0xB1, "TLB", "Instruction TLB: 2M pages, 4-way, 8 entries or 4M pages, 4-way, 4 entries"),
                new Tuple<byte, string, string>(0xB2, "TLB", "Instruction TLB: 4KByte pages, 4-way set associative, 64 entries"),
                new Tuple<byte, string, string>(0xB3, "TLB", "Data TLB: 4 KByte pages, 4-way set associative, 128 entries"),
                new Tuple<byte, string, string>(0xB4, "TLB", "Data TLB1: 4 KByte pages, 4-way associative, 256 entries"),
                new Tuple<byte, string, string>(0xB5, "TLB", "Instruction TLB: 4KByte pages, 8-way set associative, 64 entries"),
                new Tuple<byte, string, string>(0xB6, "TLB", "Instruction TLB: 4KByte pages, 8-way set associative, 128 entries"),
                // 0xB7
                // 0xB8
                // 0xB9
                new Tuple<byte, string, string>(0xBA, "TLB", "Data TLB1: 4 KByte pages, 4-way associative, 64 entries"),
                // 0xBB
                // 0xBC
                // 0xBD
                // 0xBE
                // 0xBF
                new Tuple<byte, string, string>(0xC0, "TLB", "Data TLB: 4 KByte and 4 MByte pages, 4-way associative, 8 entries"),
                new Tuple<byte, string, string>(0xC1, "STLB", "Shared 2nd-Level TLB: 4 KByte/2MByte pages, 8-way associative, 1024 entries"),
                new Tuple<byte, string, string>(0xC2, "DTLB", "DTLB: 4 KByte/2 MByte pages, 4-way associative, 16 entries"),
                new Tuple<byte, string, string>(0xC3, "STLB", "Shared 2nd-Level TLB: 4 KByte /2 MByte pages, 6-way associative, 1536 entries. Also 1GBbyte pages, 4-way, 16 entries"),
                new Tuple<byte, string, string>(0xC4, "DTLB", "DTLB: 2M/4M Byte pages, 4-way associative, 32 entries"),
                // 0xC5
                // 0xC6
                // 0xC7
                // 0xC8
                // 0xC9
                new Tuple<byte, string, string>(0xCA, "STLB", "Shared 2nd-Level TLB: 4 KByte pages, 4-way associative, 512 entries"),
                // 0xCB
                // 0xCC
                // 0xCD
                // 0xCE
                // 0xCF
                new Tuple<byte, string, string>(0xD0, "Cache", "3rd-level cache: 512 KByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xD1, "Cache", "3rd-level cache: 1 MByte, 4-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xD2, "Cache", "3rd-level cache: 2 MByte, 4-way set associative, 64 byte line size"),
                // 0xD3
                // 0xD4
                // 0xD5
                new Tuple<byte, string, string>(0xD6, "Cache", "3rd-level cache: 1 MByte, 8-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xD7, "Cache", "3rd-level cache: 2 MByte, 8-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xD8, "Cache", "3rd-level cache: 4 MByte, 8-way set associative, 64 byte line size"),
                // 0xD9
                // 0xDA
                // 0xDB
                new Tuple<byte, string, string>(0xDC, "Cache", "3rd-level cache: 1.5 MByte, 12-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xDD, "Cache", "3rd-level cache: 3 MByte, 12-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xDE, "Cache", "3rd-level cache: 6 MByte, 12-way set associative, 64 byte line size"),
                // 0xDF
                // 0xE0
                // 0xE1
                new Tuple<byte, string, string>(0xE2, "Cache", "3rd-level cache: 2 MByte, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xE3, "Cache", "3rd-level cache: 4 MByte, 16-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xE4, "Cache", "3rd-level cache: 8 MByte, 16-way set associative, 64 byte line size"),
                // 0xE5
                // 0xE6
                // 0xE7
                // 0xE8
                // 0xE9
                new Tuple<byte, string, string>(0xEA, "Cache", "3rd-level cache: 12MByte, 24-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xEB, "Cache", "3rd-level cache: 18MByte, 24-way set associative, 64 byte line size"),
                new Tuple<byte, string, string>(0xEC, "Cache", "3rd-level cache: 24MByte, 24-way set associative, 64 byte line size"),
                // 0xED
                // 0xEE
                // 0xEF
                new Tuple<byte, string, string>(0xF0, "Prefetch", "64-Byte prefetching"),
                new Tuple<byte, string, string>(0xF1, "Prefetch", "128-Byte prefetching"),
                // 0xF2
                // 0xF3 
                // 0xF4
                // 0xF5
                // 0xF6
                // 0xF7
                // 0xF8
                // 0xF9
                // 0xFA
                // 0xFB
                // 0xFC
                // 0xFD
                // 0xFE
                new Tuple<byte, string, string>(0xFF, "General", "No information")
            };

            var match = cacheTable.FirstOrDefault(entry => entry.Item1 == value);

            return 
                match == null 
                    ? string.Empty 
                    : match.Item3;
        }
        
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetCacheDescriptions(CpuidResult): Returns a read-only collection containing the cache descriptions
        /// <summary>
        /// Returns a read-only collection containing the cache descriptions.
        /// </summary>
        /// <param name="info">Cpu register values</param>
        /// <returns>
        /// A read-only collection containing the cache descriptions.
        /// </returns>
        private static ReadOnlyCollection<string> GetCacheDescriptions(CpuidResult info)
        {
            var result = new List<string>();

            // Check the most-significant bit of all four registers (EAX, EBX, ECX, and EDX) is set to 0, indicating that each register contains valid 1-byte descriptors
            var eaxIsValid = info.eax.CheckBit(Bits.Bit31) == false;
            var ebxIsValid = info.ebx.CheckBit(Bits.Bit31) == false;
            var ecxIsValid = info.ecx.CheckBit(Bits.Bit31) == false;
            var edxIsValid = info.edx.CheckBit(Bits.Bit31) == false;

            if (eaxIsValid)
            {
                // Check the least-significant byte (byte 0) of register EAX is set to 01H.
                // This value should be ignored.
                var al = info.eax.GetByte(Bytes.Byte00);
                if (al != 0x01)
                {
                    return result.AsReadOnly();
                }

                // Evaluate EAX register
                var eaxValues = info.eax.ToArray();
                for (int i = 1; i < eaxValues.Length - 1; i++)
                {
                    var current = eaxValues[i];
                    if (current == 0x00 || current == 0xFF)
                    {
                        continue;
                    }

                    result.Add(GetCacheDescription(current));
                }
            }

            if (ebxIsValid)
            {
                // Evaluate EBX register
                var ebxValues = info.eax.ToArray();
                foreach (var value in ebxValues)
                {
                    if (value == 0x00 || value == 0xFF)
                    {
                        continue;
                    }

                    result.Add(GetCacheDescription(value));
                }
            }

            if (ecxIsValid)
            {
                // Evaluate ECX register
                var ecxValues = info.ecx.ToArray();
                foreach (var value in ecxValues)
                {
                    if (value == 0x00 || value == 0xFF)
                    {
                        continue;
                    }

                    result.Add(GetCacheDescription(value));
                }
            }

            if (edxIsValid)
            {
                // Evaluate EDX register
                var edxValues = info.edx.ToArray();
                foreach (var value in edxValues)
                {
                    if (value == 0x00 || value == 0xFF)
                    {
                        continue;
                    }

                    result.Add(GetCacheDescription(value));
                }
            }

            return result.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
