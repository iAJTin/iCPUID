﻿
using System;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Cpuid;

// Leaf 0x00000004: Deterministic Cache Parameters 
//
// •—INPUT—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = 0x00000004                                                                                                      |
// | ECX = 0..n  If (n) contains an invalid value => EAX/EBX/ECX/EDX = 0                                                   |
// |                                                                                                                       |
// •—OUTPUT————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EAX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      04:00  Cache Type Field.                                                                                         |
// |      07:05  Cache Level (starts at 1).                                                                                |
// |         08  Self Initializing cache level (does not need SW initialization).                                          |
// |         09  Fully Associative cache.                                                                                  |
// |      13:10  Reserved                                                                                                  |
// |      25:14  Maximum number of addressable IDs for logical processors sharing this cache, See Notes (1, 2).            |
// |      31:26  Maximum number of addressable IDs for processor cores in the physical package, See Notes (1, 3).          |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EBX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |      11:00  L = System Coherency Line Size See (**).                                                                  |
// |      21:12  P = Physical Line partitions See (**).                                                                    |
// |      31:22  W = Ways of associativity See (**).                                                                       |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | ECX = S = Number of Sets See (**).                                                                                    |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// | EDX = Information                                                                                                     |
// |                                                                                                                       |
// |       Bits  Value                                                                                                     |
// |         00  Write-Back Invalidate/Invalidate.                                                                         |
// |             0 = WBINVD/INVD from threads sharing this cache acts upon lower level caches for threads sharing this     |
// |                 cache.                                                                                                |
// |             1 = WBINVD/INVD is not guaranteed to act upon lower level caches of non-originating threads sharing this  |
// |                 cache.                                                                                                |
// |         01  Cache Inclusiveness.                                                                                      |
// |             0 = Cache is not inclusive of lower cache levels.                                                         |
// |             1 = Cache is inclusive of lower cache levels.                                                             |
// |         02  Complex Cache Indexing.                                                                                   |
// |             0 = Direct mapped cache.                                                                                  |
// |             1 = A complex function is used to index the cache, potentially using all address bits.                    |
// |      31:03  Reserved (0).                                                                                             |
// |                                                                                                                       |
// •—NOTES—————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |                                                                                                                       |
// |   (1) Add one to the return value to get the result.                                                                  |
// |                                                                                                                       |
// |   (2) The nearest power-of-2 integer that is not smaller than (1 + EAX[25:14]) is the number of unique initial APIC   |
// |       IDs reserved for addressing different logical processors sharing this cache.                                    |
// |                                                                                                                       |
// |   (3) The nearest power-of-2 integer that is not smaller than (1 + EAX[31:26]) is the number of unique Core_IDs       |
// |       reserved for addressing different processor cores in a physical package.Core ID is a subset of bits of the      |
// |       initial APIC ID.                                                                                                |
// |                                                                                                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="LeafBase"/> class that contains the logic to decode the <strong>Deterministic Cache Parameters</strong>.
/// </summary>
internal sealed class Leaf00000004 : LeafBase
{
    #region private constants

    #region generic
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const double Log2 = 0.30102999566398119521373889472449;
    #endregion

    #region register EAX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits SLF_NTLZNG_CCH_LVL = Bits.Bit08; // 08 - Self Initializing cache level (does not need SW initialization)
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits FLL_SSCTV_CCH = Bits.Bit09;      // 09 - Fully Associative cache
    #endregion

    #region register EDX definition
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits WRT_BCK = Bits.Bit00;          // 00 - Write-Back Invalidate/Invalidate
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CCH_NCLSV = Bits.Bit01;        // 01 - Cache is inclusive of lower cache levels
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] private const Bits CMPLX_CCH_INDXNG = Bits.Bit02; // 02 - Complex Cache Indexing
    #endregion

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="Leaf00000004"/> class.
    /// </summary>
    /// <param name="data">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    public Leaf00000004(CpuidLeafContent data, SubLeaf subLeaf = SubLeaf.Main) 
        : base(data, subLeaf)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Cache Level</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte CacheLevel => (byte)((InvokeResult.eax >> 5) & 0x07);

    /// <summary>
    /// Gets a value representing the <strong>Cache Size</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint CacheSize => (w + 1) * (p + 1) * (l + 1) * (s + 1);

    /// <summary>
    /// Gets a value representing the <strong>Cache Type</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte CacheType => (byte)(InvokeResult.eax & 0x1f);

    /// <summary>
    /// Gets a value representing the <strong>System Coherency Line Size</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint l => InvokeResult.ebx & 0xfff;

    /// <summary>
    /// Gets a value representing the <strong>Physical Line partitions</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint p => (InvokeResult.ebx >> 12) & 0x3ff;

    /// <summary>
    /// Gets a value representing the <strong>Ways of associativity</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint w => (InvokeResult.ebx >> 22) & 0x3ff;

    /// <summary>
    /// Gets a value representing the <strong>Number of Sets</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint s => InvokeResult.ecx;

    /// <summary>
    /// Gets a value representing the <strong>Maximum Number Addressable Logical Processors</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte MaximumLogicalProcessorCores => (byte)((InvokeResult.eax >> 14) & 0xfff);

    /// <summary>
    /// Gets a value representing the <strong>Maximum Number Addressable Processor Cores Physical</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte MaximumPhysicalProcessorCores => (byte)((InvokeResult.eax >> 26) & 0x3f);

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected override void PopulateProperties(CpuidPropertiesTable properties)
    {
        properties.Add(LeafProperty.DeterministicCacheParameters.CacheSize, CacheSize);
        properties.Add(LeafProperty.DeterministicCacheParameters.CacheLevel, CacheLevel);
        properties.Add(LeafProperty.DeterministicCacheParameters.CacheType, GetCacheType(CacheType));
        properties.Add(LeafProperty.DeterministicCacheParameters.WriteBack, InvokeResult.edx.CheckBit(WRT_BCK));
        properties.Add(LeafProperty.DeterministicCacheParameters.UseDirectMappedCache, InvokeResult.edx.CheckBit(CMPLX_CCH_INDXNG));
        properties.Add(LeafProperty.DeterministicCacheParameters.IsFullyAssociativeCache, InvokeResult.eax.CheckBit(FLL_SSCTV_CCH));
        properties.Add(LeafProperty.DeterministicCacheParameters.IsCacheInclusiveOfLowerLevels, InvokeResult.edx.CheckBit(CCH_NCLSV));
        properties.Add(LeafProperty.DeterministicCacheParameters.IsSelfInitializingCacheLevel, InvokeResult.eax.CheckBit(SLF_NTLZNG_CCH_LVL));
        properties.Add(LeafProperty.DeterministicCacheParameters.MaximumLogicalProcessorCores, (byte)(Math.Log(MaximumLogicalProcessorCores + 1) / Log2));
        properties.Add(LeafProperty.DeterministicCacheParameters.MaximumPhysicalProcessorCores, (byte)(Math.Log(MaximumPhysicalProcessorCores + 1) / Log2));
    }

    #endregion


    #region CPUID Specification

    /// <summary>
    /// Returns the cache type.
    /// </summary>
    /// <param name="code">Value to analyze</param>
    /// <returns>
    /// A <see cref="string"/> containing the cache type.
    /// </returns>
    private static string GetCacheType(byte code)
    {
        string[] cacheType =
        [
            "No more caches.",   // 00
            "Data Cache",
            "Instruction Cache", 
            "Unified Cache"      // 03
        ];

        return code > 0x03 
            ? "Reserved" 
            : cacheType[code];
    }

    #endregion
}
