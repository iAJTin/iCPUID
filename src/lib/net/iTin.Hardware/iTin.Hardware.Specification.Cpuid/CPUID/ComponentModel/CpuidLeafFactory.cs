
using System.Collections.Generic;

using iTin.Core;
using iTin.Core.Hardware.CrossPlatform.Cpuid;
using iTin.Core.Helpers.Enumerations;
using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// The static class <see cref="CpuidLeafFactory"/> creates the <see cref="CPUID"/> leafs.
/// </summary>
internal static class CpuidLeafFactory
{
    /// <summary>
    /// Create list of available leafs.
    /// </summary>
    /// <param name="data">Leaf information.</param>
    /// <returns>
    /// An enumerator, which supports a simple iteration in the collection of leafs.
    /// </returns>
    public static IEnumerable<LeafBase> Create(CpuidLeafContent data)
    {
        var parseProperties = new List<LeafBase>();
        var subleafsNumber = DetermineSubLeafs(data.Leaf);
        for (var i = 1; i <= subleafsNumber; i++)
        {
            var subLeaf = (SubLeaf)(i - 1);
            switch (data.Leaf)
            {
                case Leaf.BasicInformation:
                    parseProperties.Add(new Leaf00000000(data, subLeaf));
                    break;

                case Leaf.ProcessorInfoAndFeatures:
                    parseProperties.Add(new Leaf00000001(data, subLeaf));
                    break;

                case Leaf.CacheInformation:
                    parseProperties.Add(new Leaf00000002(data, subLeaf));
                    break;

                case Leaf.ProcessorSerialNumber:
                    parseProperties.Add(new Leaf00000003(data, subLeaf));
                    break;

                case Leaf.DeterministicCacheParameters:
                    parseProperties.Add(new Leaf00000004(data, subLeaf));
                    break;

                case Leaf.MonitorAndMwaitFeatures:
                    parseProperties.Add(new Leaf00000005(data, subLeaf));
                    break;

                case Leaf.ThermalAndPowerManagementFeatures:
                    parseProperties.Add(new Leaf00000006(data, subLeaf));
                    break;

                case Leaf.ExtendedFeatures:
                    parseProperties.Add(new Leaf00000007(data, subLeaf));
                    break;

                case Leaf.DirectCacheAccessInformation:
                    parseProperties.Add(new Leaf00000009(data, subLeaf));
                    break;

                case Leaf.ArchitecturalPerformanceMonitoringFeatures:
                    parseProperties.Add(new Leaf0000000A(data, subLeaf));
                    break;

                case Leaf.ExtendedTopologyInformation:
                    parseProperties.Add(new Leaf0000000B(data, subLeaf));
                    break;

                case Leaf.ProcessorExtendedStatesInformation:
                    parseProperties.Add(new Leaf0000000D(data, subLeaf));
                    break;

                case Leaf.ResourceDirectorTechnologyMonitoring:
                    parseProperties.Add(new Leaf0000000F(data, subLeaf));
                    break;

                case Leaf.ResourceDirectorTechnologyAllocation:
                    parseProperties.Add(new Leaf00000010(data, subLeaf));
                    break;

                case Leaf.Sgx:
                    parseProperties.Add(new Leaf00000012(data, subLeaf));
                    break;

                case Leaf.ProcessorTraceEnumerationInformation:
                    parseProperties.Add(new Leaf00000014(data, subLeaf));
                    break;

                case Leaf.TimeStampCounterAndNominalCoreCrystalClock:
                    parseProperties.Add(new Leaf00000015(data, subLeaf));
                    break;

                case Leaf.ProcessorFrequencyInformation:
                    parseProperties.Add(new Leaf00000016(data, subLeaf));
                    break;

                case Leaf.SystemOnChipInformation:
                    parseProperties.Add(new Leaf00000017(data, subLeaf));
                    break;

                case Leaf.HighestExtendedFunctionImplemented:
                    parseProperties.Add(new Leaf80000000(data, subLeaf));
                    break;

                case Leaf.ExtendedProcessorInfoAndFeatures:
                    parseProperties.Add(new Leaf80000001(data, subLeaf));
                    break;

                case Leaf.ProcessorBrandString:
                    parseProperties.Add(new Leaf80000002(data, subLeaf));
                    break;

                case Leaf.ProcessorBrandString1:
                    parseProperties.Add(new Leaf80000003(data, subLeaf));
                    break;

                case Leaf.ProcessorBrandString2:
                    parseProperties.Add(new Leaf80000004(data, subLeaf));
                    break;

                case Leaf.L1CacheAndTlbIdentifiers:
                    parseProperties.Add(new Leaf80000005(data, subLeaf));
                    break;

                case Leaf.ExtendedL2CacheFeatures:
                    parseProperties.Add(new Leaf80000006(data, subLeaf));
                    break;

                case Leaf.AdvancedPowerManagement:
                    parseProperties.Add(new Leaf80000007(data, subLeaf));
                    break;

                case Leaf.VirtualAndPhysicalAddressSizes:
                    parseProperties.Add(new Leaf80000008(data, subLeaf));
                    break;

                case Leaf.AmdEasterEgg:
                    parseProperties.Add(new Leaf8FFFFFFFF(data, subLeaf));
                    break;
            }
        }

        return parseProperties;
    }


