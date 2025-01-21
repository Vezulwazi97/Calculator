using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation;
        int num1, num2, result;
       

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtOutput.Text);

            txtOutput.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtOutput.Text);

            txtOutput.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtOutput.Text);

            txtOutput.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(txtOutput.Text);

            txtOutput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtOutput.Text);

            if (operation == "+")
                    result = num1 + num2;
            if (operation == "-")
                result = num1 - num2;
            if (operation == "*")
                result = num1 * num2;
            if (operation == "/")
                result = num1 / num2;

            txtOutput.Text = result.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            result = 0;
            num2 = 0;
            num1 = 0;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "0";
             
        }

    }
}
