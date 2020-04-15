using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.ObserverPattern
{
    //ConcreteObserver
    public class User : ISubscriber
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
        public User(string name)
        {
            this.name = name;
        }
        public void Notify(ISubscriber subscriber)
        {
            Console.Write("User {0} has been updated about new video!\n", subscriber.Name);
        }
    }
}
