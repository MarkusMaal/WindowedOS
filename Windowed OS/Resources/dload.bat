::downloads the latest firmware from internet
cd "%appdata%\Windowed Technologies Ltd\Windowed OS\1.1.2.0\Windowed"
set /p server=<server.txt
wget --no-check-certificate "%server%" -O dload.exe
del server.txt
pause