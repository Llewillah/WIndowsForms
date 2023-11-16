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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void multiplyButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void operatorLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(num1TextBox.Text);
            int num2 = Convert.ToInt32(num2TextBox.Text);
            int result = 1;

            if (addButton.Checked == true)
            {
                result = num1 + num2;
            }
            else if (subButton.Checked == true)
            {
                result = num1 - num2;
            }
            else if (multiplyButton.Checked == true) 
            { 
                result = num1* num2;
            }else if (powerButton.Checked == true) 
            {
                for (int i = 0; i < num2; i++) 
                {
                    result = result * num1;
                }
            }

            resultTextBox.Text = Convert.ToString(result);
        }
    }
}
