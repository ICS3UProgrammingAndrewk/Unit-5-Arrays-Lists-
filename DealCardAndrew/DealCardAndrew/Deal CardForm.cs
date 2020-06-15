/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Deal Card
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

namespace DealCardAndrew
{
    public partial class frmDealCard : Form
    {
        // declare global variables
        Random randomGenerator = new Random();
        const int MAX_CARDS = 52;

        public frmDealCard()
        {
            InitializeComponent();
        }

        private void ChangeCard(ref PictureBox aPictureBox, int aNumber)
        {
            switch (aNumber)
            {
                case 1:
                    aPictureBox.Image = Properties.Resources._2C;
                    break;
                case 2:
                    aPictureBox.Image = Properties.Resources._2D;
                    break;
                case 3:
                    aPictureBox.Image = Properties.Resources._2H;
                    break;
                case 4:
                    aPictureBox.Image = Properties.Resources._2S;
                    break;
                case 5:
                    aPictureBox.Image = Properties.Resources._3C;
                    break;
                case 6:
                    aPictureBox.Image = Properties.Resources._3D;
                    break;
                case 7:
                    aPictureBox.Image = Properties.Resources._3H;
                    break;
                case 8:
                    aPictureBox.Image = Properties.Resources._3S;
                    break;
                case 9:
                    aPictureBox.Image = Properties.Resources._4C;
                    break;
                case 10:
                    aPictureBox.Image = Properties.Resources._4D;
                    break;
                case 11:
                    aPictureBox.Image = Properties.Resources._4H;
                    break;
                case 12:
                    aPictureBox.Image = Properties.Resources._4S;
                    break;
                case 13:
                    aPictureBox.Image = Properties.Resources._5C;
                    break;
                case 14:
                    aPictureBox.Image = Properties.Resources._5D;
                    break;
                case 15:
                    aPictureBox.Image = Properties.Resources._5H;
                    break;
                case 16:
                    aPictureBox.Image = Properties.Resources._5S;
                    break;
                case 17:
                    aPictureBox.Image = Properties.Resources._6C;
                    break;
                case 18:
                    aPictureBox.Image = Properties.Resources._6D;
                    break;
                case 19:
                    aPictureBox.Image = Properties.Resources._6H;
                    break;
                case 20:
                    aPictureBox.Image = Properties.Resources._6S;
                    break;
                case 21:
                    aPictureBox.Image = Properties.Resources._7C;
                    break;
                case 22:
                    aPictureBox.Image = Properties.Resources._7D;
                    break;
                case 23:
                    aPictureBox.Image = Properties.Resources._7S;
                    break;
                case 24:
                    aPictureBox.Image = Properties.Resources._8C;
                    break;
                case 25:
                    aPictureBox.Image = Properties.Resources._8D;
                    break;
                case 26:
                    aPictureBox.Image = Properties.Resources._8H;
                    break;
                case 27:
                    aPictureBox.Image = Properties.Resources._8S;
                    break;
                case 28:
                    aPictureBox.Image = Properties.Resources._9C;
                    break;
                case 29:
                    aPictureBox.Image = Properties.Resources._9D;
                    break;
                case 30:
                    aPictureBox.Image = Properties.Resources._9H;
                    break;
                case 31:
                    aPictureBox.Image = Properties.Resources._10C;
                    break;
                case 32:
                    aPictureBox.Image = Properties.Resources._10D;
                    break;
                case 33:
                    aPictureBox.Image = Properties.Resources._10H;
                    break;
                case 34:
                    aPictureBox.Image = Properties.Resources._10S;
                    break;
                case 35:
                    aPictureBox.Image = Properties.Resources.AC;
                    break;
                case 36:
                    aPictureBox.Image = Properties.Resources.AD;
                    break;
                case 37:
                    aPictureBox.Image = Properties.Resources.AH;
                    break;
                case 38:
                    aPictureBox.Image = Properties.Resources.AS;
                    break;
                case 39:
                    aPictureBox.Image = Properties.Resources.JC;
                    break;
                case 40:
                    aPictureBox.Image = Properties.Resources.JD;
                    break;
                case 41:
                    aPictureBox.Image = Properties.Resources.JH;
                    break;
                case 42:
                    aPictureBox.Image = Properties.Resources.JS;
                    break;
                case 43:
                    aPictureBox.Image = Properties.Resources.KS;
                    break;
                case 44:
                    aPictureBox.Image = Properties.Resources.KD;
                    break;
                case 45:
                    aPictureBox.Image = Properties.Resources.KH;
                    break;
                case 46:
                    aPictureBox.Image = Properties.Resources.KS;
                    break;
                case 47:
                    aPictureBox.Image = Properties.Resources.QC;
                    break;
                case 48:
                    aPictureBox.Image = Properties.Resources.QD;
                    break;
                case 49:
                    aPictureBox.Image = Properties.Resources.QH;
                    break;
                case 50:
                    aPictureBox.Image = Properties.Resources.QS;
                    break;
                default:
                    aPictureBox.Image = Properties.Resources.Front;
                    break;
            }

        }

        private void picCard1_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard1, randomNumber);

            // call all 52 cards
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard2, randomNumber);

            // call all 52 cards
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard3, randomNumber);

            // call all 52 cards
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard4, randomNumber);

            // call all 52 cards
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard5, randomNumber);

            // call all 52 cards
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }

        private void piccard6_Click(object sender, EventArgs e)
        {
            // deck local variable
            int randomNumber = randomGenerator.Next(1, MAX_CARDS + 1);

            // call the function to chage the card
            ChangeCard(ref this.picCard6, randomNumber);

            // call all 52 cards 
            if (randomNumber == 52)
            {
                MessageBox.Show(" There are no more cards");
            }
        }
    }
}
