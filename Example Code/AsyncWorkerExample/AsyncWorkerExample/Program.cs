using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWorkerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Worker worker = new Worker();
            worker.DoWork();
            while (!worker.isComplete)
            {
                Console.WriteLine("*");
                Thread.Sleep(100);
            }
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
