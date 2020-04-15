using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.FactoryPattern.AnotherExample
{
    public class Store
    {
        
        public void SellItem(Player player, ItemFactory itemFactory)
        {
            string input = player.ChooseItemToPurchase();
            Item item = itemFactory.GetItemToPurchase(input);
        }
    }
}
