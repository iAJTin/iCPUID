@ECHO OFF
CLS

..\src\.nuget\nuget Pack iCPUID.1.0.4.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget

pause
