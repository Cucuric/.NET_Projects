using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class formCalculator : Form
    {
        public formCalculator()
        {
            InitializeComponent();
        }

        String symbol;
        double firstNumber;
        double secondNumber;
        double result;

        private void btnNumOne_Click(object sender, EventArgs e)
        {
            tbResult.Text += 1;
        }

        private void btnNumTwo_Click(object sender, EventArgs e)
        {
            tbResult.Text += 2;
        }

        private void btnNumThree_Click(object sender, EventArgs e)
        {
            tbResult.Text += 3;
        }

        private void btnNumFour_Click(object sender, EventArgs e)
        {
            tbResult.Text += 4;
        }

        private void btnNumFive_Click(object sender, EventArgs e)
        {
            tbResult.Text += 5;
        }

        private void btnNumSix_Click(object sender, EventArgs e)
        {
            tbResult.Text += 6;
        }

        private void btnNumSeven_Click(object sender, EventArgs e)
        {
            tbResult.Text += 7;
        }

        private void btnNumEight_Click(object sender, EventArgs e)
        {
            tbResult.Text += 8;
        }

        private void btnNumNine_Click(object sender, EventArgs e)
        {
            tbResult.Text += 9;
        }

        private void btnNumNull_Click(object sender, EventArgs e)
        {
            tbResult.Text += 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            symbol = "+";

            firstNumber = double.Parse(tbResult.Text);

            tbResult.Text = "";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            symbol = "-";

            firstNumber = double.Parse(tbResult.Text);

            tbResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            symbol = "*";

            firstNumber = double.Parse(tbResult.Text);

            tbResult.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            symbol = "/";

            firstNumber = double.Parse(tbResult.Text);

            tbResult.Text = "";
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            symbol = "%";

            firstNumber = double.Parse(tbResult.Text);

            tbResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(tbResult.Text);
             
            if (symbol.Equals("+"))
            {
                result = firstNumber + secondNumber;
            } else if (symbol.Equals("-"))
            {
                result = firstNumber - secondNumber;
            } else if (symbol.Equals("*"))
            {
                result = firstNumber * secondNumber;
            } else if (symbol.Equals("/"))
            {
                result = firstNumber / secondNumber;
            } else if (symbol.Equals("%")){
                result = firstNumber % secondNumber;
            } else
            {
                tbResult.Text = "Symbol error!";
            }

            tbResult.Text = result.ToString();
            firstNumber = 0;
            secondNumber = 0;
            symbol = null;
            result = 0;
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(tbResult.Text);
            firstNumber *= firstNumber;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            symbol = null;
            result = 0;
            tbResult.Text = "";
        }
    }
}
