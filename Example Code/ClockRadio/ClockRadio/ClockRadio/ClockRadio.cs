using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {

        //memeber variables (Has A)
        public Clock myClock;
        public Radio myRadio;
        public bool Power;

        //constuctor (spawner)
        public ClockRadio()
        {
            myClock = new Clock();
            myRadio = new Radio(LocalStaion());
            Setup();
        }
        //member methods (Can Do)
        public void TogglePower()
        {
            Power = !Power;
        }
        public double LocalStaion()
        {
            Console.WriteLine("What is the frequency of a local station");
            double input = double.Parse(Console.ReadLine());
            return input;
        }
        public void Setup()
        {
            myClock.Initialize();
            myRadio.TogglePower();
            myRadio.ChangeStation();
          
        }

        public void MainMenu()
        {
            myClock.DisplayTime();
            
        }

    }
}
