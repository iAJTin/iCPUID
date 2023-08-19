# What is iCPUID?
iCPUID is a lightweight cross-platform implementation that allows us to obtain the CPUID information. 

Works on Windows, Mac and Linux

### Usage

Call **CPUID.Instance.Leafs** for getting all CPUID implemented leafs.

For more info, please see [CHANGELOG] file.

### Examples

1. Detection of the availability of the **CPUID** instruction.

       CPUID cpuid = CPUID.Instance;
       Console.WriteLine($@" Is Available > {cpuid.IsAvailable}");

2. Gets and prints all **CPUID** implemented leafs.

       CPUID cpuid = CPUID.Instance;
       ReadOnlyCollection<Leaf> leafs = cpuid.ImplementedLeafs;
       foreach (Leaf leaf in leafs)
       {
           Console.WriteLine($@" {(int)leaf:X8}-{leaf}");
       }

3. Gets and prints all **CPUID** implemented leafs > sub-leafs.

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

4. Gets and prints all **CPUID** implemented leafs > sub-leafs (shows description).

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

5. Gets and prints all **CPUID** implemented leafs > sub-leafs (values).

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

6. Gets a **single property** directly.

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

7. Gets a property in **multiple** elements directly.

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

# Documentation

 - For full code documentation, please see next link [documentation].

[email]: ./assets/email.png "email"
[CHANGELOG]: https://github.com/iAJTin/iCPUID/blob/master/CHANGELOG.md
[documentation]: https://github.com/iAJTin/iCPUID/blob/main/documentation/iTin.Hardware.Specification.Cpuid.md
