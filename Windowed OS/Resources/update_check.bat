::lets Windowed OS know if there is an update available
cd "%appdata%\Windowed Technologies Ltd\Windowed OS\1.1.2.0\Windowed"
set /p server=<server.txt
wget --no-check-certificate "%server%" -O version.txt 2>nul
del server.txt