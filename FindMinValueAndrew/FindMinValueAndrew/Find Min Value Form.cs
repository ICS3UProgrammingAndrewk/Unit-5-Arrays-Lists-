/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMinValueAndrew
{
    public partial class frmFindMinValue : Form
    {
        public frmFindMinValue()
        {
            InitializeComponent();
        }
        private int GetMinValue(int[] trapArrayOfIntergers)
        {
            // declare vers
            int trapMinVal = 500;
            int counter;

            // for loop
            for(counter = 0; counter < 10; counter++)
            { 
                // if array value is greater then max val set it to array val
                if (trapMinVal > trapArrayOfIntergers[counter])
                {
                    trapMinVal = trapArrayOfIntergers[counter];
                }

            }
            // return max val
            return trapMinVal;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local var and const
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUM = 500;
            int[] arrayOfIntergers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;

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
            minValue = GetMinValue(arrayOfIntergers);

            // display what value is greatest with lable
            this.lblAnswer.Text = " The Min value is " + minValue;
        }
    }
}
