using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfInts
{
    static class UserInterface
    {
        public static void AskForUserInput(ArrayAndItsInts theArray)
        {
            Console.WriteLine(theArray);
            Console.WriteLine("Please Choose which number you would like to add from the array");
        }
    }
}
