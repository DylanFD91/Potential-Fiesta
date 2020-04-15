using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraseodymiumDemo
{
    public class PayCalculator
    {
        public int GetHours()
        {
            Console.WriteLine("Get Hours");
            int hours = int.Parse(Console.ReadLine());
            return hours;
        }
        public double GetRate()
        {
            Console.WriteLine("Enter pay rate");
            double payRate = double.Parse(Console.ReadLine());
            return payRate;
        }

        public double CalculateGrossPay(int myHours, double myPayRate)
        {
            double grossPay = myHours * myPayRate;
            return grossPay;
        }

        public void DisplayGrossPay(double grossPay)
        {
            Console.WriteLine(grossPay);
        }

        public void RunPayCalculator()
        {
            int hoursWorked = GetHours();

            double payRate = GetRate();

            double myGrossPay = CalculateGrossPay(hoursWorked, payRate);

            DisplayGrossPay(myGrossPay);
        }


        //public int AddTwoNumbers(int one, int two)
        //{
        //    int sum = one + two;
        //    return sum;
        //}

        //public int GetCountOfCharacters(string word)
        //{

        //    return word.Length;
        //}
    }
}
