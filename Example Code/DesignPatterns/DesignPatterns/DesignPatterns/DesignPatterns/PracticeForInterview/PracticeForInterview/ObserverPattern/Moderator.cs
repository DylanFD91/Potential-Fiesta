using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.ObserverPattern
{
    //ConcreteObserver
    public class Moderator : ISubscriber
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public Moderator(string name)
        {
            this.name = name;
        }
        public void Notify(ISubscriber subscriber)
        {
            Console.Write("Moderator {0} needs to review new video!\n", subscriber.Name);
        }
    }
}
