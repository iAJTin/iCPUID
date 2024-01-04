
using System.Runtime.InteropServices;

using iTin.Core.Interop.Shared.CrossPlatform;

namespace iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

/// <summary>
/// Functions for handle <strong>CPUID</strong> microprocessor features.
/// </summary>
public static class NativeMethods
{
    /// <summary>
    /// Gets a value that indicates whether there is support for the <strong>CPUID</strong> function of the microprocessor.
    /// </summary>
    /// <returns>
    /// Returns <see langword="true"/> in case the <b>CPUID</b> instruction is supported; otherwise <see langword="false"/>.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern bool cpuid_is_supported();

    /// <summary>
    /// Returns the result of the <strong>CPUID</strong> instruction for a given <paramref name="leaf"/>.
    /// </summary>
    /// <param name="leaf">A <see cref="uint"/> which defines the value of the <strong>eax</strong> register.</param>
    /// <returns>
    /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern CpuidResult cpuid(uint leaf);

    /// <summary>
    /// Returns the result of the <strong>CPUID</strong> instruction for a given <paramref name="leaf"/> and <paramref name="subleaf"/>.
    /// </summary>
    /// <param name="leaf">A <see cref="uint"/> which defines the value of the <strong>eax</strong> register.</param>
    /// <param name="subleaf">A <see cref="uint"/> which defines the value of the <strong>ecx</strong> register.</param>
    /// <returns>
    /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
    /// </returns>
    [DllImport(ExternDll.Cpuid)]
    public static extern CpuidResult cpuid_with_subleaf(uint leaf, uint subleaf);
}
