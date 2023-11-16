using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colourCheckBox.Checked == true)
            {
                messageTextBox.ForeColor = Color.Red;
                outputTextBox.ForeColor = Color.Red;
                outputTextBox.Text = messageTextBox.Text;
            }
            else
            {
                messageTextBox.ForeColor = Color.Black;
            }
        }
    }
}
