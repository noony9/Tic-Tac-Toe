using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: create a tic-tac-toe game

            // Step 1: declare and initialize variables to hold game numbers 0 through 8 (e.g., int zero = 0, int one = 1)
            int zero = 0, one = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8;

            // Step 2: declare a 2D array with three rows and 3 columns (indices) and assign variable zero to index 0, one to index 1 and so on
            string[,] ticArray = new string[3, 3]
            {
                {"zero", "one", "two" }, // row zero
                {"three", "four", "five"}, // row one
                {"six", "seven", "eight"} // row two
            };

            // Step 3: create the game board using "|" for lines and 0-8 displayed as indices "one" through "eight"

            Console.WriteLine("       |      |       " );
            Console.WriteLine($"   {0}   |   {1}  |  {2}   ", ticArray[0, 0], ticArray[0, 1], ticArray[0, 2]);
            Console.WriteLine($" _____________________  \n" );
            Console.WriteLine($"   {3}   |   {4}  |  {5}   ", ticArray[1, 0], ticArray[1, 1], ticArray[1, 2]);
            Console.WriteLine($" _____________________  \n" );
            Console.WriteLine($"   {6}   |   {7}  |  {8}   ", ticArray[2, 0], ticArray[2, 1], ticArray[2, 2]);
            Console.WriteLine($"       |      |       " );

            // Step 4: greet players and prompt to begin
            Console.WriteLine("Greetings!  Welcome to Noony's Tic Tac Toe Game!");
            Console.WriteLine("Press any key to begin.");
            Console.ReadLine();

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
