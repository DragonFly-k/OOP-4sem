using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1
{
    public partial class Calculator : Form, ICalculator
    {
        public string D;
        public string Num1;
        public bool n2;
        public int Max=10;
        public Calculator()
        {
            n2 = false;
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            if (textBox1.Text.Length < Max)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = B.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + B.Text;
                }
            }
            else
            {
                MessageBox.Show("Слишком длинное число");
                button8_Click(sender, e);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox1.Text = "Bin";
            textBox2.Text = "0";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            Num1 = textBox1.Text;
            n2= true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (n2 && D != "~")
            {
                MessageBox.Show("Некорректные данные!\n" +
                    "Введите число или другую операцию");
                button8_Click(sender, e);
            }
            int INum1 = Convert.ToInt32(Num1,2);
            int INum2 = Convert.ToInt32(textBox1.Text,2);
            switch (D)
            {
                case "&&":
                    AND(INum1, INum2);
                    break;
                case "|":
                    OR(INum1, INum2);
                    break;
                case "^":
                    XOR(INum1, INum2);
                    break;
                case "~":
                    NOT(INum1);
                    break;
            }
            switch (comboBox1.Text)
            {
                case "Oct":
                    int j = Convert.ToInt32(textBox2.Text);
                    textBox2.Text = Convert.ToString(j, 8);
                    break;
                case "Dec":
                    if (D == "~")
                    {
                        break;
                    }
                    else
                    {
                        int l = Convert.ToInt32(textBox2.Text);
                        textBox2.Text = Convert.ToString(l, 10);
                        break;
                    }
                case "Hex":
                    int t = Convert.ToInt32(textBox2.Text);
                    textBox2.Text = Convert.ToString(t, 16);
                    break;
                case "Bin":
                default:
                    int i = Convert.ToInt32(textBox2.Text);
                    textBox2.Text = Convert.ToString(i, 2);
                    break;
            }
        }
        public void AND(int INum1, int INum2)
        {
            textBox2.Text = Convert.ToString(INum1 & INum2);
        }
        public void OR(int INum1, int INum2)
        {
            textBox2.Text = Convert.ToString(INum1 | INum2);
        }
        public void XOR(int INum1, int INum2)
        {
            textBox2.Text = Convert.ToString(INum1 ^ INum2);
        }
        public void NOT(int INum1)
        {
            if (n2 == false)
            {
                MessageBox.Show("Некорректные данные!\n"+
                    "Операция НЕ: введите только 1 число");
                textBox1.Text = "0";
                comboBox1.Text = "Bin";
                textBox2.Text = "0";
            }
            else
            {
                string Num1 = Convert.ToString(INum1, 2);
                string result="";
                for(int i = 0; i < Num1.Length; i++)
                {
                    if (Num1[i] == '1')
                    {
                        result += "0";
                    }
                    else if (Num1[i] == '0')
                    {
                        result += "1";
                    }
                }
                String res = Convert.ToString(Convert.ToInt32(result,2), 10);
                textBox2.Text=res;
            }            
        }
    }
}
