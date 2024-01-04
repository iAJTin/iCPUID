
using iTin.Core.Hardware.CrossPlatform.Cpuid;
using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// Defines the content of a leaf.
/// </summary>
public readonly struct CpuidLeafContent
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="CpuidLeafContent"/> struct.
    /// </summary>
    /// <param name="leaf">The leaf value to use.</param>
    public CpuidLeafContent(Leaf leaf)
    {
        Leaf = leaf;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the <see cref="Leaf"/> value.
    /// </summary>
    /// <value>
    /// One of the <see cref="Leaf"/> enumeration values.
    /// </value>
    public Leaf Leaf { get; }

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
            var structures = CpuidLeafFactory.Create(this);
            var collection = new CpuidSubLeafCollection(structures);

            return collection;
        }
    }

    #endregion

    #region public operators

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="right">The right leaf info.</param>
    /// <param name="left">The left leaf info.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <strong>right</strong> is equal to <strong>left</strong>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(CpuidLeafContent right, CpuidLeafContent left) => right.Equals(left);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="right">The right leaf info.</param>
    /// <param name="left">The left leaf info.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <strong>right</strong> is not equal to <strong>left</strong>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(CpuidLeafContent right, CpuidLeafContent left) => !right.Equals(left);

    #endregion

    #region public methods

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared to this object.</param>
    /// <returns>
    /// <see langword="true"/> if the current object is equal to the parameter <paramref name="other"/>; Otherwise, <see langword="false"/>.
    /// </returns>
    public bool Equals(CpuidLeafContent other) => other.Equals((object)this);

    #endregion

    #region internal methods

    /// <summary>
    /// Returns a value that contains the result of executes the <b>CPUID</b> instruction with given leaf and sub-leaf.
    /// </summary>
    /// <returns>
    /// A <see cref="CpuidResult"/> structure which contains the result of executes the <b>CPUID</b> instruction with given leaf and sub-leaf.
    /// </returns>
    internal CpuidResult Invoke(SubLeaf subLeaf = SubLeaf.Main) => SafeCpuidNativeMethods.Invoke((uint)Leaf, (uint)subLeaf);

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => Leaf.GetHashCode();

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not CpuidLeafContent other)
        {
            return false;
        }

        return other.Leaf == Leaf;
    }

    /// <inheritdoc/>
    public override string ToString() => $"Leaf={Leaf}, SubLeafs={SubLeafs.Count}";

    #endregion
}
