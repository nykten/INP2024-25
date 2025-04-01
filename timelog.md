# Timelog for **Remapping** module by Nik Harith (2673209B)
This file is used to track my time as I have a bad habit of losing time and getting to see my time spent well satisfies me.
It follows a previous student's repository which also had a timelog but the latest template doesn't seem to provide this, so I made it my own.

## December 2024

### 26 Dec 2024

* **3 hrs**: Researching on previously the SDK previously used by Harvey for his implementation to get live camera access and understanding his codebase by inspecting the scripts and reading his paper.
* **1 hr**: Found out that Vive has updated their passthrough API to comply with OpenXR and removed the previous SDK. It *cannot* be downloaded anymore. *(\*facepalms\*)*
* **1 hr**: Tried implementing the OpenXR SDK implementation for the passthrough API, however results cannot be confirmed without using the headset directly. Implementation available at [this repository](https://github.com/nykten/Vive-ProEye-OpenXR-Passthrough).
* **1 hr**: Deleted 'Redundant scripts' folder in harvey's project that caused errors. Now can be run, but without the headset, I cannot test it.

## January 2025

### 15 January 2025, 16:30

* **1 hr**: First meeting with Paul after semester break. Discussed about project update, which is slow and need to pick up the pace. Decided to meet weekly at 4pm this semester.

### 16 January 2025, 11:00

* **30 mins**: Caleb and I asked for the keys to access Paul's office. Need to get confirmation from Paul. Gave a list of software to install on office machines to the IT Department.
* **1 hr**: Tested Harvey's code and HTC's sample projects, but unable to proceed due to requiring admin access.

### 20 January 2025, 15:30

* **2 hrs**: Updated design of *VF Remapping Menu* scene.

## February

### 3 February 2025, 11:30

* Would need to change development track, instead of reinventing the wheel.
* **5hrs**: Merged Alfie + Harvey's project worked but Harvey's scene was butchered haha.
  * Method of merging: Set Harvey's project as base, then copy over Alfie's stuff. Codename: **IntegratedVFApp**, available [here](https://github.com/nykten/IntegratedVFApp)
  * First time running, alfie's stuff had error because some of the script in folder {ViveSR} was not available
  * Then copied over the other scripts, but then it broke Harvey's scene herm
* Next step to try: try the reverse way. Set Alfie's project as base.

### 4 February 2025, 11:00 & 17:45

* **11:00, 2hrs**:
  * Tried debugging *IntegratedVFApp* to resolve issues by copying scripts and meddling with the project settings in Unity Editor, but no change.

* **17:45, 3hrs**: 
  * Coffee machine downstairs not working...
  * Merge projects using Alfie's as the base. Codename: **Integra**, available [here](https://github.com/nykten/Integra)
  * Compared scripts and did a *manual* merge of some scripts using Diffchecker tool online.
  * Mapped InputActions manually through *Window > SteamVR Input*, but controls still not working.
  * Went home at 21:00

### 5 February 2025, 11:00, 16:15& 18:00

#### **11:00, 2hrs**

* Again, debugging both projects to make them functional.
* Tried reconfguring ActionInput scripts again.

#### **16:15, 1hr**

* Meeting with supervisor, discussed project updates and current struggles.
* To justify my work in dissertation, the focus would be on the *engineering* side of things.
* Try to get 2-3 people to test our project so far so they could give early feedbacks.
* Do initial tests to measure what's actually needed for the real test.

#### **18:30, 1hr**

* Deleted Library file to rebuild it.
* Tried playing around with action input scripts again to restore controls into Harvey's scene.
* "OpenXRVRSDK.dll not found" error keeps popping up when running the game mode.
* Meddle around with "IntegraVFApp", but still no luck
* Tried reinstalling srworks SDK but nothing.
* Ends at 1930 or so.

### 6 February 2025, 11:00

#### **11:00, 2hrs**

* Staring at the **DllNotFound** error...
* Reset Library folder again...
* Reload and reinstall OpenVR Desktop SDK
* Stems from the OpenXRVR SDK.. I wonder if I delete it...
  * *HOLY SHIT IT WORKED LMFAO*
* Also actually in Alfie's stuff; he mapped the controls to something I haven't assigned to in the bindings, so I settled that and then it works.


## Week 5

### 10/2 2025 Monday
* Doing not much, but figured out what to do for 1st test
* That is: testing which UI mode to use
  * Far-away UI with navigation enabled
  * Far-away UI without navigation
  * Follow-head UI
* Above: IV
* DV: Comfort and usability of the UI
* CV: 
  * Pico headset
  * User starting location
  * Uniform UI 
*  RV: IPD
*  The above will use PICO for testing, for the sake of portability

### 11/2 2025 Tuesday
* To build stuffs
* 1800: building scenes
* Built far away moving scene
* 2030 end

### 12/2 2025 Wednesday
* 0000 start
* Built all 3 conditions
  * Complete with scene navigation to VFT & VFR menu
  * FollowHead.cs works
* 03:30 end
* To test:

## Week 6

### 18/2/2025, 17:00
* Test with person #2 & person #3
* Update some parts
* 18:30: test with Kah Fai
* Avg test time: 17 mins including wear headset 1st time until last form submission
* 19:00, work on diss
* 19:30, rehat solat makan
* 20:30 restart because doors r locked, Intro section. Background section

### 19/2/2025, 15:40
* Making notes of what to do this week
* 16:15~17:00 user test #5 #6 done yahoo!!!
* 18:40 ~21:30 investigating dots

### 20 Feb 2025
#### **18:40, 3hrs**

* Played around with Alfie's stuff to get to know how it generate reports
* But the filepaths are broken, attempting to repair.
* Couldn't repair by the time I go back

### 21/2/2025, 16:40 
#### **13:30, 1.5 hrs**
* Resolved filepath errors
* Tested and currently thinking how to use it for VF Remap...
* Decided to just stimulate the data instead of using the real ones at the moment for the sake of time haih
* Get bullet points into dissertation
* And then convert that into full text
* Talk about the benefits of the product
* Explore future


## Week 7


### Tue, 25/2 2025 11:30
* Trying to make CORE menu - successful! Copied from Harvey's
* Also linked the scenes with transitions (thanks alfie!)
* Next step:
  * Revamp VFT menu
  * Edit VFR Menu
* Ends at 13:00

* VFTnR, 18:50
* Colour codes:
  * Greyiy: #434343
  * StartBlue: #3291FF
  * Highlighted: #1F5CA2
  * Selected: #0015C0
    
### Wed, 26/2 2025; 21:00
* VFT Menuing done
* Ponder about how to test and searched common data formats
* Stumbled upon 1 repo that have HVFs data
  * Json format
* Another repo processes HVF datas but need DICOM format (.dcm) 
  * Data with these format is hard to acquire
* Normal vision: camera scale = 1.
  * Else, fit in and reposition
  
  ### Meeting 16:00, 26/02/2025
* Use past student's data structure
* Or define ourselves
* Standard data report:
  * Optos nikon
* International recognised data
* How to make it compatible with the above recognised data
* Organisations standard
* ISO standard, IEEE
* Different corrections look like with different real example
  


### Thu, 27/2 2025; 11:30
* Taped some sticky notes to simulate Hemianopia
* Finnicky and reduces eye-tracking accuracy
  * Plus cannot calibrate properly
  
* 15:00 researched on how to remap
* Referred to Garcia's method.
  * Cool but hard to implement with our stuffs

* 21:00 
  * So Harvey put the remap script locally on each RenderPlane(left/right) which is the live camera feed.
  * Then in his script, he only gets the transform.localPosition and scale.
  * Rather than using GetComponent<>.transform. Blablabla
* Test:
  * Have 2 oranges left and right, then remap until you see the orange
  * Correction: use the table as a way to measure the extent

### Sat, 01/3 14:00
* Used papers and tack-it to stick the Hemianopia occlusion to the headset's lenses.
* Tried out to measure the extent of the table.
* Design test around this?

### Sun, 02/3 11:45
* Created PresetRemap.cs script with smooth gradual transition to desired remap position (now only HH-right condition).
* Tested against the extent of table above. Very nice.

* Variables to measure during test:
  * Efficiency - time taken to accomplish the task
  * Accuracy of remapped area - how do I measure this? Screenshot? Scale & pos of renderPlane? But what counts as accurate?
  * Comfort when performing the remapping process - use NASA-TLX



## March baby

## Week 8
### Mon, 3/3/25
#### 1400
  * Make more automatic presets for more types of visual field defects

### Tue, 4/3/25
#### 1130
  * Try to make automation for data collection
#### 1900
  * tried to automate data collection when experiment testing the whole day…
  * Pilot-tested with one real participant (pilot/pretest). Feedback was:
    * Very motion sickness-inducing when altering each eye, especially bitemporal adjustment
    * Recommended to use only both eyes for testing
    * "Why not test on a flat wall surface or something instead of the table?"
  
### Wed, 5/3/25
  * Tested out the idea of using a flat canvas on a wall to do the test
    * Not very efficient and actually harder to control due to seat limitation and low fidelity of the camera makes it hard to recognize anything on the canvas.
  * Thus, improved on table-based task. Now the goal is to recognise objects on the table and remap until all objects are visible.
    * Randomise objects on each run so that user won't remember.
  * Streamlined automatic remapping process to just use Harvey's remap object and start the remapping as soon as it enters the scene, rather than confirming inside camera view.

### Thursday, 6/3/25
#### 10:30
  * Pilot tested with another user, feedback generally OK and not that nauseous.
  * But will scrap bitemporal condition anyways due to complexity
#### 1900
  * Fixed time tracking stuff
    * Confirmation to exit now pauses the time tracking
* Add position and scale data after remap so we can compare later

### Meeting 16:33, 07/03/2025
* Backfill the backgrounds section
    * Draw the conclusions what I wanna do
* Title: focus on integrating the systems
* Just add the test along with general UI user testing.
* Grind on background

## 9th Week

### Mon, 10/3/25
#### From 1000
  • Set up tests, taped markers on floor
  • Completing form setup
#### 14:30
  • Test run #1 with Atem
  • Quite long and bersepah, but needed
  • Ended at ~15:30?
#### 15:40 - 18:00
  • Pair programming with Caleb
  • Try to resolve importing new ver. to old ver.



### 12 March 2025
#### **10:00, 2hrs**

* Experiment run #2 with Ravin, lasted at most ~40 mins?
* Put collected data into repository
* maybe need to add full SUS question into study but study already with 2 ppl how?

### 14 March 2025
* Experiment run #3 at 2pm

### 17 March 2025
* Experiment run #4

## 18 March 2025
* Experiment run #5
* Experiment run #6

## 19 March 2025
* Experiment run #7

## 20 March 2025
* Experiment run #8

### 26 March 2025
* Grinded dissertation from 8pm until 6am no sleep
* Future readers: please don't copy me.... i'm literally dying here. 
* do your work early, start wrtiting early!!

### 27 March 2025
* Grinded dissertation from 8pm until 12pm (next day) no sleep 360 no scope ezpz
* Data wrangling is not easy...

### 28 March 2025
* Extension approved until 1 April!!

### 29 March 2025
* Data wrangling session

### 31 March 2025
* Project Presentation at 5pm with Paul
* Grind dissertation until next day no sleep again, hopefully last.
