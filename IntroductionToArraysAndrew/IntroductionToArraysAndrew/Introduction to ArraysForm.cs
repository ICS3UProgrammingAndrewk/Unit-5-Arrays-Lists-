/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionToArraysAndrew
{
    public partial class frmIntroductiontoArrays : Form
    {
        // declare global vers and const
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];
        public frmIntroductiontoArrays()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare locla vers
            int randomNum;
            int counter;
            Random randomNumberGenerator = new Random();

            // clear list box
            this.IstArray.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random num beween 1 and 10
                randomNum = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1 );

                // assign the random num to the cell posistion in the array
                arrayOfNumbers[counter] = randomNum;

                // add number to the list box
                this.IstArray.Items.Add(randomNum);

                // refresh the from to display the new item
                this.Refresh();

            }

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // declare local vars
            double average = 0;
            double sum = 0;
            int counter;

            // calculate the sum pf all array values
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }
            // calculate the averge of the value in the array
            average = sum / arrayOfNumbers.Length;

            // display the average in the label
            this.lblAnswer.Text = " Average: " + average;

        }
    }
}
