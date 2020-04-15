using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfInts
{
    class ThePool
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //Use Case: Given numbers in an array: [5, 17, 77, 50]
        //Target: 55


        //Member Variables
        int returnedNumber;
        int addedNumber;
        int userInput1;
        int userInput2;
        int[] arrayOfIntegers = new int[] { 5, 17, 77, 50 };

        //Constructor
        public ThePool()
        {

        }
        //Methods
        public void AskForUserInput()
        {
            Array.ForEach(arrayOfIntegers, Console.WriteLine);
            Console.WriteLine("Please Choose which number you would like to add from the array");
        }
        public int FirstUserInputForWhichNumbers()
        {
            bool isUserInputAnInt = false;
            while (!isUserInputAnInt)
            {
                AskForUserInput();
                isUserInputAnInt = Int32.TryParse(Console.ReadLine(), out userInput1);
            }
            return userInput1;
        }
        public int SecondUserInputForWhichNumbers()
        {
            bool isUserInputAnInt = false;
            while (!isUserInputAnInt)
            {
                AskForUserInput();
                isUserInputAnInt = Int32.TryParse(Console.ReadLine(), out userInput2);
            }
            return userInput2;
        }
        public int AddTwoNumbersInArray()
        {
            addedNumber = arrayOfIntegers[userInput1] + arrayOfIntegers[userInput2];
            returnedNumber = addedNumber;
            return returnedNumber;
        }

    }
}
