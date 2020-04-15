using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator
{
    public class Addition
    {
        public List<int> myNumbers = new List<int>();
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void AddThreeNumbers(int first, int second, int third)
        {
            int result = first + second + third;
            Console.WriteLine(result);
        }

        public void AddNumbersToList(int one, int two)
        {
            myNumbers.Add(one);
            myNumbers.Add(two);
        }
        public List<Person> AddPeople(Person bob, Person frank)
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(bob);
            myPeople.Add(frank);
            return myPeople;
        }
        public void AddFiveIntsToList()
        {
            for (int i = 0; i < 5; i++)
            {
                myNumbers.Add(i + 1);
            }
        }
    }
}
