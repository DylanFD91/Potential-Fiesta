using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Pizza
    { 
        //Member Variables (HAS A)
        List<Topping> toppings;
        private static double price;
        public static double Price { get { return price; } set { price = value; } }

        //Static Constructor
        static Pizza()
        {
            price = 3.50;
        }
        //Non-Static Constructor
        public Pizza()
        {
            toppings = new List<Topping>();
            price = 4.50;
        }

        //Member Methods (CAN DO)
        public static void DisplayPrice()
        {
            Console.WriteLine($"The price of your pizza is {price}");
        }

        public int NumberofToppings()
        {
            Console.WriteLine("How many toppings do you want?");
            int toppingAmount = int.Parse(Console.ReadLine());
            return toppingAmount;
        }

        public void GetToppings(int toppingAmount)
        {
            for(int i = 0; i < toppingAmount; i++)
            {
                Console.WriteLine("What kind of topping?");
                toppings.Add(new Topping(Console.ReadLine()));
            }
        }
    }
}
