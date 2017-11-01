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
        bool isShowResult = true;
        ICalculate calculate_;



        public Calc()
        {
            InitializeComponent();
            Table.Text = 0.ToString();
        }



        private void Culculate()
        {
            if (isShowResult)
            {
                SubTable.Text = Table.Text;
                return;
            }

            if (number1_ == null)
            {
                number1_ = double.Parse(Table.Text);
                SubTable.Text = number1_.ToString();
                Table.Text = number1_.ToString();
                isShowResult = true;
            }
            else if (number2_ == null)
            {
                 number2_ = double.Parse(Table.Text);
                try
                {
                    number1_ = calculate_.Calculate(number1_.Value, number2_.Value);

                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Делть на 0 нельзя!", "Ошбка!");
                    
                    ButtonClearC_Click(null, null);
                    return;

                }
                SubTable.Text = number1_.ToString();
                Table.Text = number1_.ToString();
                isShowResult = true;
                number2_ = null;
            }
           
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Culculate();
            calculate_ = new Plus();  
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Culculate();
            calculate_ = new Minus();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Culculate();
            calculate_ = new Multiply();
        }

        private void ButtonDegree_Click(object sender, EventArgs e)
        {
            Culculate();
            calculate_ = new Degree();
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            if (isShowResult)
            {
                isShowResult = false;
                Table.Text = "";
                
            }
            Table.Text += (sender as Button).Text;

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!isShowResult && Table.Text.Length != 0)
            {
                StringBuilder TText = new StringBuilder(Table.Text);
                TText.Remove(TText.Length - 1, 1);
                Table.Text = TText.ToString();
            }
        }

        private void ButtonClearC_Click(object sender, EventArgs e)
        {
            isShowResult = true;
            number1_ = null;
            number2_ = null;
            Table.Text = "0";
            SubTable.Text = "";
        }
        private void ButtonClearCE_Click(object sender, EventArgs e)
        {
            isShowResult = true;
            Table.Text = "0";
            SubTable.Text = "";
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

                if (isShowResult)
                {
                    number1_ = -number1_;
                }
            }
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            Table.Text = Math.Sqrt(double.Parse(Table.Text)).ToString();
            isShowResult = true;
        }

        private void ButtonFraction_Click(object sender, EventArgs e)
        {
            Table.Text = (1 / double.Parse(Table.Text)).ToString();
            isShowResult = true;
        }

        private void ButtonEquels_Click(object sender, EventArgs e)
        {
            Culculate();
            SubTable.Text = "";
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (isShowResult)
            {
                ButtonClearC_Click(sender,e);
                isShowResult = false;
            }
            ButtonNum_Click(sender, e);
        }
    }
}
