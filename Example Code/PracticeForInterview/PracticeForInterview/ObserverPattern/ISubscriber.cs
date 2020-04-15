using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.ObserverPattern
{
    //Observer
    public interface ISubscriber
    {
        string Name { get; set; }
        void Notify(ISubscriber subscriber); 
    }
}
