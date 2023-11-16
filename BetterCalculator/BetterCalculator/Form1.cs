using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateTextBox_Click(object sender, EventArgs e)
        {
            string[] input = equationTextBox.Text.Split(' ');
            int num1 = Convert.ToInt32(input[0]);
            int num2 = Convert.ToInt32(input[2]);
            char operation = Convert.ToChar(input[1]);
            int result = 0;

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*') 
            {
                result = num1 * num2;
            }else if (operation == '/') 
            { 
                result = (num1 / num2);
            }

            resultTextBox.Text = Convert.ToString(result);
        }
    }
}