    /// <summary>
    /// Returns a value containing the sub-leafs to create.
    /// </summary>
    /// <param name="leaf">Leaf information.</param>
    /// <returns>
    /// A <see cref="int"/> containing the sub-leafs to create.
    /// </returns>
    private static uint DetermineSubLeafs(Leaf leaf)
    {
        switch (leaf)
        {
            case Leaf.ExtendedFeatures:
            case Leaf.DeterministicCacheParameters:
            case Leaf.ProcessorExtendedStatesInformation:
            {
                uint subLeaf = 0;
                while (true)
                {
                    CpuidResult result = SafeCpuidNativeMethods.Invoke((uint) leaf, subLeaf);
                    if (result.IsEmpty)
                    {
                        break;
                    }

                    subLeaf++;
                }

                return subLeaf;
            }

            case Leaf.ExtendedTopologyInformation:
            {
                uint subLeaf = 0;
                while (true)
                {
                    CpuidResult result = SafeCpuidNativeMethods.Invoke((uint)leaf, subLeaf);
                    if (result.eax == 0 && result.ebx == 0)
                    {
                        break;
                    }

                    subLeaf++;
                }

                return subLeaf;
            }

            case Leaf.ResourceDirectorTechnologyMonitoring:
            {
                CpuidResult result = SafeCpuidNativeMethods.Invoke((uint)leaf);
                return result.edx.CheckBit(Bits.Bit01) ? (uint) 2 : (uint) 1;
            }

            case Leaf.ResourceDirectorTechnologyAllocation:
            {
                uint resId = 1;
                CpuidResult result = SafeCpuidNativeMethods.Invoke((uint)leaf);

                var supportL3CacheAllocation = result.ebx.CheckBit(Bits.Bit01);
                if (supportL3CacheAllocation)
                {
                    resId++;
                }

                var supportL2CacheAllocation = result.ebx.CheckBit(Bits.Bit02);
                if (supportL2CacheAllocation)
                {
                    resId++;
                }

                return resId;
            }

            case Leaf.SystemOnChipInformation:
            case Leaf.ProcessorTraceEnumerationInformation:
                return SafeCpuidNativeMethods.Invoke((uint)leaf).eax + 1;

            case Leaf.Sgx:
            {
                uint subLeaf = 1;
                CpuidResult result = SafeCpuidNativeMethods.Invoke((uint)leaf);
                var supportSGX1 = result.eax.CheckBit(Bits.Bit00);
                if (supportSGX1)
                {
                    subLeaf++;
                }

                var supportSGX2 = result.eax.CheckBit(Bits.Bit01);
                if (supportSGX2)
                {
                    subLeaf++;
                }

                return subLeaf;
            }

            default:
                return 1;
        }
    }
}
