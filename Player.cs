using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Player
    {
        // player fields
        private string _name = "";
        private int _score = 0;

        // player properties
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public enum Turn { PlayerOneTurn, PlayerTwoTurn };
    }
}
