
using System.Collections.Generic;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Cpuid
{
    /// <summary>
    /// The <see cref="CpuidLeafsCache"/> class represents the cache of available leafs for a particular type.
    /// </summary>
    internal sealed class CpuidLeafsCache
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Dictionary<Leaf, CpuidSubLeafCollection> _leafDictionary;
        #endregion

        #region public static readonly memebrs
        /// <summary>
        /// Gets a reference to the available leafs cache.
        /// </summary>
        public static readonly CpuidLeafsCache Cache = new CpuidLeafsCache();
        #endregion

        #region constructor/s

        #region private CpuidLeafsCache(): Prevents a default instance of the class from being created
        /// <summary>
        /// Prevents a default instance of the class from being created.
        /// </summary>
        private CpuidLeafsCache()
        {
            _leafDictionary = new Dictionary<Leaf, CpuidSubLeafCollection>();
        }
        #endregion

        #endregion

        #region public methods

        #region public (CpuidLeafCollection) Get(CpuidLeafContent): Gets the collection of available leafs
        /// <summary>
        /// Gets the collection of available leafs.
        /// </summary>
        /// <param name="leafInfo">The leaf info.</param>
        /// <returns>
        /// The collection of available leafs.
        /// </returns>
        public CpuidSubLeafCollection Get(CpuidLeafContent leafInfo)
        {
            if (!_leafDictionary.ContainsKey(leafInfo.Leaf))
            {
                _leafDictionary.Add(leafInfo.Leaf, leafInfo.SubLeafs);
            }

            return _leafDictionary[leafInfo.Leaf];
        }
        #endregion

        #endregion
    }
}
