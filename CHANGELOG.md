# Changelog
All notable changes to this project will be documented in this file.

## [1.0.6] - 

### Fix

 - Fix **ACPI** property key documentation in **Features** section of **ProcessorInfoAndFeatures** leaf :
 
### Changed
  
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| 2.0.0.5 | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| 1.0.0.4 | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform.Cpuid| 1.0.0.0 | Cross-Platform Generic Hardware Calls (CPUID) |
    |iTin.Core.Interop.CrossPlatform.Cpuid| 1.0.0.0 |Generic Cross-Platform Interop Calls (CPUID) |
    |iTin.Core.Interop.Shared| 1.0.0.3| Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Hardware.Specification.Cpuid| **1.0.0.3** | CPUID Specification Implementation |
    |iTin.Logging| 1.0.0.1 | Logging library |
 

## [1.0.5] - 2022-10-15

## Critical

- **Important!!!**

  **Fixes an error caused in the previous version, the nuget packages were not updated correctly when creating the version**

  **I'm sorry for the inconveniences...**

### Changed
   
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| **2.0.0.5** | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| **1.0.0.4** | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform.Cpuid| 1.0.0.0 | Cross-Platform Generic Hardware Calls (CPUID) |
    |iTin.Core.Interop.CrossPlatform.Cpuid| 1.0.0.0 |Generic Cross-Platform Interop Calls (CPUID) |
    |iTin.Core.Interop.Shared| **1.0.0.3**| Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Hardware.Specification.Cpuid| 1.0.0.2 | CPUID Specification Implementation |
    |iTin.Logging| 1.0.0.1 | Logging library |

## [1.0.4] - 2022-10-14

### Fixed

 - Fixes an issue that generates an exception when a property that returns an object of type QueryPropertyDictionaryResult not available.

### Added

- Added support for **netstandard2.1** 
 
   - Add **SplitEnumerator** ref struct.
   
   - **ByteReader** class rewritten to work with **Span** in net core projects.

- Added sample project for **net60**

### Changed
  
 - Changed **```IResultGeneric```** interface. Changed **```Value```** property name by **```Result```** (for code clarify).
 
       This change may have implications in your final code, it is resolved by changing Value to Result
 
 - Update result classes for support more scenaries.
 
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| **2.0.0.4** | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| **1.0.0.3** | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform.Cpuid| 1.0.0.0 | Cross-Platform Generic Hardware Calls (CPUID) |
    |iTin.Core.Interop.CrossPlatform.Cpuid| 1.0.0.0 |Generic Cross-Platform Interop Calls (CPUID) |
    |iTin.Core.Interop.Shared| **1.0.0.2** | Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Hardware.Specification.Cpuid| **1.0.0.2** | CPUID Specification Implementation |
    |iTin.Logging| **1.0.0.1** | Logging library |

## [1.0.3] - 2020-12-11

