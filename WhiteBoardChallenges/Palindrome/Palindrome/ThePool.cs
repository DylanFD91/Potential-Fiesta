using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class ThePool
    {
        //member variables
        public string userInputOriginal, userInputLowerCased, userInputBeingConverted, userInputConvertedAndReversed;
        public char[] userInputInArray, userInputArrayReversed;
        bool itsReversable = false;
        //constructor
        public ThePool()
        {

        }
        //methods
        public void UserInputForPalindrome()//Just gathers user input*TESTED*
        {
            Console.WriteLine("Lets see if what you type in is a palindrome");
            userInputOriginal = Console.ReadLine();
        }
        public void LowerCaseUserInput()//Lower cases the input in the second storage container*TESTED*
        {
            string bringingInTheInput = userInputOriginal;
            userInputLowerCased = bringingInTheInput.ToLower();
        }
        public void TurnInputToArray()//Turns input into an array of chars
        {
            userInputBeingConverted = userInputLowerCased;
            char[] userInputGoingInArray = userInputBeingConverted.ToCharArray();
            userInputInArray = userInputGoingInArray;
        }
        public void ArrayReverse()//Takes the array and flips it
        {
            userInputArrayReversed = userInputInArray.Reverse().ToArray();
        }
        public void ArrayBackToString()//Turns the flipped array back into a string
        {
            string converter = new string(userInputArrayReversed);
            userInputConvertedAndReversed = converter;
        }
        public void IsItReversable()//Checks if the lower cased input is equal to the reveresed input
        {
            if (userInputConvertedAndReversed == userInputLowerCased)
            {
                itsReversable = true;
                ItIsTheSame();
            }
            else
            {
                ItIsntTheSame();
            }
        }
        private void ItIsTheSame()//Just reports original input is a palindrome
        {
            Console.WriteLine(userInputOriginal + " is a palindrome, good job!");
            Console.ReadLine();
        }
        private void ItIsntTheSame()//Just reports original input is not a palindrome
        {
            Console.WriteLine(userInputOriginal + " is not a palindrome, lets try again...");
            Console.ReadLine();
        }
        public void Run()//Runs all methods until a proper Palindrome is given
        {
            while (itsReversable == false)
            {
                UserInputForPalindrome();
                LowerCaseUserInput();
                TurnInputToArray();
                ArrayReverse();
                ArrayBackToString();
                IsItReversable();
            }
        }
    }
}
