@echo off

if NOT %1a == a goto recurse
reg query HKCU\Software\Valve\Steam\Users > users.tmp
echo.

echo  
for /f "skip=1 delims=\ tokens=6" %%i in (users.tmp) do call %0 %%i
del users.tmp
echo  

pause>nul
goto end

:recurse

set SID=%1
set /A SID=SID/2
set /A SID1=SID*2
set STEAMBIT=0
if NOT %SID1% == %1 set STEAMBIT=1

    echo UserID: %SID%   SteamBit: %STEAMBIT%
    SET /A Low = ( %SID% * 2 ) + ( %STEAMBIT% + 960265728 ),  High = Low / 1000000000 + 76561197
	echo %High%%Low:~-9% > useridresult.txt

:end

exit