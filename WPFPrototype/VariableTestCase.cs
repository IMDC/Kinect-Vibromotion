using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Windows.Media;

namespace WPFPrototype
{
    class VariableTestCase
    {
        public int initialFrequency;
        public int initialSignalStrength;
        public int initialRHC;
        public int finalFrequency;
        public int finalSignalStrength;
        public int finalRHC;
        public double rateOfChangeFrequency;
        public double rateOfChangeRHC;
        public double rateOfChangeSignalStrength;
        public int timedelay;
        public int timespan;
        const int vtcTickTime = 100;
        /*rate of change: this variable controls how quickly the initial frequency is translated into the final frequency
         * timedelay = this is the delay in milliseconds before the stimulus starts.
         * timespan = total time which is taken for the stimulus to change. time is in milliseconds
         * rate of change is calculated in unit/(millisecond * 100), so unit/(tenth of a second)
         */

        public VariableTestCase(int initFreq, int initSigStrength, int initRHC, int finFreq, int finSignalStrength, int finRHC, int tspan, int tdelay, double ROCFreq, double ROC_RHC, double ROCStrength)
        {
            initialFrequency = initFreq;
            initialSignalStrength = initSigStrength;
            initialRHC = initRHC;

            finalRHC = finRHC;
            finalFrequency = finFreq;
            finalSignalStrength = finSignalStrength;

            timespan = tspan;
            timedelay = tdelay;

            rateOfChangeFrequency = ROCFreq;
            rateOfChangeRHC = ROC_RHC;
            rateOfChangeSignalStrength = ROCStrength;
        }

        static int calculateRightHandCoordinate(int positionOfChannel, int rightHandRange, int rightHandMinimumCoordinate)
        {
            double channelSize = 12.5; //in percentage because 100/8 = 12.5
            double a = (channelSize * (positionOfChannel - 1));
            double b = (channelSize * (positionOfChannel));
            double c = (a + ((b - a) / 2)) / 100;
            int rhc = (int)((c * rightHandRange) + rightHandMinimumCoordinate);
            System.Console.Out.WriteLine("RHC = " + rhc);
            return rhc;
        }

        public static VariableTestCase returnVariableTestCase(int id, int rightHandRange, int rightHandMinimumCoordinate, int c)
        {
            VariableTestCase vtc;
            /* the indexes will include 20,21,22,23,24
             * the test cases 20-22 will be 2-dimensional
             * 23 and 24 will be 3 dimensional
             */

            //ids from -3,-2,-1, and 0 will be practice cases.

            if (id == -3)
            {

                if (c == 1)
                {
                    System.Windows.MessageBox.Show("This is a practice example, please take your time.");
                }

                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 250;
                int finFreq = 250;
                int initStrength = 50;
                int finStrength = 50;
                int initChPos = 1;
                int finChPos = 1;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * ((double)(finFreq - initFreq) / timespan);
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == -2)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 50;
                int finFreq = 50;
                int initStrength = 80;
                int finStrength = 80;
                int initChPos = 1;
                int finChPos = 1;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * ((double)(finFreq - initFreq) / timespan);
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == -1)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 250;
                int finFreq = 250;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 3;
                int finChPos = 3;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * ((double)(finFreq - initFreq) / timespan);
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 0)
            {
                if (c == 1)
                    System.Windows.MessageBox.Show("The following test cases are part of the study. Good luck.");

                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 100;
                int finFreq = 100;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 1;
                int finChPos = 1;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * ((double)(finFreq - initFreq) / timespan);
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 1)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 250;
                int finFreq = 250;
                int initStrength = 60;
                int finStrength = 60;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * ((double)(finFreq - initFreq) / timespan);
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 2)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 250;
                int finFreq = 250;
                int initStrength = 80;
                int finStrength = 80;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * ((double)(finStrength - initStrength) / timespan);

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 3)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 250;
                int finFreq = 250;
                int initStrength = 100;
                int finStrength = 100;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 4)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 40;
                int finFreq = 40;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 5)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 78;
                int finFreq = 78;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 6)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 154;
                int finFreq = 154;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 7)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 300;
                int finFreq = 300;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 8)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 110;
                int finFreq = 110;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 2;
                int finChPos = 2;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 9)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 110;
                int finFreq = 110;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 10)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 110;
                int finFreq = 110;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 6;
                int finChPos = 6;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 11)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 110;
                int finFreq = 110;
                int initStrength = 75;
                int finStrength = 75;
                int initChPos = 8;
                int finChPos = 8;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 12)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                if(c ==1)
                    System.Windows.MessageBox.Show("The following test cases will be dynamic test cases.");

                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 110;
                int finFreq = 215;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 3;
                int finChPos = 3;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 13)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 154;
                int finFreq = 154;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 2;
                int finChPos = 5;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 14)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 215;
                int finFreq = 215;
                int initStrength = 90;
                int finStrength = 30;
                int initChPos = 3;
                int finChPos = 3;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 15)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 215;
                int finFreq = 40;
                int initStrength = 95;
                int finStrength = 65;
                int initChPos = 4;
                int finChPos = 4;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;
            }
            if (id == 16)
            {
                /* Case variables:
                 * fixed signal strength
                 * fixed frequency
                 * fixed channel position
                 */
                int timespan = 3000;
                int timedelay = 1000;
                int initFreq = 56;
                int finFreq = 154;
                int initStrength = 90;
                int finStrength = 90;
                int initChPos = 7;
                int finChPos = 3;
                int initRHC = calculateRightHandCoordinate(initChPos, rightHandRange, rightHandMinimumCoordinate);
                int finRHC = calculateRightHandCoordinate(finChPos, rightHandRange, rightHandMinimumCoordinate);
                //rate of change
                double rocf = (vtcTickTime) * (double)(finFreq - initFreq) / timespan;
                double rocr = (vtcTickTime) * (double)(finRHC - initRHC) / timespan;
                double rocs = (vtcTickTime) * (double)(finStrength - initStrength) / timespan;

                vtc = new VariableTestCase(initFreq, initStrength, initRHC, finFreq, finStrength, finRHC, timespan, timedelay, rocf, rocr, rocs);
                return vtc;



            }
            if (id == 17)
            {
                if (c == 1)
                {
                    System.Windows.MessageBox.Show(" Time for a break! The first part of the study is now completed.");
                    System.Windows.MessageBox.Show("This is the free-play section of the study. Have fun!");
                }

                vtc = new VariableTestCase(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                return vtc;
            }

            //If there is a false call, a Zero-parameter test case will be created and returned
            System.Console.WriteLine("index: " + id + " is not valid.");
            vtc = new VariableTestCase (0,0,0,0,0,0,0,0,0,0,0);
            return vtc;
        }

    }
}
