# CubeScan
Ribik cube solving project

1.) Flash the Arduino board with the 'CustomCube' sketch.
2.) Install the CubeScan program on your PC.
3.) Set up a webcam to point downward at the top of the cube (any webcam will do). The camera should be aligned so that the top of the camera is 

pointing away from the push arm of the cube solving mechanism and the image of the cube fills the frame. Using a 320 x 240 resolution works best for 

this.

 Note: You may have to modify the CustomCube sketch to suit your particular robot. Check for commented code in the 'Physical Movement Functions' 

section of the code. If the turntable or push arm action isn't what you would like it to be, make adjustments to the values and re-flash the board. The 

code has been optimized for a Kitables.co cube solver robot.

 You can test the orientation of the camera and the accuracy of the color recognition by connecting the camera in the CubeScan program by ticking the 

'Test Colors' check box and then clicking on the Start button. Good lighting is important for color recognition. If the color recognition algorithm is not 

accurate, try adjusting lighting so that the top of the cube is evenly illuminated. You can also try adjusting the Scan Size from the 'Settings' drop down 

menu which will alter the sampling size of each cublet.
 
 Once you are satisfied with the color recognition, connect the program to the Arduino board by selecting the appropriate Com port from the drop down 

on the left side of the main program window.
The robot mechanism can be manually moved by using the Position and Flip buttons on the right side of the window.

 To start the solving process, orient the cube so that the "Blue" face is pointing upwards and the "Yellow" face is pointed towards the push arm of the 

mechanism. Click the 'Start' button and the program will begin to take images of each side of the cube and then proceed to solve the puzzle.


The CubeScan project code is in the 'CubeScan' folder. 
The Arduino sketch is in the 'CustomCube' folder.
The VB.NET project and source code is in the 'Project' folder.
The CubeScan program can be found in the 'Program' folder.
