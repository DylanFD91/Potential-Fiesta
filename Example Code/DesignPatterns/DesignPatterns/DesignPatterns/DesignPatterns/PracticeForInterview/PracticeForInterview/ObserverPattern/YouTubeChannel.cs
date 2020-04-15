using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.ObserverPattern
{
    //subject
    public class YouTubeChannel
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        
        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
            Console.WriteLine("{0} Subscribed", subscriber.Name);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
            Console.WriteLine("{0} Unsubscribed", subscriber.Name);
        }
        public void Upload()
        {
            NotifySubscribers();
        }
        private void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {

                subscriber.Notify(subscriber);
            }
        }
    }
}
