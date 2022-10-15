
What is iCPUID?
================

iCPUID is a lightweight cross-platform implementation that allows us to obtain the CPUID information. Works on Windows, Mac and Linux

Changes in this version (v1.0.5)
================================

· Critical
  --------

    - Important!!!

      Fixes an error caused in the previous version, the nuget packages were not updated correctly when creating the version

                                                I'm sorry for the inconveniences..
· Changed
  -------

 - Library versions for this version

    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core                                  2.0.0.5       Base library containing various extensions, helpers, common constants |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.Common                  1.0.0.4       Common Hardware Infrastructure                                        |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.CrossPlatform.Cpuid     1.0.0.0       Cross-Platform Generic Hardware Calls (CPUID)                         |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.CrossPlatform.Cpuid      1.0.0.0       Generic Cross-Platform Interop Calls (CPUID)                          |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.Shared                   1.0.0.3       Generic Shared Interop Definitions, Data Structures, Constants...     |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Hardware.Specification.Cpuid          1.0.0.2       CPUID Specification Implementation                                    |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Logging                               1.0.0.1       Logging library                                                       |
    ---------------------------------------------------------------------------------------------------------------------------------

v1.0.4
======

· Fixed
  -----
  
 - Fixes an issue that generates an exception when a property that returns an object of type QueryPropertyDictionaryResult not available.


· Added
  -----

  - Added support for netstandard2.1 
 
  - Add SplitEnumerator ref struct.
   
  - ByteReader class rewritten to work with Span in net core projects.

  - Added sample project for net60.


· Changed
  -------

 - Library versions for this version

    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core                                  2.0.0.4       Base library containing various extensions, helpers, common constants |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.Common                  1.0.0.3       Common Hardware Infrastructure                                        |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.CrossPlatform.Cpuid     1.0.0.0       Cross-Platform Generic Hardware Calls (CPUID)                         |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.CrossPlatform.Cpuid      1.0.0.0       Generic Cross-Platform Interop Calls (CPUID)                          |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.Shared                   1.0.0.2       Generic Shared Interop Definitions, Data Structures, Constants...     |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Hardware.Specification.Cpuid          1.0.0.2       CPUID Specification Implementation                                    |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Logging                               1.0.0.1       Logging library                                                       |
    ---------------------------------------------------------------------------------------------------------------------------------

v1.0.3
======

