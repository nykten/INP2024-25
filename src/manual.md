# User manual 

Please refer to `src/readme.md` for hardware specifications to run the program

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

## Using the Visual Field Testing (VFT) module

The VFT module measures your visual field and produces a report at the end of the test.

* **Test with Feedback:** Perform the visual field testing with visual feedback.
* **Test without Feedback:** Perform the visual field testing without visual feedback.

1. Enter the VFT module by selecting the module from the Core Menu.
2. Choose one of the test mode (with/without feedback)
3. Press Spacebar to start the test (after a 3-second countdown)  
4. Once flashing dots are appearing, press spacebar every time you see to register stimulus detection.
5. After the test concludes *(around ~5mins)* a report will automatically be generated in `Assets/Saved Data/run/[timestamp]/`, along with the raw data.

## Using the Visual Field Remapping (VFR) module

The VFR module allows you to remap the live camera feed from the headset into the available FOV of any individual with visual impairment. For the normal-visioned people, it's a fun way to get nauseous instead.

There are 3 different modes within this module:
* **Manual Remap**, Scale X & Y
* **Manual Remap**, Scale X only (prone to motion sickness)
* **Automatic Remap**:
  * Right Homonymous Hemianopia
  * Left Homonymous Hemianopia
  * Right Temporal Quadrantanopia
  * Left Parietal Quadrantanopia

### Performing VF Remapping

1. Enter the VFR module by selecting the module from the Core Menu.
2. Enter any mode you prefer to activate the camera passthrough mode.
3. Once inside the passthrough mode, use your controller to refer to the controls.
   1. The trackpad allows manipulation of the X-axis position and the scaling of the vision.
   2. Trigger button switches which eye you are manipulating currently.
   3. Grip button resets all changes to default configuration when it was first loaded.
4. Remap the vision as you please, but be careful of the potential motion sickness you might get from drastic shifts or prolonged use.


## Note
If you experience any discomfort, nauseous or headache, please take your time off from the headset. It is normal to feel it the first few times before getting used to it (hopefully).
