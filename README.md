# HidRawDataWatcher
Tested with PC, Xbox360 and PS2 gamepads under Windows7 x64
![screenshot](https://raw.githubusercontent.com/djlastnight/HidRawDataWatcher/master/HidWatcher/Images/screenshot.png)

Working with this tool is quite easy:
1. Choose usb device from the list
2. Hit the start button
3. Do something with your hid device (ex: hit button for gamepad)
4. The app will display the raw data bytes (for gamepad). Their count is different for each device.
Changed bytes are marked in red color. Unchanged bytes are marked in blue color.
You can unsubscribe for specific byte(s) changes. This is usefull for guitar controllers in example,
where the axis (tilt) data always changes and as result you will be unable to read the output at all, because it changes very fast.
5. Analyze the raw data and convert it as you wish (I prefer xinput data or midi data).

djlastnight,
2018
