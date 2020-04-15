using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.CompositePattern
{
    public class Supervisor : IEmployee
    {
        private string name;
        private string title;
        private int happinessPercent;
        private List<IEmployee> employees = new List<IEmployee>();
        public Supervisor(string name, string title, int happinessPercent)
        {
            this.name = name;
            this.title = title;
            this.happinessPercent = happinessPercent;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("{0} {1} shows happiness level of {2} percent", title, name, happinessPercent);
            foreach (IEmployee employee in employees)
            {
                employee.DisplayStatus();
            }

        }
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
    }
}
