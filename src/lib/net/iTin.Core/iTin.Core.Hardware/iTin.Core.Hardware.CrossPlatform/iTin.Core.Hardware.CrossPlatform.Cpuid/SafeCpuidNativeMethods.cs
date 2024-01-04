
using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

namespace iTin.Core.Hardware.CrossPlatform.Cpuid;

/// <summary>
/// Methods for handle <strong>CPUID</strong> microprocessor features.
/// </summary>
public static class SafeCpuidNativeMethods
{
    /// <summary>
    /// Gets a value that indicates whether there is support for the <b>CPUID</b> function of the microprocessor.
    /// </summary>
    /// <returns>
    /// Returns <see langword="true"/> in case the <b>CPUID</b> instruction is supported; otherwise <see langword="false"/>.
    /// </returns>
    public static bool CpuidIsSupported() => NativeMethods.cpuid_is_supported();

    /// <summary>
    /// Returns the result of the <strong>CPUID</strong> instruction for a given <paramref name="leaf"/> and <paramref name="subLeaf"/>.
    /// </summary>
    /// <param name="leaf">A <see cref="uint"/> which defines the value of the <strong>eax</strong> register.</param>
    /// <param name="subLeaf">A <see cref="uint"/> which defines the value of the <strong>ecx</strong> register.</param>
    /// <returns>
    /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
    /// </returns>
    public static CpuidResult Invoke(uint leaf, uint subLeaf = 0x00) => NativeMethods.cpuid_with_subleaf(leaf, subLeaf);
}
