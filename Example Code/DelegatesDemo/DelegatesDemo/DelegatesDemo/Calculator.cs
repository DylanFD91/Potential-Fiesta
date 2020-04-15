using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Calculator
    {
        public delegate double Calculate(double firstNumber, double secondNumber);
        public double AddTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double MultiplyTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public void PrintResult(double firstNumber, double secondNumber, Calculate Calculation)
        {
            double result = 0;
            

            result = Calculation(firstNumber, secondNumber);
        }

        
    }
}
