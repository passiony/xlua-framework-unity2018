@echo off
set path=excel2json.py

for /f "delims=" %%i in ('dir /b "*.xlsx"') do (
	start python %path% %%i %%~ni.json
)

echo DONE

pause