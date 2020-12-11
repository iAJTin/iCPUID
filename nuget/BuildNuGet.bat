@ECHO OFF
CLS

..\src\.nuget\nuget Pack iCPUID.1.0.3.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget

pause

