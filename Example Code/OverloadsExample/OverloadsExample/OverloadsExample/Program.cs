using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();

            Player p2 = new Player("Jake");

            Player p3 = new Player("Mike", 1);
        }
    }
}
