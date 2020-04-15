using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern.AnotherExample
{
    public class Player
    {
        public string ChooseItemToPurchase()
        {
            Console.WriteLine("What item would you like to purchase?");
            string item = Console.ReadLine();
            return item;
        }
    }
}
