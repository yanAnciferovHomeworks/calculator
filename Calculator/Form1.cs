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
        int? number1 = null;
        int? number2 = null;
        int? result = null;
        Doing doing;



        public Calc()
        {
            InitializeComponent();
        }

      

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            doing = Doing.Plus;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            doing = Doing.Minus;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            doing = Doing.Multyple;
        }

        private void ButtonDegree_Click(object sender, EventArgs e)
        {
            doing = Doing.Degree;
        }
    }
}
