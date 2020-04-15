using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Radio
    {
        //memeber variables (Has A)
        public double currentStation;
        public bool radioPower;
        public int volume;


        //constuctor (spawner)
        public Radio(double localStaion)
        {
            currentStation = localStaion;
            radioPower = false;
            volume = 5;
        }
        //member methods (Can Do)
        public void ChangeStation()
        {
            double tunerIncrement = 0.2;
            Console.WriteLine("Would you like to tune the station up or down?");
            ConsoleKeyInfo input = Console.ReadKey();
            if(input.Key == ConsoleKey.UpArrow)
            {
                currentStation += tunerIncrement;
            }
            else if(input.Key == ConsoleKey.DownArrow)
            {
                currentStation -= tunerIncrement;
            }
        }
        public void DisplayStation()
        {
            Console.WriteLine("The current station is: " + currentStation);
        }
        public void ChangeVolume()
        {

        }
        public void TogglePower()
        {
            radioPower = !radioPower;
        }
    }
}
