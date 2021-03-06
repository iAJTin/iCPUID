# LeafProperty.ProcessorInfoAndFeatures.Features.PBE property

Gets a value representing the key to retrieve the property value.

Pending Break Enable. A value of false indicates there is only a single logical processor in the package and software should assume only a single APIC ID is reserved. A value of true indicates the value in CPUID.1.EBX[23:16] (the Maximum number of addressable IDs for logical processors in this package) is valid for the package.

Key Composition

* Leaf: ProcessorInfoAndFeatures
* Property: PBE
* Unit: None

Return Value

Type: Boolean

```csharp
public static IPropertyKey PBE { get; }
```

## See Also

* class [Features](../LeafProperty.ProcessorInfoAndFeatures.Features.md)
* namespace [iTin.Hardware.Specification.Cpuid](../../iTin.Hardware.Specification.Cpuid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Cpuid.dll -->
