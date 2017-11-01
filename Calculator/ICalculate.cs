using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculate
    {
        double Calculate(double num1, double num2);
    }

    class Plus : ICalculate
    {

        public double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Minus : ICalculate
    {

        public double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class Degree : ICalculate
    {

        public double Calculate(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Multiply : ICalculate
    {

        public double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
