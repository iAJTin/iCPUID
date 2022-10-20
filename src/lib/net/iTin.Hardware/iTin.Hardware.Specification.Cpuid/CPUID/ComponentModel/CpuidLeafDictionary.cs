
using System.Collections.Generic;
using System.Linq;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Cpuid
{
    using System;
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
        /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
        /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
        /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
        /// </para>
        /// <para>
        /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>.
        /// </para>
        /// <para>
        /// </para>
        /// </returns>
        public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            CpuidSubLeafCollection subLeafs = this[(Leaf)propertyId];

            bool hasItems = subLeafs.Any();
            if (!hasItems)
            {
                return QueryPropertyResult.CreateErroResult("Can not found specified property key");
            }

            bool onlyOneItem = subLeafs.Count == 1;
            if (onlyOneItem)
            {
                return subLeafs.FirstOrDefault()?.GetProperty(propertyKey);
            }

            return QueryPropertyResult.CreateErroResult("Can not found specified property key");
        }

        /// <summary>
        /// Returns a value that contains the result of the operation.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// <para>
        /// A <see cref="QuerySubLeafPropertyCollectionResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
        /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
        /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
        /// </para>
        /// <para>
        /// The type of the <b>Value</b> property is <see cref="CpuidSubLeafDictionary"/>. Contains the result of the operation.
        /// </para>
        /// <para>
        /// </para>
        /// </returns>
        public QuerySubLeafPropertyCollectionResult GetProperties(IPropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            CpuidSubLeafDictionary properties = new CpuidSubLeafDictionary();
            CpuidSubLeafCollection subLeafs = this[(Leaf)propertyId];
            if (subLeafs == null)
            {
                return QuerySubLeafPropertyCollectionResult.CreateErroResult("Can not found specified property key");
            }

            int i = 0;
            foreach (var subLeaf in subLeafs)
            {
                properties.Add((SubLeaf)i, subLeaf.GetProperty(propertyKey).Result);
                i++;
            }

            return QuerySubLeafPropertyCollectionResult.CreateSuccessResult(properties);
        }
    }
}
