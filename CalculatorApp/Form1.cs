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
    public partial class Form1 : Form
    {
        void ShortOper(char op)
        {
            operand1 = input;
            operation = op;
            label1.Text += op;
            input = string.Empty;

        }
        void clear()
        {
            label1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        void DoNum(object sender, EventArgs e)
        {
            Button b = sender as Button;
            input += b.Text;
            label1.Text += b.Text;
        }
        void DoOper(object sender, EventArgs e)
        {
            Button b = sender as Button;
            ShortOper(Convert.ToChar(b.Text));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                label1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                label1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                label1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    label1.Text = result.ToString();
                }
                else
                {
                    label1.Text = "DIV/Zero!";
                }
            }
        }

    }
}
