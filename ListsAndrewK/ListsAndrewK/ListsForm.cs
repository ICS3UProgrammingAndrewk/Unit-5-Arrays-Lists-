/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsAndrewK
{
    public partial class frmlists : Form
    {
        // declare global variable
        List<int> listOfMarks = new List<int>();

        public frmlists()
        {
            InitializeComponent();
        }

        private void frmlists_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userMark = -1;

            try
            {
                // convert the mark in the textbox to an int
                userMark = int.Parse(txtMark.Text);

                // 
                if ( (userMark >= 0 ) && (userMark <= 100) )
                {
                    // add the mark to the listbox
                    lstMark.Items.Add(userMark);

                    // add the mark to thr list of mark
                    listOfMarks.Add(userMark);
                }
                else
                {
                    //output a message to the user
                    MessageBox.Show(" Please enter a mark between O and 100.");
                }

            }
            catch (Exception parseError)
            {
                // output the parse error to the console
                Console.WriteLine(parseError.Message);

                //output a message to the user
                MessageBox.Show(" Please enter an integer between O and 100.");
            }

            // clear the textBox
            this.txtMark.Text = "";
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            // declare local varibles
            int sum = 0;
            double average = 0;

            // calculate the average of all the marks in the list
            for (int counter = 0; counter < listOfMarks.Count(); counter++)
            {
                sum = sum + listOfMarks[ counter];
            }

            // calculate the averge
            average = sum / listOfMarks.Count();

            //display the averge in the lbl
            lblAverage.Text = " The average is:" + Math.Round(average);

        }
    }
}
