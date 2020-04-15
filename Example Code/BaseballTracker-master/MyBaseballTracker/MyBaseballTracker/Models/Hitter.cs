using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBaseballTracker.Models
{
    public class Hitter : Player
    {
        public int Games { get; set; }
        public int AtBats { get; set; }
        public int Runs { get; set; }
        public int HomeRuns { get; set; }
        public int RunsBattedIn { get; set; }
        public double BattingAverage { get; set; }
    }
}