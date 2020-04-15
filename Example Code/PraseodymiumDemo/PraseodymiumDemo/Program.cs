using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraseodymiumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PayCalculator pay = new PayCalculator();
            //int hours = pay.GetHours();
            //hours = pay.GetHours();

            //int count = pay.GetCountOfCharacters("packers");

            //int dogAge = 3;
            //int catAge = 6;
            //int sum = pay.AddTwoNumbers(dogAge, catAge);

            pay.RunPayCalculator();
            
        }
    }
}
