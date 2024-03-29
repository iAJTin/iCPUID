# QuerySubLeafPropertyCollectionResult class

Specialization of ResultBase interface. Where `T` is [`CpuidSubLeafDictionary`](./CpuidSubLeafDictionary.md). Represents result after query operation.

```csharp
public class QuerySubLeafPropertyCollectionResult : ResultBase<CpuidSubLeafDictionary>
```

## Public Members

| name | description |
| --- | --- |
| [QuerySubLeafPropertyCollectionResult](QuerySubLeafPropertyCollectionResult/QuerySubLeafPropertyCollectionResult.md)() | The default constructor. |
| static [CreateErrorResult](QuerySubLeafPropertyCollectionResult/CreateErrorResult.md)(…) | Returns a new [`QuerySubLeafPropertyCollectionResult`](./QuerySubLeafPropertyCollectionResult.md) with specified detailed error. (4 methods) |
| static [CreateSuccessResult](QuerySubLeafPropertyCollectionResult/CreateSuccessResult.md)(…) | Returns a new success result. |
| static [FromException](QuerySubLeafPropertyCollectionResult/FromException.md)(…) | Creates a new [`QuerySubLeafPropertyCollectionResult`](./QuerySubLeafPropertyCollectionResult.md) instance from known exception. (2 methods) |

## See Also

* class [CpuidSubLeafDictionary](./CpuidSubLeafDictionary.md)
* namespace [iTin.Hardware.Specification.Cpuid](../iTin.Hardware.Specification.Cpuid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Cpuid.dll -->
