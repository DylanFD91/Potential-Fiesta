using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeForInterview.DependencyInjection.AnotherExample
{
    public class Pizzeria
    {
        List<IPreparable> foods;
        IPreparable food;
        public Pizzeria(IPreparable food)
        {
            foods = new List<IPreparable>();
            this.food = food;
        }
        public void AddFood()
        {
            foods.Add(food);
        }
        public void PrepareFood()
        {
            foreach(IPreparable food in foods)
            {
                food.Prepare();
            }
        }
    }
}
