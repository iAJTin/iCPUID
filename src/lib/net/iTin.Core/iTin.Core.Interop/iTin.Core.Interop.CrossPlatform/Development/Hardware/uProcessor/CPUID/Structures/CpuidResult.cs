
using System;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.CrossPlatform.Development.Hardware.uProcessor.CPUID;

/// <summary>
/// Defines a structure that contains the value of the cpu registers.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct CpuidResult
{
    #region public members

    ///
    /// <strong>eax</strong> register.
    ///
    public UInt32 eax;

    ///
    /// <strong>ebx</strong> register.
    ///
    public UInt32 ebx;

    ///
    /// <strong>ecx</strong> register.
    ///
    public UInt32 ecx;

    ///
    /// <strong>edx</strong> register.
    ///
    public UInt32 edx;

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value indicating whether all registers have a value of 0.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if all values are 0; otherwise <see langword="false"/>.
    /// </value>
    public readonly bool IsEmpty => eax == 0 && ebx == 0 && ecx == 0 & edx == 0;

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override string ToString() => $"eax={eax:X8}, ebx={ebx:X8}, ecx={ecx:X8}, edx={edx:X8}";

    #endregion
}
