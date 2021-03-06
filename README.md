﻿##
## Editor Extensions For KSP v1.1
##
##

## Changes in 3.2.13
	Fixed Fine Adjustments window (inability to close it or change the values)
	Now saves both angle snap value and whether it was on/off after exiting editor session
	Fixed issue with fine adjust translation wouldn't work if snap was on

## Changes in 3.2.12
	Fixed rotation gizmo to not angle snap when anglesnap is off
	Replaced code which did FindObjectsOftype with GizmoEvents class for performance improvement
	Updated FineAdjustments window to detect which gizmo is active

## Changes in 3.2.11
	Added 1/4 second delay in hiding menu

## Changes in 3.2.10
	Added UI scaling code to position of EEX menu
	Fixed accidently disabling the ability to change the anglesnap on/off by clicking the sprite

## Changes in 3.2.9
	Removed old code from the FineAdjust Update function which was causing an exception
	Reduced height of popup menu
	Fixed bug where clicking on the symmetry sprite (the one which changes the angle snap degrees) when the angle was zero
	would not allow surface attachments to anything other than the +z axis:
		"I can place the battery only on the +z axis of the structure.  I cannot place it on -z, +x, -x"
	Removed performance issue when Fine Adjustments window was shown
	Reduced performance impact when fine adjustments are being done

## Changes in 3.2.8
	Added code from Fwiffo to fix bug where changing the angle snap while in rotate mode would not affect the rotate gizmo
	Added code from Fwiffo for Rapid Zoom
	Note:  Code from Fwiffo was modified to use the Reflection offsets rather than names to maintain compatibility with Linux & OSX
	Fixed bug where going into the rotate gizmo the first time without changing the snap would have a rotation snap of 15 when it should have been zero

	NEW FEATURE:  Fine Adjust
	Fine Adjust window added
	New config window for fine adjust keys
	When Fine Adjust window is open, keys will do fine adjustments depending on which gizmo is selected:
		Default keys:	arrow keys + rightShift & rightControl

## Changes in 3.2.7
	Added code so that typing in text fields will be ignored by mod

## Changes in 3.2.6
	Added compatility for 1.1.2

## Changes in 3.2.5
	Added back 1.1.0 compatiblity
	Added check for compatibility with specific KSP versions, currently 1.1.0 & 1.1.1

## Changes in 3.2.4
	Fixed offsets to eliminate nullrefs

## Changes in 3.2.3
	Updated for 1.1.1

## Changes in 3.2.2

Includes submods:
	Strip Symmetry
	No Offset Limits
	SelectRoot2Behaviour

### Features
* Allows custom levels of radial symmetry beyond the stock limitations.
* Horizontally and vertically center parts.
* Re-Align placed struts and fuel lines between parts 
* Adds radial/angle snapping at 1°,5°,15°,22.5°,30°,45°,60°, and 90°. Angles are customizable.
* Toggle part clipping (From the cheat options)
* Toggle radial and node attachment of parts
* Reset hangar camera view
* Customize hotkeys
* CKAN & KSP-AVC versioning support
* Rapid zoom mode when using keys to zoom (when using stock zoom mode)

#### Vertical/Horizontal snap:
* Place the part, then once the part is placed, hover over the part with your mouse and press the Vertical or Horizontal snap hotkey.
* For vertical snap, part will center itself on the part lengthwise in the SPH

#### Strut & Fuel line alignment
* Place the strut, then hover over the base/start of the strut (the first end placed) with the mouse, and press the hotkey.
* Strut/FL start and end with be snapped to the closest of either the middle, quarter, or end of the part, aligned directly between the two parts.
* Mod/Alt-U will reposition the strut/FL directly between the parts, but only level out the strut from the start/parent part.

#### Rapid Zoom mode
* Zoom in / out more rapidly by double-tapping the zoom in / out hotkey.  i.e. If you just hold down the "zoom in" hotkey, 
  it works like normal.  But if you double-tap-hold, it zooms in at 5x the speed.  Releasing the hotkey sets zoom back to normal


### Default Keybindings
* **V** 			- Vertically center a part. Place the part, hover over it with the mouse, and press the hotkey.
* **H** 			- Horizontally center the part. Place the part, hover over it with the mouse, and press the hotkey.
* **U** 			- Place the strut, then hover over the base/start of the strut (the first end placed) with the mouse, and press the hotkey.
* **Mod/Alt-U**		- Strut will be aligned level with its starting position
* **X, Shift+X** 	- Increase/Decrease symmetry level (Based on KSP's key map)
* **Alt+X** 		- Reset symmetry level (Based on KSP's key map)
* **C, Shift+C** 	- Increase/Decrease angle snap (Based on KSP's key map)
* **Alt+C**			- Reset angle snap (Based on KSP's key map)
* **T** 			- Attachment mode: Toggle between surface and node attachment modes for all parts, and when a part is selected, will toggle surface attachment even when that part's config usually does not allow it.
* **Alt+Z** 		- Toggle part clipping (CAUTION: This is a cheat option)
* **Space** 		- When no part is selected, resets camera pitch and heading (straight ahead and level)

#### Strip Symmetry
* Alt-Shift left-click on the part and symmetry will be stripped from it
  ***On Linux, the keys are:  Left-Alt Left-Shift Left-Click

#### No Offset Limits
* The offset tool now does not have any limits.  Nothing needs to be done, this just works

#### Select Root 2 Behaviour
* This simplifies the select root functionality.  No need to click the same part multiple times.
* **4**			- Activates the stock code, or click on the select-root icon
			      Click on the part you want to be the new root.  It will be made root AND will be selected,
			      so you need to position the ship and click to drop it

In this version there is also a still-incomplete feature: A part-zoom/part camera orbit - the numpad . key will focus and orbit the camera around the part under the mouse. hitting numpad . again with no part under the mouse will reset the camera back to normal. Currently in the focus mode dragging parts gets skewed so it is only good for viewing the part from another perspective, and not editing or moving parts.

###Installation
In your KSP GameData folder, delete any existing EditorExtensions folder.
Download the zip file to your KSP GameData folder and unzip.

[KSP Forum Thread](http://forum.kerbalspaceprogram.com/index.php?/topic/127378-editor-extensions-redux-301-released-with-selectroot-merge-stripsymmetry-nooffsetlimits/)

Released under MIT license.
Source available at GitHub: [https://github.com/MachXXV/EditorExtensions](https://github.com/MachXXV/EditorExtensions)

