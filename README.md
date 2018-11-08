# Support me on Patreon
<a href="https://www.patreon.com/djlastnight" style="font-size:50px">
  <img src="https://c5.patreon.com/external/logo/rebrandLogoIconMark@2x.png"
       height="40"
       style="vertical-align:top" />
  Click here to become a patron and get your reward!
    <img src="https://c5.patreon.com/external/logo/rebrandLogoIconMark@2x.png"
       height="40"
       style="vertical-align:top" />
</a>

# HidRawDataWatcher
Tested with PC/Xbox360/XBOX ONE/PS2 gamepads, USB mice, USB keyboards and Windows' On-Screen Keyboard under Windows7 x64 and Windows 10 x64.

![screenshot](https://raw.githubusercontent.com/djlastnight/HidRawDataWatcher/master/HidWatcher/Images/screenshot.png)

Working with this tool is quite easy:
1. Choose device from the list
2. Hit the start button
3. Do something with your hid device (ex: hit button for gamepad)
4. The app will display the raw data.  
For gamepads the data comes in bytes, which count is different for each device.  
Changed bytes are marked in red color. Unchanged bytes are marked in blue color.  
You can unsubscribe for specific byte(s) changes. This is usefull for guitar controllers in example,  
where the axis (tilt) data always changes and as result you will be unable to read the output at all, because it changes very fast.  
5. Analyze the raw data and convert it as you wish (I prefer xinput data or midi data).

This repo uses complied HidRawData.dll from https://github.com/djlastnight/HidRawData

djlastnight,
2018
