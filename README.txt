
What is iCPUID?
================

iCPUID is a lightweight implementation that allows us to obtain the CPUID information.


Library versions
================

Library versions for current iCPUID version (1.0.0)

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
|iTin.Hardware.Specification.Cpuid          1.0.0.0		  CPUID Specification Implementation                                    |
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