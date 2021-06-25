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

            btn_add.Enabled = true;
            btn_subtract.Enabled = true;
            btn_multiply.Enabled = true;
            btn_divide.Enabled = true;
        }

        private void Button_ClickSign(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                textBoxDisplay.Text = "-";
            }
        }

        private void Button_ClickClearAll(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void Button_ClickAdd(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                textBoxDisplay.Text = textBoxDisplay.Text;
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + " + ";
            }

            
            
        }

        private void ButtonClick_Equal(object sender, EventArgs e)
        {

        }

        

        private void ButtonClick_Operator(object sender, EventArgs e)
        {
            Button operators = (Button)sender;

            if (textBoxDisplay.Text == "")
            {
                textBoxDisplay.Text = textBoxDisplay.Text;
            }
            else
            { 
                textBoxDisplay.Text = textBoxDisplay.Text + " " + operators.Text + " ";
                btn_add.Enabled = false;
                btn_subtract.Enabled = false;
                btn_multiply.Enabled = false;
                btn_divide.Enabled = false;
            }
            

        }

        private void ButtonClick_Delete(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
