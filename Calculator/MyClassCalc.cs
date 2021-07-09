using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class MyClassCalc
    {
        private string value = "";
        private string operation = "";
        private string negasign = "";
        private bool operator_pressed = false;
        private bool equal_pressed = false;

        private string display = "";
        private string result = "";

        public string Value { get => value; set => this.value = value; }
        public string Operation { get => operation; set => operation = value; }
        public string Negasign { get => negasign; set => negasign = value; }
        public bool Operator_pressed { get => operator_pressed; set => operator_pressed = value; }
        public bool Equal_pressed { get => equal_pressed; set => equal_pressed = value; }
        public string Display { get => display; set => display = value; }
        public string Result { get => result; set => result = value; }

        /*public void AddEquals()
        {
            Display += Result + " =";
            Result = (float.Parse(Value) + float.Parse(Result)).ToString();
        }

        public void SubtractEquals()
        {
            Display += Result + " =";
            Result = (float.Parse(Value) - float.Parse(Result)).ToString();
        }

        public void MultiplyEquals()
        {
            Display += Result + " =";
            Result = (float.Parse(Value) * float.Parse(Result)).ToString();
        }

        public void DivideEquals()
        {
            Display += Result + " =";
            Result = (float.Parse(Value) / float.Parse(Result)).ToString();
        }*/
    }
}
