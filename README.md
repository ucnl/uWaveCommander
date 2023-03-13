# μWaveCommander
uWave underwater acoustic modems demo application

[🡇 Download latest release](https://github.com/ucnl/uWaveCommander/releases/download/1.0/uWaveCommander.zip)

## How to use μWaveCommander

### 1. Connecting your modem to a PC

You will need a **UART-USB** converter, that can work with 3.3V UART. Here is diagrams for soldering:  
Before connecting to a PC, make sure that **CMD** wire is connected to **GND**

![fig1](https://docs.unavlab.com/documentation/uwave_usb_cmd_mode_off.png)

After connecting to your PC, you have to connect **CMD** wire to logic one (3.3 or 5 V) to enable [command mode](https://docs.unavlab.com/documentation/EN/uWAVE/uWAVE_Family_en.html#32-command-mode) in your modem:

![fig2](https://docs.unavlab.com/documentation/uwave_usb_cmd_mode_on.png)

### 2. Using μWaveCommander

Run the application and press **🔌 LINK** button, if everything is done properly, the application will find your device soon:

![fig3](/Pics/15-44-06.Png)

You will see information about the device: FW version, serial number etc.

### 3. Testing built-in sensors

You can see real-time plots of readings of built-in sensors - pressure, depth, temperature, voltage etc.
To enable the feature:

#### 1. Go to tab **Local Sensors** and check following buttons: **P, mBar**, **🌡, °C**, **🡇, m** and **⚡, V**.
#### 2. Select **1_SEC** in the **Update period, msec** combobox
#### 3. Press **🡇 APPLY** button

You will see something like that:  

![fig3](/Pics/15-54-53.Png)

To disable the feature:

#### 1. select **NEVER** in the **Update period, msec** combobox
#### 2. Press **🡇 APPLY** button

### 4. Working with Short command requests

Go to tab **Remote requests** and press **AUTO** button. The application will start to invoke the modem sending sort remote requests.
If you have the second device from the [uWave devices family](https://docs.unavlab.com/documentation/EN/uWAVE/uWAVE_Family_en.html) properly set up and turned on, you will see something like the following pic:

![fig4](https://github.com/ucnl/uWaveCommander/blob/main/Pics/16-00-42.Png)

### 5. Packet mode

Go to tab **Packet mode**. 
Here you can:
- send packet requests (similar to short requests, but performed with logical addressing among 255 devices)
- send data packets with guaranteed delivery
- received data packets 

Here is a relevant screenshot:

![fig5](https://github.com/ucnl/uWaveCommander/blob/main/Pics/16-02-19.Png)

