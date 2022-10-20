
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Cpuid
{
    /// <summary>
    /// Represents a read-only collection of objects <see cref="LeafBase"/>.
    /// </summary>
    public sealed class CpuidSubLeafCollection : ReadOnlyCollection<LeafBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CpuidSubLeafCollection"/> class.
        /// </summary>
        /// <param name="selectedLeaf">The selected leaf.</param>
        internal CpuidSubLeafCollection(IEnumerable<LeafBase> selectedLeaf) : base(selectedLeaf.ToList())
        {
        }
    }
}
