using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.DependencyInjection
{
    public class CoffeeMaker
    {
        int neededVolts = 12;
        IPowerSource powerSource;
        public CoffeeMaker(IPowerSource powerSource)
        {
            this.powerSource = powerSource;
        }
        public void Use()
        {
            if(powerSource.Volts <= neededVolts)
            {
                powerSource.EmitPower();
            }
        }
    }
}
