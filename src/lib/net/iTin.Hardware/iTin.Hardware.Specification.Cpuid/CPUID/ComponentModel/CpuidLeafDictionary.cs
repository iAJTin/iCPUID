
using System.Collections.Generic;
using System.Linq;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// Represents a dictionary for keys <see cref="Leaf"/> and values <see cref="CpuidSubLeafCollection"/>.
/// </summary>
public sealed class CpuidLeafDictionary : Dictionary<Leaf, CpuidSubLeafCollection>
{
    /// <summary>
    /// Returns a value that contains the result of the operation. Always returns the first appearance of the property
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <strong>Success</strong>
    /// property will be <see langword="true"/> and the <strong>Value</strong> property will contain the value; otherwise, the <strong>Success</strong> property
    /// will be false and the <strong>Errors</strong> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <strong>Value</strong> property is <see cref="PropertyItem"/>.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
    {
        var propertyId = propertyKey.StructureId;
        var subLeafs = this[(Leaf)propertyId];

        var hasItems = subLeafs.Any();
        if (!hasItems)
        {
            return QueryPropertyResult.CreateErrorResult("Can not found specified property key");
        }

        var onlyOneItem = subLeafs.Count == 1;
        if (onlyOneItem)
        {
            return subLeafs.FirstOrDefault()?.GetProperty(propertyKey);
        }

        return QueryPropertyResult.CreateErrorResult("Can not found specified property key");
    }

    /// <summary>
    /// Returns a value that contains the result of the operation.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QuerySubLeafPropertyCollectionResult"/> reference that contains the result of the operation, to check if the operation is correct, the <strong>Success</strong>
    /// property will be <see langword="true"/> and the <strong>Value</strong> property will contain the value; otherwise, the <strong>Success</strong> property
    /// will be false and the <strong>Errors</strong> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <b>Value</b> property is <see cref="CpuidSubLeafDictionary"/>. Contains the result of the operation.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QuerySubLeafPropertyCollectionResult GetProperties(IPropertyKey propertyKey)
    {
        var propertyId = propertyKey.StructureId;
        var properties = new CpuidSubLeafDictionary();
        var subLeafs = this[(Leaf)propertyId];
        if (subLeafs == null)
        {
            return QuerySubLeafPropertyCollectionResult.CreateErrorResult("Can not found specified property key");
        }

        var i = 0;
        foreach (var subLeaf in subLeafs)
        {
            properties.Add((SubLeaf)i, subLeaf.GetProperty(propertyKey).Result);
            i++;
        }

        return QuerySubLeafPropertyCollectionResult.CreateSuccessResult(properties);
    }
}
