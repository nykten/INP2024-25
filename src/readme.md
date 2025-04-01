# Integrated Visual Field Testing and Remapping - README

**Due to the large files of the Unity project, the only things submitted are the C# scripts and the scenes.**

The full `src/` & the whole project is now hosted and accessible through the following repository: [test]([test](https://github.com))

## System Overview

This project is an integrated VR-based platform where users could assess their visual field using the Visual Field Testing module and remap/shift their vision using the Visual FIeld Remapping module.

This project is a culmination of multiple generations of students. So if you're chosen, welcome to the club! Oh and good luck!

## System Requirements

### Hardware Requirements

* VR-capable PC with GPU
* HTC Vive Pro Eye headset
* Vive tracked controllers
* SteamVR 2.0 Base Station(s)
* Steam & SteamVR 
* This project was developd in Windows 10

### Unity-specific requirements:
* Unity Editor version: `2019.4.35f1` *(exact version required to prevent plugin conflicts)*
* SteamVR Plugin: `2.7.3`
* SRanipal SDK: `1.3.6.8` *(this is now deprecated - ensure you have local admin access)*
* Vive SRWorks SDK: `0.9.8.4` *(this is deprecated - ensure you have local admin access)*

## Important Project Structures

* `src/IntegratedVFTnR`: Main Unity project directory  
* `Assets/Saved Data/run/[timestamp]`: Stores raw, processed, and report data for each test mainly for VFT module
* `Assets/Python Script`: Python scripts for analysis 
* * `Assets/Scenes`: Unity scenes are store here


## Running in Unity Editor

**The project can be ran after a build, but VFT reporting wouldn't work**

1. **Open the Project:**
   * Open Unity Hub
   * Open Project
   * Navigate to `src/IntegratedVFTnR`  

2. **Before Running:**
   * Connect and power on the Vive headset and controllers
   * Launch and ensure SteamVR is running
   * Start SRWorks Runtime
   * Launch SRanipal with administrator access 

3. **Run the Project:**
   * Navigate to `Assets/Scenes/Core Menu` to enter the Main Menu  
   * In Unity Editor, press 'play' to enter Game Mode
   * Use the VR controller trigger to interact with the UI  
   * Select any module, VFT or VFR


## Contact and help
Congratulations on continuing this project! The setup of this project is honestly convoluted and troubled, trust me. 

If you require further help, please do not hesitate to contact me through my email: [kayyinx@gmail.com](kayyinx@gmail.com). I will gladly help you through your pain.