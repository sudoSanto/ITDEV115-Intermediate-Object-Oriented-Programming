using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGUI
{
    class TicTacToeLogic
    {
        public playerType IsPlaying(playerType pt)
        {
            if (pt == playerType.X)
                pt = playerType.O;
            else
                pt = playerType.X;

            return pt;
        }

        public bool IsTie(bool full, bool x, bool o)
        {
            bool isTie = false;

            if (full && !x && !o)
            {
                isTie = true;
            }

            return isTie;
        }
    }
}
