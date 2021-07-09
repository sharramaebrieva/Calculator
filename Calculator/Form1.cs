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
        string value = "";
        string operation = "";
        bool operator_pressed = false;
        string negasign = "";
        string dot = "";
        bool equal_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;

            if (textBoxDisplay.Text == "")
            {
                textBoxResult.Text += numbers.Text;
                value = textBoxResult.Text;
            }
            if (textBoxDisplay.Text != "")
            {
                textBoxResult.Text += numbers.Text;
            } 
        }

        private void Button_ClickClearAll(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            textBoxResult.Clear();
        }

        private void ButtonClick_Equal(object sender, EventArgs e)
        {
            equal_pressed = true;
            if (operation == "+")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(value) + float.Parse(textBoxResult.Text)).ToString();
            }
            
            if (operation == "-")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(value) - float.Parse(textBoxResult.Text)).ToString();
            }

            if (operation == "x")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(value) * float.Parse(textBoxResult.Text)).ToString();
            }

            if (operation == "/")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(value) / float.Parse(textBoxResult.Text)).ToString();
            }
        }

        private void ButtonClick_Delete(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDisplay.Text == "")
                {
                    textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                    value = textBoxResult.Text;
                }
                else
                {
                    textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                }
            }
            catch { }
        }

        private void ButtonClick_Add(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button add = (Button)sender;
            operation = "+";
            
            if(equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + add.Text + " ";
                value = textBoxResult.Text;
                textBoxResult.Text = "";
            }
            else
            {
                textBoxDisplay.Text += textBoxResult.Text + " " + add.Text + " ";
                textBoxResult.Text = "";
            }
            
        }

        private void ButtonClick_Subtract(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button subtract = (Button)sender;
            operation = "-";

            if (equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + subtract.Text + " ";
                value = textBoxResult.Text;
                textBoxResult.Text = "";
            }
            else
            {
                textBoxDisplay.Text += textBoxResult.Text + " " + subtract.Text + " ";
                textBoxResult.Text = "";
            }
        }

        private void ButtonClick_Multiply(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button multiply = (Button)sender;
            operation = "x";

            if (equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + multiply.Text + " ";
                value = textBoxResult.Text;
                textBoxResult.Text = "";
            }
            else
            {
                textBoxDisplay.Text += textBoxResult.Text + " " + multiply.Text + " ";
                textBoxResult.Text = "";
            }
        }

        private void ButtonClick_Divide(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button divide = (Button)sender;
            operation = "/";

            if (equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + divide.Text + " ";
                value = textBoxResult.Text;
                textBoxResult.Text = "";
            }
            else
            {
                textBoxDisplay.Text += textBoxResult.Text + " " + divide.Text + " ";
                textBoxResult.Text = "";
            }
        }

        private void ButtonClick_Sign(object sender, EventArgs e)
        {
            negasign = "-";
            
            if (textBoxResult.Text.Contains(negasign))
            {
                textBoxResult.Text = textBoxResult.Text.Replace(negasign, "");
            }
            else
            {
                textBoxResult.Text = negasign + textBoxResult.Text;
            }
        }

        private void ButtonClick_Percent(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                textBoxResult.Text = "";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text.Replace(textBoxResult.Text, (float.Parse(textBoxResult.Text)
                    / 100).ToString());
            }
        }
    }
}