· Added
  -----

    - New Properties added

    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | Property                                                     Description                                                             Comments                                                            |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ProcessorInfoAndFeatures.Features.HYPERVISOR    Hypervisor present (always zero on physical CPUs)                       Thanks to @li-zhixin                                                |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_F                       AVX-512 Foundation                                                      https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_DQ                      AVX-512 Doubleword and Quadword Instructions                            https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_IFMA                    AVX-512 Integer Fused Multiply-Add Instructions                         https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.PCOMMIT                        PCOMMIT instruction                                                     https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_PF                      AVX-512 Prefetch Instructions                                           https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_ER                      AVX-512 Exponential and Reciprocal Instructions                         https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_CD                      AVX-512 Conflict Detection Instructions                                 https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_BW                      AVX-512 Byte and Word Instructions                                      https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VL                      AVX-512 Vector Length Extensions                                        https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VBMI                    AVX-512 Vector Bit Manipulation Instructions                            https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.WAITPKG                        Timed pause and user-level monitor/wait                                 https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VBMI2                   AVX-512 Vector Bit Manipulation Instructions 2                          https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.CET_SS                         Control flow enforcement (CET) shadow stack                             https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.GFNI                           Galois Field instructions                                               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.VAES                           Vector AES instruction set (VEX-256/EVEX)                               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.VPCLMULQDQ                     CLMUL instruction set (VEX-256/EVEX)                                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VNNI                    AVX-512 Vector Neural Network Instructions                              https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_BITALG                  AVX-512 BITALG instructions                                             https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VPOPCNTDQ               AVX-512 Vector Population Count Double and Quad-word                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.ITL_5_LEVELPG                  Intel 5-level paging                                                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.CLDEMOTE                       Cache line demote                                                       https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.MOVDIRI                        MOVDIRI                                                                 https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.MOVDIR64B                      MOVDIR64B                                                               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.ENQCMD                         Enqueue Stores                                                          https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.PKS                            Protection keys for supervisor-mode pages                               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_4VNNIW                  AVX-512 4-register Neural Network Instructions                          https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_4FMAPS                  AVX-512 4-register Multiply Accumulation Single precision               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.FSRM                           Fast Short REP MOVSB                                                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_VP2INTERSECT            AVX-512 VP2INTERSECT Doubleword and Quadword Instructions               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.SRBDS_CTRL                     Special Register Buffer Data Sampling Mitigations                       https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.MD_CLEAR                       VERW instruction clears CPU buffers                                     https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.TSX_FORCE_ABORT                TSX_FORCE_ABORT                                                         https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.SERIALIZE                      SERIALIZE                                                               https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.HYBRID                         Hybrid                                                                  https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.TSXLDTRK                       TSX suspend load address tracking                                       https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.PCONFIG                        Platform configuration (Memory Encryption Technologies Instructions)    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.LBR                            Architectural Last Branch Records                                       https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.CET_IBT                        Control flow enforcement (CET) indirect branch tracking                 https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AMX_BF16                       Tile computation on bfloat16 numbers                                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AMX_TILE                       Tile architecture                                                       https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AMX_INT8                       Tile computation on 8-bit integers                                      https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.IBRS_IBPB                      Speculation Control, part of Indirect Branch Control (IBC)              https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.STIBP                          Single Thread Indirect Branch Predictor, part of IBC                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.L1D_FLUSH                      IA32_FLUSH_CMD MSR                                                      https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.IA32_ARCH_CAPABILITIES         Speculative Side Channel Mitigations                                    https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.IA32_CORE_CAPABILITIES         Support for a MSR listing model-specific core capabilities              https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.SSBD                           Speculative Store Bypass Disable                                        https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    | LeafProperty.ExtendedFeatures.AVX512_BF16                    AVX-512 BFLOAT16 instructions                                           https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    - Library documentation.

    - Tools folder in solution root. Contains a script for update help md files.

· Changed
  -------
  
    - Changed IResultGeneric interface. Changed Value property name by Result (for code clarify).

      · This change may have implications in your final code, it is resolved by changing Value to Result

    - Update result classes for support more scenaries.

    - Library versions for this version

    -----------------------------------------------------------------------------------------------------------------------------------
    | Library                                    Version        Description                                                           |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Core                                  2.0.0.3        Base library containing various extensions, helpers, common constants |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Core.Hardware.Common                  1.0.0.2        Common Hardware Infrastructure                                        |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Core.Hardware.CrossPlatform.Cpuid     1.0.0.0        Cross-Platform Generic Hardware Calls (CPUID)                         |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Core.Interop.CrossPlatform.Cpuid      1.0.0.0        Generic Cross-Platform Interop Calls (CPUID)                          |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Core.Interop.Shared                   1.0.0.0        Generic Shared Interop Definitions, Data Structures, Constants...     |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Hardware.Specification.Cpuid          1.0.0.2        CPUID Specification Implementation                                    |
    -----------------------------------------------------------------------------------------------------------------------------------
    | iTin.Logging                               1.0.0.0        Logging library                                                       |
    -----------------------------------------------------------------------------------------------------------------------------------

v1.0.2
======

· Added
  -----

    - Library documentation.

    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core                                  2.0.0.1       Base library containing various extensions, helpers, common constants |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.Common                  1.0.0.1       Common Hardware Infrastructure                                        |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.CrossPlatform.Cpuid     1.0.0.0       Cross-Platform Generic Hardware Calls (CPUID)                         |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.CrossPlatform.Cpuid      1.0.0.0       Generic Cross-Platform Interop Calls (CPUID)                          |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.Shared                   1.0.0.0       Generic Shared Interop Definitions, Data Structures, Constants...     |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Hardware.Specification.Cpuid          1.0.0.1       CPUID Specification Implementation                                    |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Logging                               1.0.0.0       Logging library                                                       |
    ---------------------------------------------------------------------------------------------------------------------------------

