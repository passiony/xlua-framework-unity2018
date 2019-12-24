@::trans2lua.bat
@echo off

set path=excel2lua.py
set excelpath=.\excel
set luapath=.\lua
set configpath=..\..\Assets\LuaScripts\Config\Data

if exist "%luapath%" rd /s /q "%luapath%"
md "%luapath%"

for /f "delims=" %%i in ('dir /b "excel\*.xlsx"') do (
	start python %path% %excelpath%\%%i %luapath%\%%~ni.lua
)
echo DONE

pause
exit


echo Press Any Key Copy To Assets
pause

for /f "delims=" %%i in ('dir /b "lua\*.lua"') do (
	copy %luapath%\%%i %configpath%\%%i /Y
)

echo Copy Lua File To Assets
pause
exit