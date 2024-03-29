# iTin.Hardware.Specification.Cpuid assembly

## iTin.Hardware.Specification namespace

| public type | description |
| --- | --- |
| class [CPUID](./iTin.Hardware.Specification/CPUID.md) | CPUID—CPU Identification. CPUID returns processor identification and feature information. |

## iTin.Hardware.Specification.Cpuid namespace

| public type | description |
| --- | --- |
| struct [CpuidLeafContent](./iTin.Hardware.Specification.Cpuid/CpuidLeafContent.md) | Defines the content of a leaf. |
| class [CpuidLeafDictionary](./iTin.Hardware.Specification.Cpuid/CpuidLeafDictionary.md) | Represents a dictionary for keys [`Leaf`](./iTin.Hardware.Specification.Cpuid/Leaf.md) and values [`CpuidSubLeafCollection`](./iTin.Hardware.Specification.Cpuid/CpuidSubLeafCollection.md). |
| class [CpuidPropertiesTable](./iTin.Hardware.Specification.Cpuid/CpuidPropertiesTable.md) | Specialization of the BasePropertiesTable class that stores the available properties for each data table. |
| class [CpuidSubLeafCollection](./iTin.Hardware.Specification.Cpuid/CpuidSubLeafCollection.md) | Represents a read-only collection of objects [`LeafBase`](./iTin.Hardware.Specification.Cpuid/LeafBase.md). |
| class [CpuidSubLeafDictionary](./iTin.Hardware.Specification.Cpuid/CpuidSubLeafDictionary.md) | Represents a dictionary for keys [`SubLeaf`](./iTin.Hardware.Specification.Cpuid/SubLeaf.md) and values PropertyItem. |
| enum [Leaf](./iTin.Hardware.Specification.Cpuid/Leaf.md) | Defines the known leaf values |
| abstract class [LeafBase](./iTin.Hardware.Specification.Cpuid/LeafBase.md) | The LeafBase class provides functions to analyze the properties associated with a leaf [`CPUID`](./iTin.Hardware.Specification/CPUID.md). |
| static class [LeafProperty](./iTin.Hardware.Specification.Cpuid/LeafProperty.md) | Defines available keys for the available leafs of a system. |
| class [QuerySubLeafPropertyCollectionResult](./iTin.Hardware.Specification.Cpuid/QuerySubLeafPropertyCollectionResult.md) | Specialization of ResultBase interface. Where `T` is [`CpuidSubLeafDictionary`](./iTin.Hardware.Specification.Cpuid/CpuidSubLeafDictionary.md). Represents result after query operation. |
| enum [SubLeaf](./iTin.Hardware.Specification.Cpuid/SubLeaf.md) | Defines the known leaf values |

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Cpuid.dll -->
