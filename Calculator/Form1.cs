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
        MyClassCalc NewCalc = new MyClassCalc();

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
                NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Equal_pressed = true;
            
            if (NewCalc.Operation == "+")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(NewCalc.Value) + float.Parse(textBoxResult.Text)).ToString();
            }
            
            if (NewCalc.Operation == "-")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(NewCalc.Value) - float.Parse(textBoxResult.Text)).ToString();
            }

            if (NewCalc.Operation == "x")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(NewCalc.Value) * float.Parse(textBoxResult.Text)).ToString();
            }

            if (NewCalc.Operation == "/")
            {
                textBoxDisplay.Text += textBoxResult.Text + " =";
                textBoxResult.Text = (float.Parse(NewCalc.Value) / float.Parse(textBoxResult.Text)).ToString();
            }
        }

        private void ButtonClick_Delete(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDisplay.Text == "")
                {
                    textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                    NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Operator_pressed = true;
            Button add = (Button)sender;
            NewCalc.Operation = "+";

            if (NewCalc.Equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + add.Text + " ";
                NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Operator_pressed = true;
            Button subtract = (Button)sender;
            NewCalc.Operation = "-";

            if (NewCalc.Equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + subtract.Text + " ";
                NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Operator_pressed = true;
            Button multiply = (Button)sender;
            NewCalc.Operation = "x";

            if (NewCalc.Equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + multiply.Text + " ";
                NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Operator_pressed = true;
            Button divide = (Button)sender;
            NewCalc.Operation = "/";

            if (NewCalc.Equal_pressed == true)
            {
                textBoxDisplay.Text = textBoxResult.Text + " " + divide.Text + " ";
                NewCalc.Value = textBoxResult.Text;
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
            NewCalc.Negasign = "-";
            
            if (textBoxResult.Text.Contains(NewCalc.Negasign))
            {
                textBoxResult.Text = textBoxResult.Text.Replace(NewCalc.Negasign, "");
            }
            else
            {
                textBoxResult.Text = NewCalc.Negasign + textBoxResult.Text;
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
