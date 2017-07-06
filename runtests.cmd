@pushd %~dp0
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "uitest_vargai.csproj"
@if ERRORLEVEL 1 goto end
@powershell "dir .\packages\ -Recurse | Unblock-File"
@cd .\packages\SpecRun.Runner.*\tools
SpecRun.exe run Default.srprofile "/baseFolder:%~dp0bin\Debug" /log:specrun.log "/outputFolder:%~dp0TestResults"
:end
@popd
