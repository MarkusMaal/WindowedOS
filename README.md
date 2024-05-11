# Windowed OS

This is a full operating environment with a desktop interface written in Visual Basic. Originally developed as a competitor/fan-made successor to Program OS by Daniel Morris (a.k.a. TheDevelopmentOfWindows).

The project is not currently in active development by me, because it contains a lot of bad programming practices I had back when I it, making its code pretty difficult to read. The project was in active development during the 2016-2020 period, with only minor changes being made recently.

## Highlight features

- Real multitasking with movable and resizable windows
- Different types of user accounts, including...
	- Power User
	- Administrator
	- Standard
	- Limited
	- Guest
- Transparent windows
- Many customization features (per user), including...
	- Customizable theme colors, including 20 color schemes
	- Launcher and clock positioning
	- Customizable fonts
	- Customizable background
- 15 built-in apps
- Support for creating custom apps using VoidScript with built-in Voide IDE
- User account images
- Login and lock screens

## Included apps

- Calculator
- Image Drawer
- Scoreboard
- Picture Viewer
- Notepad (with rich text support)
- File Browser
- Command Prompt
- Game: TicTacToe
- Game: Click it
- Game: Simon
- Web Explorer
- Media Player
- Voide IDE
- Message box test
- Tasks and resources

## Window management

- Each window can be moved by dragging it by the title bar.
- Each window can be resized by dragging it from bottom right corner. Not all windows can be resized.
- Each window can be hidden by pressing the H button in the top right.
- Each window can be closed by choosing "Close" in the file menu.
- Each application can be closed by choosing "Exit" in the file menu. This will close ALL instances of that application.
- It's also possible to terminate applications on using the "Tasks and resources" application. You can also restore hidden windows this way as well.
- Transparency can be enabled by checking "Enable desktop composition" under the "View" menu on the action bar.

## Out of box experience (OOBE)

When you first launch Windowed OS you'll experience the first time setup process. During this process, you'll be guided through 3 main stages:

1. System configuration - In this stage, system wide configurations are set, such as wether to enable startup screen, custom application support, etc.
2. User account configuration - In this stage, up to 3 user accounts can be configured. Later, more user accounts can be added if desired.
3. Saving settings - In this stage, all configured settings are saved and finally a restart is performed.

## Disabling/Enabling developer mode

Developer mode can be disabled/enabled by changing the **dev** variable value in Desktop.vb.

If developer mode is enabled, the following changes occur:

- Certain experimental features are enabled
- A watermark is displayed on startup and desktop
- A dedicated button for breaking the program while a debugger is attached is added to the Power menu

## Startup hotkeys

- Pressing the **DEL** key while the startup screen is displayed, a recovery mode screen appears, where you can perform certain tasks.
- Pressing the **F12** key allows you to perform a soft-factory reset, which deletes all user accounts and system settings, but does not uninstall custom applications

## Voidscript

Voidscript is a custom programming language developed specifically for Windowed OS, which is used in Voide IDE. It's unfinished in its current state, but functional enough to create simple "Hello world" applications.

## Screenshots

![Multitasking desktop](screenshots/2.png)
![Initial setup](screenshots/9.png)
![Tasks and resources](screenshots/3.png)
![Lock screen](screenshots/4.png)
![Transparent windows](screenshots/5.png)
![Crash screen](screenshots/6.png)
![Login screen](screenshots/7.png)
![Settings window](screenshots/8.png)
