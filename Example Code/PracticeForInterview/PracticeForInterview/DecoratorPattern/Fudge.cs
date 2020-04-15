using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.DecoratorPattern
{
    //concrete decorator
    public class Fudge : Topping
    {
        public Fudge(IceCream s): base(s)
        {

        }

        public override double Cost()
        {
            return 0.25 + IceCream.Cost();
        }
    }
}
