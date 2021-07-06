﻿using System;
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
        string value2 = "";
        string operation = "";
        bool operator_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

     
        private void Button_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                Button numbers = (Button)sender;
                textBoxResult.Text += numbers.Text;
                value = textBoxResult.Text;
            }
            else
            {
                Button numbers = (Button)sender;
                textBoxResult.Text += numbers.Text;
                value2 = textBoxResult.Text;
            }

            
        }

        private void Button_ClickClearAll(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            textBoxResult.Clear();
        }

        private void ButtonClick_Equal(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                textBoxDisplay.Text += value2;
                textBoxResult.Text = (float.Parse(value) + float.Parse(textBoxResult.Text)).ToString();
            }
            if (operation == "-")
            {
                textBoxDisplay.Text += value2;
                textBoxResult.Text = (float.Parse(value) - float.Parse(textBoxResult.Text)).ToString();
            }
            if (operation == "x")
            {
                textBoxDisplay.Text += value2;
                textBoxResult.Text = (float.Parse(value) * float.Parse(textBoxResult.Text)).ToString();
            }
            if (operation == "/")
            {
                textBoxDisplay.Text += value2;
                textBoxResult.Text = (float.Parse(value) / float.Parse(textBoxResult.Text)).ToString();
            }
        }

        private void ButtonClick_Delete(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClick_Add(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button add = (Button)sender;
            operation = "+";
            textBoxDisplay.Text = value + add.Text;
            textBoxResult.Text = "";
        }

        private void ButtonClick_Subtract(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button subtract = (Button)sender;
            operation = "-";
            textBoxDisplay.Text = value + subtract.Text;
            textBoxResult.Text = "";
        }

        private void ButtonClick_Multiply(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button multiply = (Button)sender;
            operation = "x";
            textBoxDisplay.Text = value + multiply.Text;
            textBoxResult.Text = "";
        }

        private void ButtonClick_Divide(object sender, EventArgs e)
        {
            operator_pressed = true;
            Button divide = (Button)sender;
            operation = "/";
            textBoxDisplay.Text = value + divide.Text;
            textBoxResult.Text = "";
        }

        private void ButtonClick_Sign(object sender, EventArgs e)
        {
            textBoxResult.Text = "-" + textBoxResult.Text;
        }
    }
}
