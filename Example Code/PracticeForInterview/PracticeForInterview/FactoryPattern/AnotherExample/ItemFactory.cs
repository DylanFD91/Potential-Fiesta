using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern.AnotherExample
{
    public class ItemFactory : IGetItem
    {
        public Item GetItemToPurchase(string item)
        {
            switch (item.ToLower())
            {
                case "lemon":
                    return new Lemon();
                case "sugar":
                    return new Sugar();
                case "ice":
                    return new Ice();
                case "cup":
                    return new Cup();
                default:
                    throw new ApplicationException(string.Format("Not a valid item to purchase"));
            }
        }
    }
}
