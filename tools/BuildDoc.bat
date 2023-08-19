@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\net\iTin.Hardware\iTin.Hardware.Specification.Cpuid\bin\Debug\netstandard2.0\iTin.Hardware.Specification.Cpuid.dll ..\documentation

PAUSE
