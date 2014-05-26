To run the program you will need three things: 
The source code for the Visual Studio 2010 or Visual Studio Express 2012 for Desktop, Vibro-Motion Program, 
Kinect SDK (version SDK beta 2 only) 
and Max MSP (runtime version 5 or 6 is enough). 



1. In order to install and run the program, you will need: Visual Studio 2010 (or Visual Studio Express 2012 for Desktop). 
There is a free version of Visual Studio 2012 available here http://www.microsoft.com/en-ca/download/details.aspx?id=34673 
If you want to install Visual Studio 2010, use this guide by Ryerson http://www.ryerson.ca/ccs/software/downloads/microsoft/Dreamspark.pdf



2. You will also need Kinect SDK beta 2. See this link: 
http://www.microsoft.com/en-us/kinectforwindowsdev/Downloads.aspx



3. The latest working copy of the software is located here: https://www.dropbox.com/s/l0ej9km1sqei8g3/Vibro-Motion%20Program.zip 
Let me know if that doesn't work, I can look for other versions on my hard-drive.



4. Download Max Msp 32 bit (very important to use 32 bit only) : http://cycling74.com/downloads/



Install them in the order I mentioned. You should be able to load the project in Visual Studio and build it. 
When you run the program, you will also need to run the runtime file port6601.maxpat and select the Presonus Firepod as the audio output device. 


The instructions to use the program including the calibration stage are in Section 3.2 of the thesis. 




NOTE:  You must use Kinect SDK beta 2 to make this work!
You need to change the paths to the .png files inside the project folder and make sure to double escape the directory names. eg. c:\users => c:\\users

