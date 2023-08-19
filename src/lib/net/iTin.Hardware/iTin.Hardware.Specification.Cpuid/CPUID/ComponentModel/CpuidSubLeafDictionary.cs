
using System.Collections.Generic;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Cpuid;

/// <summary>
/// Represents a dictionary for keys <see cref="SubLeaf"/> and values <see cref="PropertyItem"/>.
/// </summary>
public sealed class CpuidSubLeafDictionary : Dictionary<SubLeaf, PropertyItem>
{
}
