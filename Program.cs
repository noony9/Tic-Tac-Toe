using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static void Introduction() // Step - greet players and prompt to begin
        {
            Console.WriteLine("Greetings!  Welcome to Noony's Tic Tac Toe Game!"); // greet user
            Console.WriteLine("Press any key to begin."); // prompt user to begin game
            Console.ReadLine(); // get user input
            Console.Clear(); // clear screen
        }
        public static void GameBoard(string[,] array) // Step - display current game board
        {
            // create the game board using characters for lines, display 1 through 8 as the current indicies of user input array
            Console.Clear(); // refresh screen
            Console.WriteLine("       |      |       ");
            Console.WriteLine($"   {0}   |   {1}  |  {2}   ", array[0, 0], array[0, 1], array[0, 2]);
            Console.WriteLine($" _____________________  \n");
            Console.WriteLine($"   {3}   |   {4}  |  {5}   ", array[1, 0], array[1, 1], array[1, 2]);
            Console.WriteLine($" _____________________  \n");
            Console.WriteLine($"   {6}   |   {7}  |  {8}   ", array[2, 0], array[2, 1], array[2, 2]);
            Console.WriteLine($"       |      |       ");
        }

        public static void PlayerInput(string input) 
        {

        }

        // Winning conditions: 123, 345, 678, 036, 147 258, 048, 246
        private static bool WinCheck(string[,] array)
        {
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] == "X") //horizontal lines
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] == "X") //vertical lines
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] == "X") //diagonal lines
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[0, 2] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }
            //--------------
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] == "O") //horizontal lines
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] == "O") //vertical lines
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] == "O") //diagonal lines
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[0, 2] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                return true;
            }

            return false; 
        }
        static void Main(string[] args)
        {
            // Step - initialize game
            int turn = 0;
            int turnCount = 0;
            string[,] gameArray = new string[3, 3] 
            {
                {"0", "1", "2" }, // row zero
                {"3", "4", "5" }, // row one
                {"6", "7", "8" } // row two
            };

            // Step - greet players and prompt to begin
            Introduction();

            // Step - display game board
            GameBoard(gameArray);

            // Step - provide instructions
            
            Console.WriteLine("Player 1's token is 'X and Player 2's token is 'O'");
            Console.ReadLine();

            // game plays until winning condition is met
            while (true)
            {
                /*          
                Console.WriteLine($"   {0}   |   {1}  |  {2}   ", array[0, 0], array[0, 1], array[0, 2]);
                Console.WriteLine($" _____________________  \n");
                Console.WriteLine($"   {3}   |   {4}  |  {5}   ", array[1, 0], array[1, 1], array[1, 2]);
                Console.WriteLine($" _____________________  \n");
                Console.WriteLine($"   {6}   |   {7}  |  {8}   ", array[2, 0], array[2, 1], array[2, 2]);
                Console.WriteLine($"       |      |       "); 
                */
                // Step - prompt user for input on number selection
                Console.WriteLine($"Player 1 make your selection! (enter the corresponding digit and press enter)\n");

                // Step - get player's input and place marker on game board
                int input = Convert.ToInt32(Console.ReadLine());
                switch(input) 
                {
                    case 0: 
                        gameArray[0,0] = "X";
                        break;
                    case 1:
                        gameArray[0,1] = "X";
                        break;
                    case 2:
                        gameArray[0,2] = "X";
                        break;
                    case 3: 
                        gameArray[1,0] = "X";
                        break;
                    case 4: 
                        gameArray[1,1] = "X";
                        break;
                    case 5:
                        gameArray[1,2] = "X";
                        break;
                    case 6: 
                        gameArray[2,0] = "X";
                        break;
                    case 7: 
                        gameArray[2,1] = "X";
                        break;
                    case 8:
                        gameArray[2,2] = "X";
                        break;
                    default: 
                        break;
                }

                // Step - increment turnCount
                turnCount++;

                // Step - display game board
                GameBoard(gameArray);

                // Step - evaluate game conditions (continue or win)
                WinCheck(gameArray);
                // Step - change the turn
    
                Console.WriteLine($" Player 2 make your selection! (enter the corresponding digit and press enter)\n");
                        
                // Step - update and display game board
                input = Convert.ToInt32(Console.ReadLine());
                switch(input) 
                {
                    case 0: 
                        gameArray[0,0] = "O";
                        break;
                    case 1: 
                        gameArray[0,1] = "O";
                        break;
                    case 2:
                        gameArray[0,2] = "O";
                        break;
                    case 3: 
                        gameArray[1,0] = "O";
                        break;
                    case 4: 
                        gameArray[1,1] = "O";
                        break;
                    case 5:
                        gameArray[1,2] = "O";
                        break;
                    case 6: 
                        gameArray[2,0] = "O";
                        break;
                    case 7: 
                        gameArray[2,1] = "O";
                        break;
                    case 8:
                        gameArray[2,2] = "O";
                        break;
                    default: 
                        break;
                }
                // Step - increment turnCount
                turnCount++;

                // Step - display game board
                GameBoard(gameArray);

                // Step - evaluate game conditions (continue, win or draw)
                WinCheck(gameArray);
                        
            }

            // Step - user 2 turn
            // Step - announce winner and update score tally
            // Step - ask users to play again (if no, exit game) (if yes, restart game)

            // Step 10: exit or restart game
        }

    }
}
