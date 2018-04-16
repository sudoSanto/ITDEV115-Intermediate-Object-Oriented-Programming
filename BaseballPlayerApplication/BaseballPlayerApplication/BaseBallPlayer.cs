using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballPlayerApplication
{
    class BaseBallPlayer
    {
        public BaseBallPlayer() { }

        private double battingavg = 0;
        public double BattingAvg { get { return battingavg; } set { battingavg = value; } }

        private string firstName = "";
        public string FirstName { get { return firstName; } set { firstName = value; } }

        private string lastName = "";
        public string LastName { get { return lastName; } set { lastName = value; } }

        private string team = "";
        public string Team { get { return team; } set { team = value; } }
    }
}
