using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.DecoratorPattern
{
    //decorator
    public abstract class Topping : IceCream
    {
        protected Topping(IceCream s)
        {
            IceCream = s;
        }

        protected IceCream IceCream { get; set; }
        
    }
}
