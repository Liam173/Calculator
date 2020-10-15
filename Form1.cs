using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1._0__Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbScreen.Clear();
            tbScreen.Enabled = false;
            Disable();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            tbScreen.Clear();

            butDelete.Enabled = true;
            butZero.Enabled = true;
            butOne.Enabled = true;
            butTwo.Enabled = true;
            butThree.Enabled = true;
            butFour.Enabled = true;
            butFive.Enabled = true;
            butSix.Enabled = true;
            butSeven.Enabled = true;
            butEight.Enabled = true;
            butNine.Enabled = true;
            butPlus.Enabled = true;
            butSubtract.Enabled = true;
            butMultiply.Enabled = true;
            butDivide.Enabled = true;
            butPoint.Enabled = true;
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "7";
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "8";
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "9";
        }

        private void butFour_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "4";
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "5";
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "6";
        }

        private void butOne_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "1";
        }

        private void butTwo_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "2";
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "3";
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            tbScreen.Text += "0";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            tbScreen.Text += " + ";
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            tbScreen.Text += " x ";
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int screenLength = tbScreen.TextLength;
            string input = tbScreen.Text;
            //char seperate = 
            char[] seperate = input.ToCharArray();
            tbScreen.Clear();
            for (int i = 0; i < screenLength - 1; i++)
            {
                tbScreen.Text += seperate[i];
            }

            //Array.Reverse(seperate);
            string output = String.Concat(seperate);//Concatenates the chars into a String by combining them
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            tbScreen.Text += " ÷ ";
        }

        private void butSubtract_Click(object sender, EventArgs e)
        {
            tbScreen.Text += " - ";
        }

        private void butPoint_Click(object sender, EventArgs e)
        {
            tbScreen.Text += ".";
        }

        private void Enable()
        {
            butOn.Enabled = false;
            butOne.Enabled = true;
            butTwo.Enabled = true;
            butThree.Enabled = true;
            butFour.Enabled = true;
            butFive.Enabled = true;
            butSix.Enabled = true;
            butSeven.Enabled = true;
            butEight.Enabled = true;
            butNine.Enabled = true;
            butZero.Enabled = true;
            butOff.Enabled = true;
            butPoint.Enabled = true;
            butEqual.Enabled = true;
            butPlus.Enabled = true;
            butSubtract.Enabled = true;
            butMultiply.Enabled = true;
            butDivide.Enabled = true;
            butDelete.Enabled = true;
            butClear.Enabled = true;

        }

        private void Disable()
        {
            butOn.Enabled = true;
            butOne.Enabled = false;
            butTwo.Enabled = false;
            butThree.Enabled = false;
            butFour.Enabled = false;
            butFive.Enabled = false;
            butSix.Enabled = false;
            butSeven.Enabled = false;
            butEight.Enabled = false;
            butNine.Enabled = false;
            butZero.Enabled = false;
            butOff.Enabled = false;
            butPoint.Enabled = false;
            butEqual.Enabled = false;
            butPlus.Enabled = false;
            butSubtract.Enabled = false;
            butMultiply.Enabled = false;
            butDivide.Enabled = false;
            butDelete.Enabled = false;
            butClear.Enabled = false;
        }

        private void butOn_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void butOff_Click(object sender, EventArgs e)
        {
            Disable();
            tbScreen.Clear();
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            butDelete.Enabled = false;
            butZero.Enabled = false;
            butOne.Enabled = false;
            butTwo.Enabled = false;
            butThree.Enabled = false;
            butFour.Enabled = false;
            butFive.Enabled = false;
            butSix.Enabled = false;
            butSeven.Enabled = false;
            butEight.Enabled = false;
            butNine.Enabled = false;
            butPlus.Enabled = false;
            butSubtract.Enabled = false;
            butMultiply.Enabled = false;
            butDivide.Enabled = false;
            butPoint.Enabled = false;

            string screen = tbScreen.Text;
            string[] split = screen.Split(' ');
            int output = 0;

            if (split[1] == "+")
            {
                output = int.Parse(split[0]) + int.Parse(split[2]);
            }else if (split[1] == "-")
            {
                output = int.Parse(split[0]) - int.Parse(split[2]);
            }
            else if (split[1] == "x")
            {
                output = int.Parse(split[0]) * int.Parse(split[2]);
            }
            else
            {
                output = int.Parse(split[0]) / int.Parse(split[2]);
            }

            //tbScreen.Text = split[0] + " " + split[1] + " " + split[2] + " = " + output;
            tbScreen.Text += " = " + output;
            
        }
    }
}
