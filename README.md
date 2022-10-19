# μWaveCommander
uWave underwater acoustic modems demo application

[🡇 Download latest release](https://github.com/ucnl/uWaveCommander/releases/download/1.0/uWaveCommander.zip)

## How to use μWaveCommander

### 1. Connecting your modem to a PC

You will need a **UART-USB** converter, that can work with 3.3V UART. Here is diagrams for soldering:

Before connecting to a PC, make sure that **CMD** wire is connected to **GND**
[!fig1](https://docs.unavlab.com/documentation/uwave_usb_cmd_mode_off.png)

After connecting to your PC, you have to connect **CMD** wire to logic one (3.3 or 5 V) to enable [command mode]() in your modem:

[!fig2](https://docs.unavlab.com/documentation/uwave_usb_cmd_mode_on.png)

### 4. Using μWaveCommander

Run the application and press **🔌 LINK** button, if everything is done properly, the application will find your device soon:

[!fig3](/Pics/15-44-06.Png)

You will see information about the device: FW version, serial number etc.

