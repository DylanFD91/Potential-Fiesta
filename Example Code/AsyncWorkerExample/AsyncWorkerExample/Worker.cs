using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWorkerExample
{
    public class Worker
    {
        public bool isComplete;
        public async void DoWork()
        {
            //Execute as normal
            isComplete = false;
            Console.WriteLine("Doing work");

            //Run this method asynchronously while rest of application continues
            await SomeLongOperation();

            //Run this code after SomeLongOperation() is completed
            Console.WriteLine("Work completed");
            isComplete = true;
        }
        private Task SomeLongOperation()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Working");
                Thread.Sleep(2000);
            });
        }
    }
}
