
namespace iTin.Hardware.Specification
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    using iTin.Core.Hardware.CrossPlatform.Cpuid;
    using iTin.Core.Helpers;

    using Cpuid;

    /// <summary>
    /// CPUID—CPU Identification.<br/>
    /// CPUID returns processor identification and feature information.
    /// </summary>
    public sealed class CPUID
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _processorName;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Leaf _validHighestLeafBasic;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Leaf _validHighestLeafExtended;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<Leaf, CpuidLeafContent> _leafTable;
        #endregion

        #region constructor/s

        #region [private] CPUID(): Prevents a default instance of this class from being created
        /// <summary>
        /// Prevents a default instance of the <see cref="CPUID"/> class from being created.
        /// </summary>
        private CPUID()
        {
            IsAvailable = SafeCpuidNativeMethods.CpuidIsSupported();
            if (!IsAvailable)
            {
                return;
            }

            PopulatesLeafTables();
            PopulatesProcessorName();
        }
        #endregion

        #endregion

        #region public static readonly properties

        #region [public] {static} (CPUID) Instance: Gets a unique instance of this class
        /// <summary>
        /// Gets a unique instance of this class.
        /// </summary>
        /// <value>
        /// A unique <see cref="CPUID"/> reference that contains <b>CPUID</b> information.
        /// </value>
        public static readonly CPUID Instance = new CPUID();
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (ReadOnlyCollection<Leaf>) ImplementedLeafs: Returns a read-only collection containing the leafs implemented in this system
        /// <summary>
        /// Returns a read-only collection containing the leafs implemented in this system.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the current processor name.
        /// </value>
        public ReadOnlyCollection<Leaf> ImplementedLeafs => _leafTable.Keys.ToList().AsReadOnly();
        #endregion

        #region [public] (bool) IsAvailable: Gets a value that indicates whether the cpuid instruction is available for this system
        /// <summary>
        /// Gets a value that indicates whether the <b>CPUID</b> instruction is available for this system.
        /// </summary>
        /// <value>
        /// <b>true</b> if the <b>CPUID</b> instruction is available for this system; Otherwise, <b>false</b>.
        /// </value>
        public bool IsAvailable { get; }
        #endregion

        #region [public] (CpuidLeafDictionary) Leafs: Gets a 
        /// <summary>
        /// Gets a value that indicates whether the <b>CPUID</b> instruction is available for this system.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the current processor name.
        /// </value>
        public CpuidLeafDictionary Leafs
        {
            get
            {
                var leafDictionary = new CpuidLeafDictionary();
                CpuidLeafsCache cache = CpuidLeafsCache.Cache;
                foreach (Leaf leaf in ImplementedLeafs)
                {
                    CpuidLeafContent data = new CpuidLeafContent(leaf);
                    leafDictionary.Add(leaf, cache.Get(data));
                }

                return leafDictionary;
            }
        }
        #endregion

        #region [public] (string) ProcessorName: Gets a value that contains the current processor name
        /// <summary>
        /// Gets a value that indicates whether the <b>CPUID</b> instruction is available for this system.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the current processor name.
        /// </value>
        public string ProcessorName => _processorName;
        #endregion

        #endregion
        
        #region private methods

        #region [private] (void) PopulatesHighestValues(): Populates the highest leaf values for this system
        /// <summary>
        /// Populates the highest leaf values for this system.
        /// </summary>
        private void PopulatesHighestValues()
        {
            var basicLeafResult = SafeCpuidNativeMethods.Invoke((uint)Leaf.BasicInformation);
            _validHighestLeafBasic = (Leaf)basicLeafResult.eax;

            var extendedLeafResult = SafeCpuidNativeMethods.Invoke((uint)Leaf.HighestExtendedFunctionImplemented);
            _validHighestLeafExtended = (Leaf)extendedLeafResult.eax;
        }
        #endregion

        #region [private] (void) PopulatesHighestValues(): Populates the highest leaf values for this system
        /// <summary>
        /// Populates the highest leaf values for this system.
        /// </summary>
        private void PopulatesLeafTables()
        {
            PopulatesHighestValues();

            _leafTable = new Dictionary<Leaf, CpuidLeafContent>();
            for (uint leaf = 0x00; leaf < (uint)_validHighestLeafBasic; leaf++)
            {
                var validLeaf = Enum.IsDefined(typeof(Leaf), leaf);
                if (!validLeaf)
                {
                    continue;
                }

                var currentLeaf = (Leaf)leaf;
                var currentLeafInfo = new CpuidLeafContent((Leaf)leaf);
                _leafTable.Add(currentLeaf, currentLeafInfo);
            }

            for (uint leaf = (uint)Leaf.HighestExtendedFunctionImplemented; leaf < (uint)_validHighestLeafExtended; leaf++)
            {
                var validLeaf = Enum.IsDefined(typeof(Leaf), leaf);
                if (!validLeaf)
                {
                    continue;
                }

                var currentLeaf = (Leaf)leaf;
                var currentLeafInfo = new CpuidLeafContent((Leaf)leaf);
                _leafTable.Add(currentLeaf, currentLeafInfo);
            }
        }
        #endregion

        #region [private] (void) PopulatesProcessorName(): Populates the current processor name
        /// <summary>
        /// Populates the current processor name.
        /// </summary>
        private void PopulatesProcessorName()
        {
            var builder = new StringBuilder();
            
            var brandStringResult = SafeCpuidNativeMethods.Invoke((uint)Leaf.ProcessorBrandString);
            builder.Append($"{LogicHelper.Word2Str((int)brandStringResult.eax)}{LogicHelper.Word2Str((int)brandStringResult.ebx)}{LogicHelper.Word2Str((int)brandStringResult.ecx)}{LogicHelper.Word2Str((int)brandStringResult.edx)}");
            
            var brandString1Result = SafeCpuidNativeMethods.Invoke((uint)Leaf.ProcessorBrandString1);
            builder.Append($"{LogicHelper.Word2Str((int)brandString1Result.eax)}{LogicHelper.Word2Str((int)brandString1Result.ebx)}{LogicHelper.Word2Str((int)brandString1Result.ecx)}{LogicHelper.Word2Str((int)brandString1Result.edx)}");

            var brandString2Result = SafeCpuidNativeMethods.Invoke((uint)Leaf.ProcessorBrandString2);
            builder.Append($"{LogicHelper.Word2Str((int)brandString2Result.eax)}{LogicHelper.Word2Str((int)brandString2Result.ebx)}{LogicHelper.Word2Str((int)brandString2Result.ecx)}{LogicHelper.Word2Str((int)brandString2Result.edx)}");

            _processorName = builder.ToString().Trim('\0');
        }
        #endregion

        #endregion
    }
}
