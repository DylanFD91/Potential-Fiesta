using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Printer
    {
        public static string GetName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;
        }
        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static void Execute()
        {
            PrintName(GetName());
        }
    }
}