· Removed
  -------

    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.CrossPlatform           1.0.0.0       Hardware Cross-Platform Interop Calls                                 |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.CrossPlatform            1.0.0.0       Generic Cross-Platform Interop Calls                                  |
    ---------------------------------------------------------------------------------------------------------------------------------


v1.0.1
======

    Library versions
    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core                                  2.0.0.0       Base library containing various extensions, helpers, common constants |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.Common                  1.0.0.0       Common Hardware Infrastructure                                        |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Hardware.CrossPlatform           1.0.0.0       Hardware Cross-Platform Interop Calls                                 |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Core.Interop.CrossPlatform            1.0.0.0       Generic Cross-Platform Interop Calls                                  |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Hardware.Specification.Cpuid          1.0.0.0       CPUID Specification Implementation                                    |
    ---------------------------------------------------------------------------------------------------------------------------------
    |iTin.Logging                               1.0.0.0       Logging library                                                       |
    ---------------------------------------------------------------------------------------------------------------------------------


    Native library versions
    =======================

    ---------------------------------------------------------------------------------------------------------------------------------
    | Library                                   Version       Description                                                           |
    ---------------------------------------------------------------------------------------------------------------------------------
    |cpuid                                      0.0.1.0       Native calls (CPUID instruction calls)                                |
    ---------------------------------------------------------------------------------------------------------------------------------

    The code of the native cpuid library, is available in the github repository at the following link: 
    https://github.com/iAJTin/iCPUID/tree/master/src/lib/rust/cpuid

    The code is developed in the Rust language, to know how to install, edit and use this code please see the cpuid.md file in the following link
    https://github.com/iAJTin/iCPUID/blob/master/src/lib/rust/cpuid.md


Install via NuGet
=================

PM> Install-Package iCPUID

For more information, please see https://www.nuget.org/packages/iCPUID/


Usage
=====

Call CPUID.Instance.Leafs for getting all CPUID implemented leafs.

Examples
--------

1.  Detection of the availability of the CPUID instruction

    CPUID cpuid = CPUID.Instance;
    Console.WriteLine($@" Is Available > {cpuid.IsAvailable}");

2. Gets and prints all CPUID implemented leafs.

    CPUID cpuid = CPUID.Instance;
    ReadOnlyCollection<Leaf> leafs = cpuid.ImplementedLeafs;
    foreach (Leaf leaf in leafs)
    {
        Console.WriteLine($@" {(int)leaf:X8}-{leaf}");
    }

3. Gets and prints all CPUID implemented leafs > sub-leafs.

    CPUID cpuid = CPUID.Instance;
    ReadOnlyCollection<Leaf> leafs = cpuid.ImplementedLeafs;
    foreach (var (leaf, subLeafs) in leafs)
    {
        Console.WriteLine($@" > {leaf} (EAX={(int)leaf:X8})");

        foreach (var subLeaf in subLeafs)
        {
            Console.WriteLine($@"   > {subLeaf.SubLeaf} (ECX={(int)subLeaf.SubLeaf:X8})");
        }
    }

4. Gets and prints all CPUID implemented leafs > sub-leafs (shows description).

    CPUID cpuid = CPUID.Instance;
    ReadOnlyCollection<Leaf> leafs = cpuid.ImplementedLeafs;
    foreach (var (leaf, subLeafs) in leafs)
    {
        Console.WriteLine($@" > {leaf} (EAX={(int)leaf:X8})");

        foreach (var subLeaf in subLeafs)
        {
            Console.WriteLine($@"   > {subLeaf.SubLeaf} (ECX={(int)subLeaf.SubLeaf:X8})");
            IEnumerable<IPropertyKey> properties = subLeaf.ImplementedProperties;
            foreach (var property in properties)
            {
                string friendlyName = GetFriendlyName(property);
                PropertyUnit unit = property.PropertyUnit;
                string description = property.GetPropertyDescription();

                Console.WriteLine($@"     > {friendlyName} {(unit == PropertyUnit.None ? string.Empty : $"({unit})")}: {description}");
            }
        }
    }

