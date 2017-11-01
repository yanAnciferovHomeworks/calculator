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
        int? number1_ = null;
        int? number2_ = null;
        int? result_ = null;
        ICalculate calculate_;



        public Calc()
        {
            InitializeComponent();
        }

      

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            calculate_ = new Plus();
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

        private void button22_Click(object sender, EventArgs e)
        {
            number1_ = null;
            number2_ = null;
            Table.Text = "";
        }
    }
}
