using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;


namespace WPFPrototype
{



    class TestCases
    {
        //THIS CLASS WILL HAVE ALL THE TEST CASES WITHIN
        //BY CALLING THE CASE RETRIEVE FUNCTION, WE CAN GET THE CASE DETAILS.


        //there will be 15 1-D Tests
        //8 spacial 
        //3 for strength. low, medium, maximum
        //4 for frequencies?  10hz, 50hz, 90,hz, 130hz

        //everything is linear when testing for one dimension


        //but timers need to be used when testing for multiple dimensions.
        //4 cases. 
        //3 of them will have one dimension constant, the other two will vary. 

        //dispatcher timer will allow us to create a timer that can operate with milliseconds. a constant rate of change can be compiled through code. 



        //generate test cases function will generate all the test case right hand left hand positions based on the calibration results. 
        //it will perform freq-joint location reverse calculation. 


        public static int[] returnTestParams_1D(int id, int rightHandRange, int rightHandMinimumCoordinate){
            int rhc = 0;
            int frequency = 0;
            int positionOfChannel = 0; //it will always use the mid point of a channel.
            int signalStrength = 0; //always in %
            const double channelSize = 12.5; //in %
            int[] testParams = new int[3];


            //TEST 1
            if (id == 1)
            {
                signalStrength = 25;
                positionOfChannel = 4;
                frequency = 250;
                //my hand written notes on january 12/2012 have explanations
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);

            }
            //TEST 2
            if (id == 2)
            {
                signalStrength = 60;
                positionOfChannel = 4;
                frequency = 250;
                //my hand written notes on january 12/2012 have explanations
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 3
            if (id == 3)
            {
                signalStrength = 95;
                positionOfChannel = 4;
                frequency = 250;
                //my hand written notes on january 12/2012 have explanations
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }


            //Tests 4 through 11 are going to be for frequency checking. 
            //these frequencies are to be tested using the guideline in one of the papers that ican't find.
            //so untili find them i will just use equal frequency steps.
            //the position is channel 4
            // the amplitude is 90%


            //TEST 4
            if (id == 4)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 5
            if (id == 5)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 6
            if (id == 6)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 7
            if (id == 7)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 8
            if (id == 8)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 9
            if (id == 9)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 10
            if (id == 10)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }
            //TEST 11
            if (id == 11)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //Tests 12 through 19 will test for the spatial encoding
            //TEST 12
            if (id == 12)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 1;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 13
            if (id == 13)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 2;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 14
            if (id == 14)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 3;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 15
            if (id == 15)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 4;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 16
            if (id == 16)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 5;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 17
            if (id == 17)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 6;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 18
            if (id == 18)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 7;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            //TEST 19
            if (id == 19)
            {
                frequency = 100;
                signalStrength = 90;
                positionOfChannel = 8;
                double a = (channelSize * (positionOfChannel - 1));
                double b = (channelSize * (positionOfChannel));
                double c = (a + ((b - a) / 2))/100;
                rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            }

            testParams[0] = frequency;
            testParams[1] = rhc;
            testParams[2] = signalStrength;
            return testParams;
        }

        static int[] returnTestParams_2D(int id, int rightHandRange, int rightHandMinimumCoordinate)
        {
            int[] testParams = new int[4];

            return testParams;
        }
    }

}

