::This batch script gets the location of Windowed OS data folder
@echo off
md C:\temporaryfolder
@echo.%appdata%\Windowed Technologies Ltd\Windowed OS\1.1.2.0;>C:\temporaryfolder\path.txt
exit