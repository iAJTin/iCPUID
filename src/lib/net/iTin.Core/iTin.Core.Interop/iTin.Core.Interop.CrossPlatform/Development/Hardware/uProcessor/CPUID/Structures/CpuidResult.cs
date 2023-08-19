
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
    /// <b>eax</b> register.
    ///
    public UInt32 eax;

    ///
    /// <b>ebx</b> register.
    ///
    public UInt32 ebx;

    ///
    /// <b>ecx</b> register.
    ///
    public UInt32 ecx;

    ///
    /// <b>edx</b> register.
    ///
    public UInt32 edx;

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value indicating whether all registers have a value of 0.
    /// </summary>
    /// <value>
    /// <b>true</b> if all values are 0; otherwise <b>false</b>.
    /// </value>
    public bool IsEmpty => eax == 0 && ebx == 0 && ecx == 0 & edx == 0;

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents this instance.
    /// </returns>
    public override string ToString() => $"eax={eax:X8}, ebx={ebx:X8}, ecx={ecx:X8}, edx={edx:X8}";

    #endregion
}
