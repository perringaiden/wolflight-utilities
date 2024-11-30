@echo off

if "%1%"=="" goto documentation
if "%2%"=="" goto documentation


dotnet nuget push %1 --skip-duplicate --api-key %2 --source https://api.nuget.org/v3/index.json"

goto exitPoint

:documentation
echo Parameter 1 : Enter the source file (*.nupkg).
echo Parameter 2 : Enter the API Key.

:exitPoint
