::@%1 cmd /k %0 :
@::make_proto.bat
@echo off

set UnityProtolDir=..\..\Assets\LuaScripts\Net\Proto
set LuaProtoSrcDir=.\proto
set LuaPluginDir=.\plugin

if exist "%UnityProtolDir%" rd /s /q "%UnityProtolDir%"
md "%UnityProtolDir%"


cd %LuaProtoSrcDir%
setlocal enabledelayedexpansion
for /f %%i in ('dir /b proto "*.proto"') do (
	echo..\protoc.exe -o %UnityProtolDir%\%%~ni.pb %%i 
	..\protoc.exe -o %UnityProtolDir%\%%~ni.pb %%i 
)
	
cd ..

cd "%LuaPluginDir%"
@python msgid-gen-lua.py

echo DONE

pause
exit
