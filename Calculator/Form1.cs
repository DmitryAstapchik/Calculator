using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double? operand1 = null;
        double? operand2 = null;
        char lastOperator = char.MinValue;
        bool enterNew = true; // entering a new number or continuing to enter the current
        bool calculated = true; // true means the equals button was pressed
        double memoryValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSqrt.Text = "\u221a";
            buttonErase.Text = "\u2190";
        }

        private void ButtonDigit_Click(object sender, EventArgs e) // event handler for digit button
        {
            if (enterNew || textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = string.Empty;
            }
            textBoxDisplay.Text += ((Button)sender).Name.Last();
            enterNew = false;
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (enterNew)
            {
                textBoxDisplay.Text = "0,";
            }
            else if (!textBoxDisplay.Text.Contains(','))
            {
                textBoxDisplay.Text += ",";
            }
            enterNew = false;
        }

        private void HandleOperator(object sender, EventArgs e) // event handler for arithmetic operators
        {
            if (!calculated && !enterNew)
            {
                ButtonEquals_Click(sender, e);
            }
            operand1 = double.Parse(textBoxDisplay.Text);
            operand2 = null;
            enterNew = true;
            calculated = false;
            lastOperator = char.Parse(((Button)sender).Text);
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            operand2 = operand2 ?? double.Parse(textBoxDisplay.Text);
            switch (lastOperator)
            {
                case '+':
                    textBoxDisplay.Text = (operand1 += operand2).ToString();
                    break;
                case '-':
                    textBoxDisplay.Text = (operand1 -= operand2).ToString();
                    break;
                case '*':
                    textBoxDisplay.Text = (operand1 *= operand2).ToString();
                    break;
                case '/':
                    textBoxDisplay.Text = (operand1 /= operand2).ToString();
                    break;
            }
            enterNew = true;
            calculated = true;
        }

        private void ButtonErase_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.TextLength - 1);
            if (textBoxDisplay.Text == string.Empty || textBoxDisplay.Text == "-")
            {
                textBoxDisplay.Text = "0";
            }
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            enterNew = true;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            operand1 = null;
            operand2 = null;
            lastOperator = char.MinValue;
            enterNew = true;
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text[0] == '-')
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(0, 1);
            }
            else if (textBoxDisplay.Text != "0")
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Insert(0, "-");
            }
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (1 / double.Parse(textBoxDisplay.Text)).ToString();
            enterNew = true;
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = Math.Sqrt(double.Parse(textBoxDisplay.Text)).ToString();
            enterNew = true;
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = Math.Pow(double.Parse(textBoxDisplay.Text), 2).ToString();
            enterNew = true;
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (operand1 * double.Parse(textBoxDisplay.Text) / 100).ToString();
            enterNew = true;
        }

        private void ButtonMemoryPlus_Click(object sender, EventArgs e)
        {
            memoryValue += double.Parse(textBoxDisplay.Text);
            labelMemory.Visible = memoryValue == 0 ? false : true;
            enterNew = true;
        }

        private void ButtonMemoryMinus_Click(object sender, EventArgs e)
        {
            memoryValue -= double.Parse(textBoxDisplay.Text);
            labelMemory.Visible = memoryValue == 0 ? false : true;
            enterNew = true;
        }

        private void ButtonMemoryRecall_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = memoryValue.ToString();
            enterNew = true;
        }

        private void ButtonMemoryClear_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            labelMemory.Visible = false;
            enterNew = true;
        }
    }
}