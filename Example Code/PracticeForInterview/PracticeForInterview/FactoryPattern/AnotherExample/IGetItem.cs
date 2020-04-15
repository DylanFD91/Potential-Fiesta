using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern.AnotherExample
{
    public interface IGetItem
    {
        Item GetItemToPurchase(string item);
    }
}
