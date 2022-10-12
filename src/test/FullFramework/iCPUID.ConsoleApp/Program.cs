
namespace iCPUID.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core.Hardware.Common;
    using iTin.Core.Helpers;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Cpuid;

    class Program
    {
        static void Main(string[] args)
        {
            CPUID cpuid = CPUID.Instance;
            Console.WriteLine(@" =======================");
            Console.WriteLine(@" CPUID");
            Console.WriteLine(@" =======================");
            Console.WriteLine($@" Is Available > {cpuid.IsAvailable}");
            Console.WriteLine($@" Processor Name > {cpuid.ProcessorName}");

            Console.WriteLine();
            Console.WriteLine(@" =================");
            Console.WriteLine(@" Implemented leafs");
            Console.WriteLine(@" =================");
            ReadOnlyCollection<Leaf> basicLeafs = cpuid.ImplementedLeafs;
            foreach (Leaf leaf in basicLeafs)
            {
                Console.WriteLine($@" {(int)leaf:X8}-{leaf}");
            }

            Console.WriteLine();
            Console.WriteLine(@" ================================");
            Console.WriteLine(@" All leafs > subleafs implemented");
            Console.WriteLine(@" ================================");
            var leafs = cpuid.Leafs;
            foreach (var (leaf, subLeafs) in leafs)
            {
                Console.WriteLine($@" > {leaf} (EAX={(int)leaf:X8})");

                foreach (var subLeaf in subLeafs)
                {
                    Console.WriteLine($@"   > {subLeaf.SubLeaf} (ECX={(int)subLeaf.SubLeaf:X8})");
                }

                Console.WriteLine();
            }

            Console.WriteLine(@" ==================================================================");
            Console.WriteLine(@" All properties implementes by leafs / subleafs (shows description)");
            Console.WriteLine(@" ==================================================================");
            foreach (var (leaf, subLeafs) in leafs)
            {
                Console.WriteLine($@" > {leaf} (EAX={(int)leaf:X8})");

                foreach (var subLeaf in subLeafs)
                {
                    Console.WriteLine($@"   > {subLeaf.SubLeaf} (ECX={(int)subLeaf.SubLeaf:X8})");
                    IEnumerable<IPropertyKey> properties = subLeaf.ImplementedProperties;
                    foreach (var property in properties)
                    {
                        PropertyUnit unit = property.PropertyUnit;
                        string friendlyName = property.GetPropertyName();
                        string description = property.GetPropertyDescription();

                        Console.WriteLine($@"     > {friendlyName} {(unit == PropertyUnit.None ? string.Empty : $"({unit})")}: {description}");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine(@" =======================================================");
            Console.WriteLine(@" All properties implementes by leafs / subleafs (values)");
            Console.WriteLine(@" =======================================================");
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
                        PropertyItem propertyItem = queryResult.Result;
                        object value = propertyItem.Value;
                        string friendlyName = property.GetPropertyName();
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

                Console.WriteLine();
            }

            Console.WriteLine(@" ===============================");
            Console.WriteLine(@" Gets a single property directly");
            Console.WriteLine(@" ===============================");

            QueryPropertyResult manufacturerQueryResult = cpuid.Leafs.GetProperty(LeafProperty.BasicInformation.Manufacturer);
            if (manufacturerQueryResult.Success)
            {
                Console.WriteLine($@" > Manufacturer: {manufacturerQueryResult.Result.Value}");
            }

            QueryPropertyResult avx2 = cpuid.Leafs.GetProperty(LeafProperty.ExtendedFeatures.AVX2);
            if (avx2.Success)
            {
                Console.WriteLine($@" > AVX2: {avx2.Result.Value}");
            }

            Console.WriteLine();
            Console.WriteLine(@" ===================================");
            Console.WriteLine(@" Gets a multiple properties directly");
            Console.WriteLine(@" ===================================");
            QuerySubLeafPropertyCollectionResult cacheSizesQueryResult = leafs.GetProperties(LeafProperty.DeterministicCacheParameters.CacheSize);
            if (cacheSizesQueryResult.Success)
            {
                CpuidSubLeafDictionary cacheSizes = cacheSizesQueryResult.Result;
                bool hasCacheSizesEntries = cacheSizes.Any();
                if (!hasCacheSizesEntries)
                {
                    Console.WriteLine($@" > Sorry, The 'LeafProperty.DeterministicCacheParameters.CacheSize' property has not implementes on this system");
                }
                else
                {
                    foreach (var (subLeaf, propertyItem) in cacheSizes)
                    {
                        Console.WriteLine($@" > Cache Size:  ({subLeaf}) > {propertyItem.Value} {propertyItem.Key.PropertyUnit}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
