using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string flamingo in args)
            {
                Console.WriteLine(flamingo);
            }
            List<string> thing = new List<string>();

            //for (int i = 0; i < 5000; i++)
            //{
            //    thing.Add("Nevin");
            //}
            //for (int i = 0; i < thing.Count; i++)
            //{
            //    Console.WriteLine(thing[i]);
            //}
            //////////////////////////////
            int[] otherThing = new int[6];

            for (int i = 0; i < otherThing.Length; i++)
            {
                otherThing[i] = i;
            }
            foreach(int banana in otherThing)
            {
                Console.WriteLine(banana);
            }
            Console.WriteLine(otherThing);
            Console.ReadLine();
            ClockRadio myClockRadio = new ClockRadio();
            myClockRadio.Setup();
        }
    }
}
