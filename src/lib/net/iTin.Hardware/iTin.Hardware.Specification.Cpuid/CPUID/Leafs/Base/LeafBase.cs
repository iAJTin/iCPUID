
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;
using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// The <b>LeafBase</b> class provides functions to analyze the properties associated with a leaf <see cref="CPUID"/>.
/// </summary>
public abstract class LeafBase
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly CpuidLeafContent _content;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly CpuidPropertiesTable _cpuidPropertiesTable = new();

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="LeafBase"/>.
    /// </summary>
    /// <param name="content">Current leaf information.</param>
    /// <param name="subLeaf">Current sub-leaf information.</param>
    protected LeafBase(CpuidLeafContent content, SubLeaf subLeaf = SubLeaf.Main)
    {
        SubLeaf = subLeaf;

        _content = content;
        InvokeResult = _content.Invoke(subLeaf);

        PopulateProperties(_cpuidPropertiesTable);
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Returns a list of implemented properties for this leaf.
    /// </summary>
    /// <value>
    /// A list of implemented properties for this leaf.
    /// </value>
    public ReadOnlyCollection<IPropertyKey> ImplementedProperties => _cpuidPropertiesTable.Keys.ToList().AsReadOnly();

    /// <summary>
    /// Gets the <see cref="Leaf"/> value.
    /// </summary>
    /// <value>
    /// One of the <see cref="Leaf"/> enumeration values.
    /// </value>
    public Leaf Leaf => _content.Leaf;

    /// <summary>
    /// Gets the <see cref="SubLeaf"/> value.
    /// </summary>
    /// <value>
    /// One of the <see cref="SubLeaf"/> enumeration values.
    /// </value>
    public SubLeaf SubLeaf { get; }

    #endregion

    #region protected properties

    /// <summary>
    /// Gets or sets the result of executes the <b>CPUID</b> instruction with given leaf and optional sub-leaf.
    /// </summary>
    /// <value>
    /// A <see cref="CpuidResult"/> structure which contains the result of executes the <b>CPUID</b> instruction with given leaf and optional sub-leaf.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected CpuidResult InvokeResult { get; set; }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <strong>Success</strong>
    /// property will be <see langword="true"/> and the <strong>Value</strong> property will contain the value; otherwise, the <strong>Success</strong> property
    /// will be false and the <strong>Errors</strong> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <strong>Value</strong> property is <see cref="PropertyItem"/>. Contains the result of the operation.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
    {
        var result = _cpuidPropertiesTable[propertyKey];
        if (result is not List<PropertyItem> itemList)
        {
            return QueryPropertyResult.CreateErrorResult("Can not found specified property key");
        }

        var hasItems = itemList.Any();
        if (!hasItems)
        {
            return QueryPropertyResult.CreateErrorResult("Can not found specified property key");
        }

        var onlyOneItem = itemList.Count == 1;
        if (onlyOneItem)
        {
            return QueryPropertyResult.CreateSuccessResult(itemList.FirstOrDefault());
        }

        return QueryPropertyResult.CreateErrorResult("Can not found specified property key");
    }

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override string ToString() => $"SubLeaf={SubLeaf}";

    #endregion

    #region protected virtual methods

    /// <summary>
    /// Populates the property collection for this leaf.
    /// </summary>
    /// <param name="properties">Collection of properties of this leaf.</param>
    protected virtual void PopulateProperties(CpuidPropertiesTable properties)
    {
    }

    #endregion

    #region internal methods

    /// <summary>
    /// Creates a <see cref="uint"/> value from two <see cref="byte"/> values
    /// </summary>
    /// <param name="left">left value to use.</param>
    /// <param name="right">left value to use.</param>
    /// <returns>
    /// Returns a new <see cref="uint"/> value.
    /// </returns>
    internal uint CreateUnsignedIntFromValues(byte left, byte right)
    {
        uint result = left;
        result <<= 8;
        result |= right;

        return result;
    }

    /// <summary>
    /// Creates a <see cref="ulong"/> value from two <see cref="uint"/> values
    /// </summary>
    /// <param name="left">left value to use.</param>
    /// <param name="right">left value to use.</param>
    /// <returns>
    /// Returns a new <see cref="ulong"/> value.
    /// </returns>
    internal ulong CreateUnsignedLongFromValues(uint left, uint right)
    {
        ulong result = left;
        result <<= 32;
        result |= right;

        return result;
    }

    /// <summary>
    /// Convert a <see cref="int"/> into <see cref="string"/>.
    /// </summary>
    /// <param name="value">Value to convert.</param>
    /// <returns>
    /// Returns <see cref="string"/> value.
    /// </returns>
    internal string Word2Str(int value) => LogicHelper.Word2Str(value);

    #endregion
}
