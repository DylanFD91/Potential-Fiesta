using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class newClass
    {
        public int sum;
        public int userInputInt;

        public int UserInput()
        {
            Console.WriteLine("Enter a number:");
            userInputInt = Convert.ToInt32(Console.ReadLine());
            return userInputInt;
        }

        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public void Run()
        {
            sum = AddTwoNumbers(UserInput(), UserInput());
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
        
        
    }
}
