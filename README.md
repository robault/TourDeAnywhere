# TourDeAnywhere

A phidgets based virtual environment for stationary bikes. (circa 2010)

## The Virtual Environment

![Crysis - video game](/3-speeds-small.gif)

I chose the game Crysis for this build because at the time the game environment was tropical and the CryEngine is known to render beautiful scenery. A huge benefit to this game in particular was it came with a map editor. If you get it from Steam, you can find the editor here:

C:\Program Files (x86)\Steam\steamapps\common\Crysis\Bin32\Editor.exe

You could simply load the game at a save point and travel along as you wish, but it's meant to be a game and this one has military combat. Maybe soldiers chasing you around helps your workout, but I wasn't nearly as motivated. Using the sandbox editor, open the "village.cry" map (shown in the animated GIF) by navigating to:

C:\Program Files (x86)\Steam\steamapps\common\Crysis\Game\Levels\village\village.cry

Once open, go to "Mission" in the top menu bar and select "Delete". This removes the military style gameplay from that map allowing for a peaceful traverse around its roadways. Make sure to save a NEW copy somewhere else, otherwise you'll be modifying the game file itself and likely break the normal progression.

Use the W-A-S-D keys for movement and your mouse to control direction so that you're positioned slightly above ground level. Too high and you will drop your character and end the *game*. Now go to "Game" in the top menu bar and choose "Switch to Game". This puts your character onto the map as if you were actually playing it. 

There are 3 speeds of travel, walk, run, and super-speed in the game. You can see these demonstrated in the GIF above. These correspond to the detected speed from the laser and light sensor. You can find the game here:

[Crysis -> Steampowered.com](https://store.steampowered.com/app/17300/Crysis/)

## Hardware Setup

![Phidgets](/electronics.PNG)

This is a very simple setup on the hardware side and I'm stuck having to describe it as I didn't take pictures or video at the time nor do I even still have these parts available. One joystick controls left and right movement, the other controls the camera allowing you to look around the environment separate from the direction of travel; normal movement mechanics in many video games. The laser was zip tied to one side of the wheel fork while the other side had the precision light sensor zipped tied with a lego brick as an insulator allowing a bit of positioning. Initially I used a combination of the laser, sensor, and the wheel reflector that came with the bike but the light sensor would not respond fast enough after a few rotations per second. Since I was only using the reflector as a block for the laser, I tried adding electrical tape along the spokes covering more diameter to see if that allowed a bit more time for the sensor to respond. It did, but at the cost of delaying any change in speed. I then tried wiring up a cyclocomputer magnet sensor to the Phidgets interface kit and started getting more accurate and real time events. I used whatever was in my garage at the time, but you can do the same thing with something like this:

[Bicycle Magnet Sensor](https://www.walmart.com/ip/Planet-Bike-Protege-Rear-Wire-Computer-Mount-Kit-1400mm-Long/31977147)

## Application

![MainForm](/mainform.PNG)

There are "sane" defaults in the constructor.

* Wheel Size: Default is 700c which is equivalent to a 26 inch wheel but a larger list is included in code for other sizes. I was using a mountain bike at the time. 
* Sensor Threshold: Set this for the wheel sensor, YMMV.
* "X" MPH Threshold: Set reasonable miles per hour values for how fast you do or intend on riding the bike.
* "X" Trigger Key: Chose the corresponding key in the game per movement. Most probably use W-A-S-D but you can often re-map these in games.
* Suit Speed Trigger Key: In-game this actually requires a key combination. You have to travel forward using the "W" key, but it's the "Right Shift" key that increases speed to "Run". The in-game suit speed is set by clicking the middle mouse button and selecting the top icon in the on-screen selection wheel. This super speed won't take into effect until the "W" and "Right Shift" keys are pressed. So this setting needs to be the "Right Shift" key to actually work.
* Jump: I never ran into this problem but I considered that the map terrain can have little bumps in it that would occasionally stop movement. This maps the jump to a keypress, by default the "Spacebar".

## Testing

Oh how I wish I had a photo or video of this! All I had for testing was my mountain bike at the time but I didn't have a [bike trainer](https://www.amazon.com/PEXMOR-Magnetic-Reduction-Resistance-Stationary/dp/B082X3DG88/ref=sr_1_6?dchild=1&keywords=bike+racks+%26+stands+resistance+training&qid=1628619857&sr=8-6). But I did have a treadmill and some bungie cords! So I strapped my mountain bike to my treadmill and played with the settings and speed until I could actually *travel* around in the game environment. It actually worked! 

## Parts

* 1x - [PhidgetInterfaceKit 8/8/8](https://www.phidgets.com/?tier=3&catid=2&pcid=1&prodid=1035)
* (omit as it didn't work) 1x - [Phidgets Light Sensor](https://www.phidgets.com/?tier=3&catid=8&pcid=6&prodid=115)
* 2x - [Phidgets Mini Joy Stick Sensor](https://www.phidgets.com/?tier=3&catid=15&pcid=13&prodid=84)
* 6x - [Phidget Cable 90cm](https://www.phidgets.com/?tier=3&catid=30&pcid=26&prodid=1152)
* (omit as it didn't work) 1x - [TTL Laser Retail](https://www.sparkfun.com/tutorials/260)
* 1x - [Bicycle Magnet Sensor](https://www.walmart.com/ip/Planet-Bike-Protege-Rear-Wire-Computer-Mount-Kit-1400mm-Long/31977147)

## Finally

Bike trainers have dramatically come down in price, or at least very off name brands (probably from overseas) can be bought for a lot less money. Aaannnddd, that was it. I didn't want to buy a trainer or a stationary bike, nor could I afford to at the time. So I left it, being quite satisfied I had created something as good or better than what higher end exercise equipment offered. Of course having a screen and virtual environment are common today. Tablets nor the software were good enough to do this either. Overall, I'm pretty happy with how it turned out. Admittedly not the best coding, but what side project ever is. As a former co-worker said to me, "If it works then it's not stupid". :)
