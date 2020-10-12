
namespace iTin.Core.Hardware.CrossPlatform.Cpuid
{
    using iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

    /// <summary>
    /// Methods for handle CPUID microprocessor features.
    /// </summary>
    public static class SafeCpuidNativeMethods
    {
        /// <summary>
        /// Gets a value that indicates whether there is support for the <b>CPUID</b> function of the microprocessor.
        /// </summary>
        /// <returns>
        /// Returns <b>true</b> in case the <b>CPUID</b> instruction is supported; <b>false</b> otherwise.
        /// </returns>
        public static bool CpuidIsSupported() => NativeMethods.cpuid_is_supported();

        /// <summary>
        /// Returns the result of the <b>CPUID</b> instruction for a given <paramref name="leaf"/> and <paramref name="subleaf"/>.
        /// </summary>
        /// <param name="leaf">A <see cref="uint"/> which defines the value of the <b>eax</b> register.</param>
        /// <param name="subleaf">A <see cref="uint"/> which defines the value of the <b>ecx</b> register.</param>
        /// <returns>
        /// Returns a <see cref="CpuidResult"/> structure that contains the result of the operation.
        /// </returns>
        public static CpuidResult Invoke(uint leaf, uint subleaf = 0x00) => NativeMethods.cpuid_with_subleaf(leaf, subleaf);
    }
}
