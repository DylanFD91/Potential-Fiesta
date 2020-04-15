using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.DependencyInjection
{
    public class PowerSupply : IPowerSource
    {
        private int volts;
        public int Volts
        {
            get
            {
                return volts;
            }

            set
            {
                volts = value;
            }
        }
        public PowerSupply(int volts)
        {
            this.volts = volts;
        }
        public void EmitPower()
        {
            Console.WriteLine("Using power");
        }
    }
}
