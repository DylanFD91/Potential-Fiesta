using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeForInterview.FacadePattern
{
    public class PizzaFacade
    {
        private Dough dough;
        private Sauce sauce;
        private Topping topping;
        private Cheese cheese;
        private Oven oven;
        public PizzaFacade(string sauce, string topping, string cheese)
        {
            this.dough = new Dough();
            this.sauce = new Sauce(sauce);
            this.topping = new Topping(topping);
            this.cheese = new Cheese(cheese);
            this.oven = new Oven();
        }
        public void MakePizza()
        {
            dough.AddSauce(sauce);
            dough.AddCheese(cheese);
            dough.AddTopping(topping);
            oven.SetTemperature(450);
            oven.SetTimer(25);
            oven.Cook(dough);
            
        }
    }
}
