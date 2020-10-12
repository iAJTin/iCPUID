
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;
    using iTin.Core.Hardware.Common;
    using iTin.Core.Helpers;

    using Specification;

    /// <summary>
    /// The <b>LeafBase</b> class provides functions to analyze the properties associated with a leaf <see cref="CPUID"/>.
    /// </summary>
    public abstract class LeafBase
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CpuidLeafContent _content;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CpuidPropertiesTable _cpuidPropertiesTable = new CpuidPropertiesTable();
        #endregion

        #region constructor/s

        #region [protected] LeafBase(CpuidLeafContent, SubLeaf = SubLeaf.Main): Initializes a new instance of the class
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

        #endregion

        #region public readonly properties

        #region [public] (ReadOnlyCollection<IPropertyKey>) ImplementedProperties: Returns a list of implemented properties for this leaf
        /// <summary>
        /// Returns a list of implemented properties for this leaf.
        /// </summary>
        /// <value>
        /// A list of implemented properties for this leaf.
        /// </value>
        public ReadOnlyCollection<IPropertyKey> ImplementedProperties => _cpuidPropertiesTable.Keys.ToList().AsReadOnly();
        #endregion

        #region [public] (Leaf) Leaf: Gets the information for a leaf
        /// <summary>
        /// Gets the <see cref="Leaf"/> value.
        /// </summary>
        /// <value>
        /// One of the <see cref="Leaf"/> enumeration values.
        /// </value>
        public Leaf Leaf => _content.Leaf;
        #endregion

        #region [public] (SubLeaf) SubLeaf: Gets the information for a sub-leaf
        /// <summary>
        /// Gets the <see cref="SubLeaf"/> value.
        /// </summary>
        /// <value>
        /// One of the <see cref="SubLeaf"/> enumeration values.
        /// </value>
        public SubLeaf SubLeaf { get; }
        #endregion

        #endregion

        #region protected readonly properties

        #region [protected] (CpuidResult) InvokeResult: Gets or sets the result of executes the CPUID instruction with given leaf and optional subleaf
        /// <summary>
        /// Gets or sets the result of executes the <b>CPUID</b> instruction with given leaf and optional subleaf.
        /// </summary>
        /// <value>
        /// A <see cref="CpuidResult"/> structure which contains the result of executes the <b>CPUID</b> instruction with given leaf and optional subleaf.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected CpuidResult InvokeResult { get; set; }
        #endregion

        #endregion

        #region public methods

        #region [public] (QueryPropertyResult) GetProperty(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// <para>
        /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
        /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
        /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
        /// </para>
        /// <para>
        /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>. Contains the result of the operation.
        /// </para>
        /// <para>
        /// </para>
        /// </returns>
        public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
        {
            object result = _cpuidPropertiesTable[propertyKey];
            if (!(result is List<PropertyItem> itemList))
            {
                return QueryPropertyResult.CreateErroResult("Can not found specified property key");
            }

            bool hasItems = itemList.Any();
            if (!hasItems)
            {
                return QueryPropertyResult.CreateErroResult("Can not found specified property key");
            }

            bool onlyOneItem = itemList.Count == 1;
            if (onlyOneItem)
            {
                return QueryPropertyResult.CreateSuccessResult(itemList.FirstOrDefault());
            }

            return QueryPropertyResult.CreateErroResult("Can not found specified property key");
        }
        #endregion

        #endregion

        #region public override methods

        #region [protected] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        public override string ToString() => $"SubLeaf={SubLeaf}";
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (void) PopulateProperties(CpuidPropertiesTable): Populates the property collection for this leaf
        /// <summary>
        /// Populates the property collection for this leaf.
        /// </summary>
        /// <param name="properties">Collection of properties of this leaf.</param>
        protected virtual void PopulateProperties(CpuidPropertiesTable properties)
        {
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (ulong) CreateUnsignedIntFromValues(byte, byte): Creates a uint value from two byte values
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
        #endregion

        #region [internal] (ulong) CreateUnsignedLongFromValues(uint, uint): Creates a ulong value from two uint values
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
        #endregion

        #region [internal] (string) Word2Str(int): Convert a int into string
        /// <summary>
        /// Convert a <see cref="int"/> into <see cref="string"/>.
        /// </summary>
        /// <param name="value">Valor a convertir.</param>
        /// <returns>
        /// Returns <see cref="string"/> value.
        /// </returns>
        internal string Word2Str(int value) => LogicHelper.Word2Str(value);
        #endregion

        #endregion
    }
}
