rd content\Content\MeadCo.ScriptX /S /Q
rd content\Views /S /Q
rem ** Do not remove controllers folder .. its under tfs control with a .pp file.
del lib\net40\*.dll
del lib\net40\*.config
del *.nupkg

copy ..\..\..\MeadCo.ScriptXHelpers\bin\Release\MeadCo.ScriptXHelpers.dll lib\net40\MeadCo.ScriptXHelpers.dll
copy ..\..\..\MeadCo.ScriptXHelpers\bin\Release\MeadCo.ScriptXHelpers.dll.config lib\net40\MeadCo.ScriptXHelpers.dll.config
xcopy ..\..\..\MeadCo.ScriptXHelpersInMVC\Content\MeadCo.ScriptX\images content\Content\MeadCo.ScriptX\images /S /R /Y /J /I
xcopy ..\..\..\MeadCo.ScriptXHelpersInMVC\Views\ScriptXClientPrinting content\Views\ScriptXClientPrinting /S /R /Y /J /I