### Added

 - New Properties added
    
    | Property | Description | Comments |
    |:------|:------|:------|
    |LeafProperty.ProcessorInfoAndFeatures.Features.HYPERVISOR |  Hypervisor present (always zero on physical CPUs) | Thanks to [@li-zhixin](https://github.com/li-zhixin) |
    |LeafProperty.ExtendedFeatures.AVX512_F | AVX-512 Foundation | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_DQ | AVX-512 Doubleword and Quadword Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_IFMA | AVX-512 Integer Fused Multiply-Add Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.PCOMMIT | PCOMMIT instruction | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_PF | AVX-512 Prefetch Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_ER | AVX-512 Exponential and Reciprocal Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_CD | AVX-512 Conflict Detection Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_BW | AVX-512 Byte and Word Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VL | AVX-512 Vector Length Extensions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VBMI | AVX-512 Vector Bit Manipulation Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.WAITPKG | Timed pause and user-level monitor/wait | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VBMI2 | AVX-512 Vector Bit Manipulation Instructions 2 | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.CET_SS | Control flow enforcement (CET) shadow stack | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.GFNI | Galois Field instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.VAES | Vector AES instruction set (VEX-256/EVEX) | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.VPCLMULQDQ | CLMUL instruction set (VEX-256/EVEX) | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VNNI | AVX-512 Vector Neural Network Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_BITALG | AVX-512 BITALG instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VPOPCNTDQ | AVX-512 Vector Population Count Double and Quad-word | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.ITL_5_LEVELPG | Intel 5-level paging | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.CLDEMOTE | Cache line demote | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.MOVDIRI | MOVDIRI | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.MOVDIR64B | MOVDIR64B | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.ENQCMD | Enqueue Stores | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.PKS | Protection keys for supervisor-mode pages | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_4VNNIW | AVX-512 4-register Neural Network Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_4FMAPS | AVX-512 4-register Multiply Accumulation Single precision | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.FSRM | Fast Short REP MOVSB | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_VP2INTERSECT | AVX-512 VP2INTERSECT Doubleword and Quadword Instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.SRBDS_CTRL | Special Register Buffer Data Sampling Mitigations | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.MD_CLEAR | VERW instruction clears CPU buffers | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.TSX_FORCE_ABORT | TSX_FORCE_ABORT | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.SERIALIZE | SERIALIZE | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.HYBRID | Hybrid | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.TSXLDTRK | TSX suspend load address tracking | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.PCONFIG | Platform configuration (Memory Encryption Technologies Instructions) | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.LBR | Architectural Last Branch Records | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.CET_IBT | Control flow enforcement (CET) indirect branch tracking | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AMX_BF16 | Tile computation on bfloat16 numbers | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AMX_TILE | Tile architecture | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AMX_INT8 | Tile computation on 8-bit integers | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.IBRS_IBPB | Speculation Control, part of Indirect Branch Control (IBC) | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.STIBP | Single Thread Indirect Branch Predictor, part of IBC | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.L1D_FLUSH | IA32_FLUSH_CMD MSR | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.IA32_ARCH_CAPABILITIES | Speculative Side Channel Mitigations | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.IA32_CORE_CAPABILITIES | Support for a MSR listing model-specific core capabilities | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.SSBD | Speculative Store Bypass Disable | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |
    |LeafProperty.ExtendedFeatures.AVX512_BF16 | AVX-512 BFLOAT16 instructions | https://en.wikipedia.org/wiki/CPUID#EAX=7,_ECX=0:_Extended_Features |

 - Library documentation.
 
 - ```tools``` folder in solution root. Contains a script for update help md files.

### Changed
  
 - Changed **```IResultGeneric```** interface. Changed **```Value```** property name by **```Result```** (for code clarify).
 
       This change may have implications in your final code, it is resolved by changing Value to Result
 
 - Update result classes for support more scenaries.
 
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| **2.0.0.3** | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| **1.0.0.2** | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform.Cpuid| 1.0.0.0 | Cross-Platform Generic Hardware Calls (CPUID) |
    |iTin.Core.Interop.CrossPlatform.Cpuid| 1.0.0.0 |Generic Cross-Platform Interop Calls (CPUID) |
    |iTin.Core.Interop.Shared| 1.0.0.0 | Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Hardware.Specification.Cpuid| **1.0.0.2** | CPUID Specification Implementation |
    |iTin.Logging| 1.0.0.0 | Logging library |

## [1.0.2] - 2020-10-12

### Added
  
 - Adds support for Linux and Mac
 
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| **2.0.0.1** | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| **1.0.0.1** | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform.Cpuid| 1.0.0.0 | Cross-Platform Generic Hardware Calls (CPUID) |
    |iTin.Core.Interop.CrossPlatform.Cpuid| 1.0.0.0 |Generic Cross-Platform Interop Calls (CPUID) |
    |iTin.Core.Interop.Shared| 1.0.0.0 | Generic Shared Interop Definitions, Data Structures, Constants... |
    |iTin.Hardware.Specification.Cpuid| **1.0.0.1** | CPUID Specification Implementation |
    |iTin.Logging| 1.0.0.0 | Logging library |

### Removed

 - Removed libraries
 
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core.Hardware.CrossPlatform| 1.0.0.0 | Hardware Cross-Platform Interop Calls |
    |iTin.Core.Interop.CrossPlatform| 1.0.0.0 | Generic Cross-Platform Interop Calls |


## 1.0.1

### Added
  
 - Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| 2.0.0.0 | Base library containing various extensions, helpers, common constants |
    |iTin.Core.Hardware.Common| 1.0.0.0 | Common Hardware Infrastructure |
    |iTin.Core.Hardware.CrossPlatform| 1.0.0.0 | Hardware Cross-Platform Interop Calls |
    |iTin.Core.Interop.CrossPlatform| 1.0.0.0 | Generic Cross-Platform Interop Calls |
    |iTin.Hardware.Specification.Cpuid| 1.0.0.0 | CPUID Specification Implementation |
    |iTin.Logging| 1.0.0.0 | Logging library |

 - Native library versions
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |cpuid| 0.0.1.0 | Native calls (CPUID instruction calls) |

   The code of the native cpuid library, is available in the github repository at the following link: 
https://github.com/iAJTin/iCPUID/tree/master/src/lib/rust/cpuid

   The code is developed in the **Rust language**, to know how to install, edit and use this code please see the cpuid.md file in the following link
https://github.com/iAJTin/iCPUID/blob/master/src/lib/rust/cpuid.md


## [1.0.0] - 2020-08-28

 - This version is for Win32 only.

### Added

- Adds descriptive code help. I Tried to adds a help most descriptive for the properties keys. 
 
  - The image below shows an example.

    ![Help.png][help] 

- Library versions for this version
  
    |Library|Version|Description|
    |:------|:------|:----------|
    |iTin.Core| 1.0.2 | Common calls |
    |iTin.Core.Interop| 1.0.0 | Interop calls |
    |iTin.Core.Hardware| 1.0.1 | Hardware Interop Calls |
    |iTin.Core.Hardware.Specification.Cpuid|1.0.0| CPUID Specification Implementation |

- Solution structure, prepare solution structure to add future new specifications.

      \root
        - lib
          - iTin.Core             
            - iTin.Core                                [Common Calls] 
            - iTin.Core.Interop                        [Interop Calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                       [Hardware Interop Calls]
          - iTin.Core.Hardware.Specification   
            - iTin.Core.Hardware.Specification.Cpuid   [CPUID Specification Implementation] 
        - test
            - iCPUID.ConsoleApp                        [Console Test App]


[1.0.6]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.6
[1.0.5]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.5
[1.0.4]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.4
[1.0.3]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.0

[help]: ./assets/help.png "help"
