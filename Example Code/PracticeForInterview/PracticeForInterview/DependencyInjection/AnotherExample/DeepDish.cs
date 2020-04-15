using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.DependencyInjection.AnotherExample
{
    
    public class DeepDish : IPreparable
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing deep dish pizza");
        }
    }
    
}
