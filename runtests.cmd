@pushd %~dp0
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "uitest_vargai.csproj"
::"%programfiles(x86)%\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe" "uitest_vargai.csproj"
@if ERRORLEVEL 1 goto end
@powershell "dir .\packages\ -Recurse | Unblock-File"
@cd .\packages\SpecRun.Runner.*\tools
SpecRun.exe run Default.srprofile "/baseFolder:%~dp0bin\Debug" /log:specrun.log "/outputFolder:%~dp0TestResults"
:end
@popd
