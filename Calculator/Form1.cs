using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Doing
{
    Plus,
    Minus,
    Degree,
    Multyple,
    Equels,
    Sqrt
}

namespace Calculator
{
    public partial class Calc : Form
    {
        double? number1_ = null;
        double? number2_ = null;
        double? result_ = null;
        ICalculate calculate_;



        public Calc()
        {
            InitializeComponent();
        }



        private void Culculate()
        {
            if (number1_ == null)
            {
                number1_ = double.Parse(Table.Text);
            }
            else if (number2_ == null)
            {
                 number2_ = double.Parse(Table.Text);
            }
            else
            {
                number1_ = calculate_.Calculate(number1_.Value, number2_.Value);
                Table.Text = number1_.ToString();
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            calculate_ = new Plus();
            Culculate();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            calculate_ = new Minus();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            calculate_ = new Multiply();
        }

        private void ButtonDegree_Click(object sender, EventArgs e)
        {
            calculate_ = new Degree();
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Table.Text += (sender as Button).Text;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            StringBuilder TText = new StringBuilder(Table.Text);
            TText.Remove(TText.Length - 1, 1);
            Table.Text = TText.ToString();
        }

        private void ButtonClearC_Click(object sender, EventArgs e)
        {
            number1_ = null;
            number2_ = null;
            Table.Text = "";
        }
        private void ButtonClearCE_Click(object sender, EventArgs e)
        {
            Table.Text = "";
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            if (Table.Text.Length != 0)
            {
                if (Table.Text[0] != '-')
                {
                    Table.Text = Table.Text.Insert(0, "-");
                }
                else
                {
                    Table.Text = Table.Text.Remove(0,1);
                }
            }
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            Table.Text = Math.Sqrt(double.Parse(Table.Text)).ToString();
        }

        private void ButtonFraction_Click(object sender, EventArgs e)
        {
            Table.Text = (1 / double.Parse(Table.Text)).ToString();
        }
    }
}
