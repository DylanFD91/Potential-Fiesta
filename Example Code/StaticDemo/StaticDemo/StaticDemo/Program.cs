using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pizza Place!");
            Pizza pizza = new Pizza();
            int toppingAmount = pizza.NumberofToppings();
            pizza.GetToppings(toppingAmount);
            Pizza.DisplayPrice();
            Console.ReadLine();

            //Pizza.DisplayPrice();
            //Pizza.Price = 5.25;
            //Pizza.DisplayPrice();
            //Console.ReadLine();
        }
    }
}
