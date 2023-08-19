
using System.Runtime.InteropServices;

using iTin.Core.Interop.Shared.CrossPlatform;

namespace iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

/// <summary>
/// Functions for handle <c>CPUID</c> microprocessor features.
/// </summary>
public static class NativeMethods
{
    /// <summary>
    /// Gets a value that indicates whether there is support for the <b>CPUID</b> function of the microprocessor.
    /// </summary>
    /// <returns>
    /// Returns <b>true</b> in case the <b>CPUID</b> instruction is supported; <b>false</b> otherwise.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern bool cpuid_is_supported();

    /// <summary>
    /// Returns the result of the <b>CPUID</b> instruction for a given <paramref name="leaf"/>.
    /// </summary>
    /// <param name="leaf">A <see cref="uint"/> which defines the value of the `eax` register.</param>
    /// <returns>
    /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern CpuidResult cpuid(uint leaf);

    /// <summary>
    /// Returns the result of the <b>CPUID</b> instruction for a given <paramref name="leaf"/> and <paramref name="subleaf"/>.
    /// </summary>
    /// <param name="leaf">A <see cref="uint"/> which defines the value of the <b>eax</b> register.</param>
    /// <param name="subleaf">A <see cref="uint"/> which defines the value of the <b>ecx</b> register.</param>
    /// <returns>
    /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern CpuidResult cpuid_with_subleaf(uint leaf, uint subleaf);
}
