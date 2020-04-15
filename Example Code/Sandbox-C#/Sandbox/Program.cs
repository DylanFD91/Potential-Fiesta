using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Can starbucksDoubleShot = new Can("brown");

            Console.WriteLine(starbucksDoubleShot.color);
            Console.WriteLine(starbucksDoubleShot.isOpen);
            Console.WriteLine(starbucksDoubleShot.percentageFull);

            starbucksDoubleShot.TakeSip();

            Console.WriteLine(starbucksDoubleShot.percentageFull);

            Console.ReadLine();
        }
    }
}