5. Gets and prints all CPUID implemented leafs > sub-leafs (values).

    CPUID cpuid = CPUID.Instance;
    ReadOnlyCollection<Leaf> leafs = cpuid.ImplementedLeafs;
    foreach (var (leaf, subLeafs) in leafs)
    {
        Console.WriteLine($@" > {leaf} (EAX={(int)leaf:X8})");

        foreach (var subLeaf in subLeafs)
        {
            Console.WriteLine($@"   > {subLeaf.SubLeaf} (ECX={(int)subLeaf.SubLeaf:X8})");
            IEnumerable<IPropertyKey> properties = subLeaf.ImplementedProperties;
            foreach (var property in properties)
            {
                QueryPropertyResult queryResult = subLeaf.GetProperty(property);
                PropertyItem propertyItem = queryResult.Value;
                object value = propertyItem.Value;
                string friendlyName = GetFriendlyName(property);
                PropertyUnit valueUnit = property.PropertyUnit;
                string unit = valueUnit == PropertyUnit.None ? string.Empty : valueUnit.ToString();

                if (value == null)
                {
                    Console.WriteLine($@"     > {friendlyName}: NULL");
                    continue;
                }

                if (value is bool)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} [{((bool)value ? 1 : 0)}]");
                }
                else if (value is string)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit}");
                }
                else if (value is byte)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit} [{value:X2}h]");
                }
                else if (value is int)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit} [{value:X4}h]");
                }
                else if (value is uint)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit} [{value:X4}h]");
                }
                else if (value is ulong)
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit} [{value:X8}h]");
                }
                else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                {
                    Console.WriteLine($@"     > {friendlyName}");
                    var collection = (ReadOnlyCollection<string>)value;
                    foreach (var entry in collection)
                    {
                        Console.WriteLine($@"       > {entry} {unit}");
                    }
                }
                else
                {
                    Console.WriteLine($@"     > {friendlyName}: {value} {unit}");
                }
            }
        }
    }

6. Gets a single property directly.

    CPUID cpuid = CPUID.Instance;
    QueryPropertyResult manufacturerQueryResult = cpuid.Leafs.GetProperty(LeafProperty.BasicInformation.Manufacturer);
    if (manufacturerQueryResult.Success)
    {
        Console.WriteLine($@" > Manufacturer: {manufacturerQueryResult.Value.Value}");
    }

    QueryPropertyResult avx2 = cpuid.Leafs.GetProperty(LeafProperty.ExtendedFeatures.AVX2);
    if (avx2.Success)
    {
        Console.WriteLine($@" > AVX2: {avx2.Value.Value}");
    }

7. Gets a property in multiple elements directly.

    CPUID cpuid = CPUID.Instance;
    QuerySubLeafPropertyCollectionResult cacheSizesQueryResult = leafs.GetProperties(LeafProperty.DeterministicCacheParameters.CacheSize);
    if (cacheSizesQueryResult.Success)
    {
        CpuidSubLeafDictionary cacheSizes = cacheSizesQueryResult.Value;
        bool hasCacheSizesEntries = cacheSizes.Any();
        if (!hasCacheSizesEntries)
        {
            Console.WriteLine($@" > Sorry, The 'LeafProperty.DeterministicCacheParameters.CacheSize' property has not implementes on this system");
        }
        else
        {
            foreach (var (subLeaf, propertyItem) in cacheSizes)
            {
                Console.WriteLine($@" > Cache Size:  ({subLeaf}) > {propertyItem.Value}");
            }
        }
    }

Documentation
==============

 - For full code documentation, please see next link https://github.com/iAJTin/iCPUID/blob/master/documentation/iTin.Hardware.Specification.Cpuid.md.
