using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class GameBoard
    {
        private string[,] _gameArray;

        public string[,] GameArray
        {
            get { return _gameArray; }
            set { _gameArray = value; }
        }

       // GameBoard() { }

    }
}
