using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.CompositePattern
{
    public class Worker : IEmployee
    {
        private string name;
        private string title;
        private int happinessPercent;
        public Worker(string name, string title, int happinessPercent)
        {
            this.name = name;
            this.title = title;
            this.happinessPercent = happinessPercent;
        }
        void IEmployee.DisplayStatus()
        {
            Console.WriteLine("{0} {1} shows happiness level of {2} percent", title, name, happinessPercent);
        }
    }
}
