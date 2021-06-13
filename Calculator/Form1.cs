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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

     
        private void Button_Click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;
            textBoxDisplay.Text = textBoxDisplay.Text + numbers.Text;
        }

        private void Button_ClickSign(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                textBoxDisplay.Text = "-";
            }
        }
    }
}
