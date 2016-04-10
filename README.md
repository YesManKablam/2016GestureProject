# 2016GestureProject
*** John Conor Kenny and Dan Maloney ***

## Purpose of the Application
The purpose of this application is to exploret the use of alternative control methods in video games.

## Gestures Identified
The Myo armband comes with a series of gestures that you can make with your hand. These gestures include:
1. A Fist
2. Wave Left
3. Wave Right
4. Fingers Spread
5. Double Tap Fingers

There is also the abilitiy to create your own gestures for use with the device, by combining these gestures with arm movements.
However the default gestures run the gamut of what may actually be useful, and most instances they will be all you need and more.

<img src="https://a.pomf.cat/bakisl.jpg">

The gun in the game had several functions. It would need to move, be able to fire, and be able to change the firing mode.

Movement was a no-brainer. Using Myo's panning and rotating, we were able to map the gun to essentially be the player's arm.
By setting up the gun's pivot point to line up with the player's shoulder, the resulting analagy worked very well. This also allows you to turn the gun sideways in the game.

For firing, we looked at the other available gestures. The two that stood out to us as being good choices for firing a gun were the closed fist gesture, and the double finger tap.
Both fit somewhat closely to their real-world counterpart of pulling a trigger. When we tested out each gesture, we found that the closed fist felt better.
The input felt more natural and responsive. The finger tap always felt a little delayed, and for that reason the fist gesture was decided upon. 
Haptic feedback was then added when this gesture was recognised, giving the player a solid indcation that their input was definitaly recieved.

For the firing selector, we originally decided upon using the wave left and wave right gestures as inputs. Going from a closed fist to flicking your hand left or right was quite quick.
However, it was not as responisive as we would've liked. And at other times, it was far too responsive. Many times, either nothing would happen when you move your wrist, or the armband would pickup on an imput when you were only moving your arm to aim.
Eventually, it was decieded to scrap the wrist inputs and to use the double finger tap gesture as a firing toggle. While the double tap seems to have a slight delay to it, the delay is far more perferable than the false inputs that the wrist movements were giving.

Another gesture that is in the game is the finger spread. This resets the armbands position to the center, and is a default input of the Myo SDK.

## Hardware Used
The Myo armband was the main piece of this project. Developed by Thalmic Labs, the armband allows for hands-free control of computers, tablets and phones. It can be used to control a varity of different apps and games with your wrist and forearm..

The armband uses a set of electromyographic sensors that sense electrical activity in the forearm, combined with a gyroscope, accelerometer and magnetometer to recognize gestures in arm movement. The armband is unable to detect an arms postion in 3D space, meaning that there is way to introduce "depth" to projects.
## Solution Architecture

## Conclusions & Recommendations
