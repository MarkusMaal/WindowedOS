::downloads and starts upgrader, which downloads the update
cd "%appdata%\Windowed Technologies Ltd\Windowed OS\1.1.2.0\Windowed"
wget --no-check-certificate "https://docs.google.com/uc?export=download&id=1Ht4Y9sy74gJPV1piW9oRiyXQrA0Y21zR" -O upgrader.bat 2>nul
start upgrader.bat
del %0 /Y >nul
exit
