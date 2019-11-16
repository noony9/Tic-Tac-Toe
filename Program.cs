using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    // set game conditions
    enum Condition
    {
        Continue,
        Win,
        Draw
    }
    class Program
    {
        private int[,] GameArray() { }
        public static void Introduction() // Step 1 greet players and prompt to begin
        {
            Console.WriteLine("Greetings!  Welcome to Noony's Tic Tac Toe Game!"); // greet user
            Console.WriteLine("Press any key to begin."); // prompt user to begin game
            Console.ReadLine(); // get user input
        }
        public static void GameBoard(int[,] array) // Step 2 display current game board
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
        
        static void Main(string[] args)
        {
            // Task: create a tic-tac-toe game
            // Step - initialize game
                
            int[,] ticArray = new int[3, 3] // declare a 2D array with three rows and 3 columns (indices) to store user inputs
            {
                {0, 1, 2 }, // row zero
                {3, 4, 5 }, // row one
                {6, 7, 80 } // row two
            };

            // Step - greet players and prompt to begin
            Introduction();

            // Step - display game board
            GameBoard(ticArray);

            // Step - user 1 turn ChangeTurn()

            // Step - update game board & evaluate game conditions (continue, win or draw)
            // Step -user 2 turn
            // Step - update and display game board
            // Step - continue alternating turns until winning condition is met
            // Step - announce winner and update score tally
            // Step - ask users to play again (if no, exit game) (if yes, restart game)








            // Step 5: prompt user for input on number selection



            // Step 6: replace index selected with "X"

            // Step 7: check if player 'Wins' following each input
            // Switch 

            // Step 8: congratulate winner!

            // Step 9: prompt user to play again (Y or N)

            // Step 10: exit or restart game
        }

    }
}
