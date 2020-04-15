using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern
{
    public class FordFiestaFactory : ICreateCars
    {
        public Car CreateACar(string color)
        {
            return new FordFiesta() { Color = color };
        }
    }
}
