# Changelog
All notable changes to this project will be documented in this file.

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


[1.0.2]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iCPUID/releases/tag/v1.0.0

[help]: ./assets/help.png "help"
