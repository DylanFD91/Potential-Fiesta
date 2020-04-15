using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadsExample
{
    class Player
    {
        public string gesture;
        public int score;
        public string name;

        public Player()
        {
            gesture = "";
            score = 0;
            name = GetName();
        }

        public Player(string name)
        {
            gesture = "";
            score = 0;
            this.name = name;
        }

        public Player(string name, int startingScore)
        {
            gesture = "";
            score = startingScore;
            this.name = name;
        }

        public string GetName()
        {
            Console.WriteLine("Please enter your name:");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
