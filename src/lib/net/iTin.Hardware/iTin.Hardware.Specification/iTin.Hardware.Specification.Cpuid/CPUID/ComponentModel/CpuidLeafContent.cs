
namespace iTin.Hardware.Specification.Cpuid
{
    using System.Collections.Generic;

    using iTin.Core.Hardware.CrossPlatform.Cpuid;

    using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

    /// <summary>
    /// Defines the content of a leaf.
    /// </summary>
    public readonly struct CpuidLeafContent
    {
        #region constructor/s

        #region [public] CpuidLeafInfo(Leaf): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="CpuidLeafContent"/> struct.
        /// </summary>
        /// <param name="leaf">The leaf value to use.</param>
        public CpuidLeafContent(Leaf leaf)
        {
            Leaf = leaf;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (Leaf) Leaf: Gets the leaf value
        /// <summary>
        /// Gets the <see cref="Leaf"/> value.
        /// </summary>
        /// <value>
        /// One of the <see cref="Leaf"/> enumeration values.
        /// </value>
        public Leaf Leaf { get; }
        #endregion

        #region [public] (CpuidSubLeafCollection) SubLeafs: Gets collection of available sub-leafs
        /// <summary>
        /// Gets collection of available sub-leafs.
        /// </summary>
        /// <value>
        /// Collection of available leafs.
        /// </value>
        internal CpuidSubLeafCollection SubLeafs
        {
            get
            {
                IEnumerable<LeafBase> structures = CpuidLeafFactory.Create(this);
                var collection = new CpuidSubLeafCollection(structures);

                return collection;
            }
        }
        #endregion

        #endregion

        #region public operators

        #region [public] {operator} (bool) operator ==(CpuidLeafContent, CpuidLeafContent): Implements the == operator
        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="right">The right leaf info.</param>
        /// <param name="left">The left leaf info.</param>
        /// <returns>
        /// Returns <b>true</b> if <b>right</b> is equal to <b>left</b>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(CpuidLeafContent right, CpuidLeafContent left) => right.Equals(left);
        #endregion

        #region [public] {operator} (bool) operator !=(CpuidLeafInfo, CpuidLeafInfo): Implements the != operator
        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="right">The right leaf info.</param>
        /// <param name="left">The left leaf info.</param>
        /// <returns>
        /// Returns <b>true</b> if <b>right</b> is not equal to <b>left</b>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(CpuidLeafContent right, CpuidLeafContent left) => !right.Equals(left);
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Equals(CpuidLeafContent): Indicates whether the current object is equal to another object of the same type
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared to this object.</param>
        /// <returns>
        /// <b>true</b> if the current object is equal to the parameter <paramref name="other"/>; Otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(CpuidLeafContent other) => other.Equals((object)this);
        #endregion

        #endregion

        #region internal methods

        #region [public] (CpuidResult) Invoke(SubLeaf = SubLeaf.Main): Returns a value that contains the result of executes the CPUID instruction with given leaf and subleaf
        /// <summary>
        /// Returns a value that contains the result of executes the <b>CPUID</b> instruction with given leaf and subleaf.
        /// </summary>
        /// <returns>
        /// A <see cref="CpuidResult"/> structure which contains the result of executes the <b>CPUID</b> instruction with given leaf and subleaf.
        /// </returns>
        internal CpuidResult Invoke(SubLeaf subLeaf = SubLeaf.Main) => SafeCpuidNativeMethods.Invoke((uint)Leaf, (uint)subLeaf);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a hash code for this instance
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() => Leaf.GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object): Determines whether the specified object is equal to this instance
        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">Another object with which the comparison is to be made.</param>
        /// <returns>
        /// <b>true</b> if the specified <see cref="object"/> is equal to this instance; otherwise, <b>false</b>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is CpuidLeafContent))
            {
                return false;
            }

            CpuidLeafContent other = (CpuidLeafContent)obj;
            return other.Leaf == Leaf;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        public override string ToString() => $"Leaf={Leaf}, SubLeafs={SubLeafs.Count}";
        #endregion

        #endregion
    }
}
