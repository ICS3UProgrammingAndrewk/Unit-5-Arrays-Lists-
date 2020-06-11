/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMaxValueAndrew
{
    public partial class frmFindMaxValue : Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
        }

        // get max value function
        private int GetMaxValue(int[] trapArrayOfIntegers)
        {
            // declare vers
            int trapMaxVal = -1;
            int counter;

            // for loop
            for (counter = 0; counter < 10; counter++)
            {
                // if array value is greater than max value set it to array value
                if (trapMaxVal < trapArrayOfIntegers[ counter])
                {
                    trapMaxVal = trapArrayOfIntegers[counter];
                }
            }
            // return max val
            return trapMaxVal;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local var and const
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUM = 500;
            int[] arrayOfIntergers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;

            // generate a new random num
            Random randomNumberGenerator = new Random();

            //radom number
            this.IstArray.Items.Clear();

            // for loop
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random num
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUM + 1);

                // assign the random num between
                arrayOfIntergers[counter] = randomNumber;

                // add array value to list box
                this.IstArray.Items.Add(randomNumber);

                this.Refresh();
            }
            // Calling on function
            maxValue = GetMaxValue(arrayOfIntergers);

            // display what value is greatest with lable
            this.lblAnswer.Text = " The Max value is " + maxValue;
        }
    }
}
