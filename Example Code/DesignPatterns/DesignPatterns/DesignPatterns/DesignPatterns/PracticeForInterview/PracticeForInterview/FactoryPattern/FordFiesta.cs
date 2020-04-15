using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern
{
    public class FordFiesta : Car
    {
        public FordFiesta()
        {
            Make = "Ford";
            Model = "Fiesta";
            EngineSize = "1.1";
        }
    }
}
