![Noodler Logo](https://cdn.discordapp.com/attachments/347089516055494658/972891628731781262/Noodler_logo.png)
### Supervised by James Hayter
[![Windows](https://svgshare.com/i/ZhY.svg)](https://svgshare.com/i/ZhY.svg)  [![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=flat&logo=unity)](https://unity3d.com)

[Trello link](https://trello.com/b/rg7rnQ0O/comp-3000)

[Youtube video link](https://youtu.be/oI5ElCPuYG0)

Also [this is a pool noodle](https://en.wikipedia.org/wiki/Pool_noodle) for reference, though in my own implementation I used pipe insulation with electrical tape surrounding it 

## Vision
Originally the vision had been to implement Kinect functionality into unity to track a pool noodle, to give developers a new tool for soft body tracking and simulation and an interesting game to demonstrate it, however issues with getting it working, and rending it in the correct world space with the VR Headset, as Kinect is specialised for relatively 2D type games.

So now the program attempts to simulate the noodle's physics and is tracked using the controller's own drivers. And due to the time wasted on kinect development and other projects it has been downsized to an easy simple tennis ball smacker, deflect the balls to earn points and extra time, the game ends when you run out of time.

## Installation and setup
### Setting up the program
**If the build.exe works**
1. Download & unpack the .zip in releases
2. Make sure your VR headset is plugged in and steamVR is running
3. Execute Noodle.exe

**If the build.exe is not working**
1. Download & unpack the .zip in releases
2. Make sure your VR headset is plugged in and steamVR is running
3. Open unity hub and set the "Noodler" folder as a project and open it
4. Make sure the OpenXR Runtime headset is set to SteamVR

![Unity instruction image](https://cdn.discordapp.com/attachments/347089516055494658/972882492384239706/Instructions.PNG)

5. Hit play and the game will start in the headset
  
      5a. If your computer is powerful enough you can re-enable the spectator camera and split the explorer into display1 and display2 to show a different angle whilst       the game is output to the headset, like below:

![Unity spectator cam instructions](https://cdn.discordapp.com/attachments/347089516055494658/972883860926906418/Spectator_cam_instructions.PNG)
### Setting up the controller
1. Optain some tape, or better yet, some velcro cable managment ties and a 1 metre long hollow foam cylinder, either a cut down pool noodle or some pipe insulation will do
3. Attatch the cable ties like so **_to the right controller_**, try to have one go just behind the trigger so the bulge aids in holding it steady, but don't go too far back as it will press down on the menu button constantly. Also putting the wrist straps around the pool noodle will help prevent it sliding off in an emergency.

![Controller attatchment instructions](https://cdn.discordapp.com/attachments/347089516055494658/972884260048498729/IMG_20220508_154917.jpg)

The tape is placed to help indicate a place for the controller as well as to provide strength, as these pieces of pipe insulation, you may have to do the same with yours if it has these pre-cut lines.

### Installing the prefab
1. Download both the prefab and model/fbx files
2. Drag and drop them into your unity project

## Contact
Find a bug you can use the issues tab, but if that doesn't work then I can be reached at zacharycummings80@gmail.com
And if you like what you see for some reason then my [linkedIn is here](https://www.linkedin.com/in/zcummings)

## Licencing
Due to me adding a kinect package to the project, and me being unable to remove it without destroying everything, the Game is under an:   
[MIT License](https://github.com/BirbRoss/COMP3000-Project/blob/main/KINECT%20LICENSE)
As it is technically a copy of their code.

As for the noodle prefab and model, those are kinect code free so use as you please under a: 
[GNU GENERAL PUBLIC LICENSE](https://github.com/BirbRoss/COMP3000-Project/blob/main/NOODLE%20PREFAB%20LICENSE)

### Keywords
Foam pool noodle | Virtual reality | VR 
