using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public enum GameState {Title, Playing, PlayerOneTurn, PlayerTwoTurn, GameOver};
    class Program
    {
        public void InitializeGame()
        {
            // greet players and go over rules
            Console.WriteLine("Welcome to Noony's Tic-tac-toe.  Player 1 = 'X', Player 2 = 'O'.\nThree colinear marks of the same symbol wins!\n\n");
         
        }

        public void DisplayBoard(string[,] array)
        {
            Console.WriteLine($"   {0}   |   {1}  |  {2}   ", array[0, 0], array[0, 1], array[0, 2]);
            Console.WriteLine($" _____________________  \n");
            Console.WriteLine($"   {3}   |   {4}  |  {5}   ", array[1, 0], array[1, 1], array[1, 2]);
            Console.WriteLine($" _____________________  \n");
            Console.WriteLine($"   {6}   |   {7}  |  {8}   ", array[2, 0], array[2, 1], array[2, 2]);
            Console.WriteLine($"       |      |       ");
        }

        // Winning conditions: 123, 345, 678, 036, 147 258, 048, 246
        public bool WinCheck(string[,] array)
        {
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] == "X") //horizontal lines
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] == "X")
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] == "X")
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
                  }
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] == "X") //vertical lines
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] == "X")
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] == "X")
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] == "X") //diagonal lines
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[0, 2] == "X")
            {
                  Console.WriteLine("Player 1 Wins!");
                  return false;
            }
            //--------------
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 0] == "O") //horizontal lines
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 0] == "O")
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 0] == "O")
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[0, 0] == "O") //vertical lines
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[0, 1] == "O")
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[0, 2] == "O")
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[0, 0] == "O") //diagonal lines
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[0, 2] == "O")
            {
                  Console.WriteLine("Player 2 Wins!");
                  return false;
            }
            else
            {
                return true;
            }
                  
        }

        static void Main(string[] args)
        {
            Program TicTacToe = new Program();
            GameBoard activeBoard = new GameBoard();
            activeBoard.GameArray = new string[3, 3] {
            { "0", "1", "2" },
            { "3", "4", "5" },
            { "6", "7", "8" }
            };

            // initialize title screen 

            TicTacToe.InitializeGame();

            // initialize the players!
            Player playerOne = new Player();
            Player playerTwo = new Player();

            // prompt player 1 to enter name and set value for player 1's name
            Console.WriteLine("Player 1, please input your name then press enter...");

            playerOne.Name = Console.ReadLine();
            string name1 = playerOne.Name;

            // greet player 1
            Console.WriteLine($"Greetings {name1}!  Welcome to Noony's Tic Tac Toe Game!\n");

            // prompt player 2 to enter name and set value for player 2's name
            Console.WriteLine("Player 2, please input your name then press enter...");
            playerTwo.Name = Console.ReadLine();
            string name2 = playerTwo.Name;

            // greet player 2
            Console.WriteLine($"Greetings {name2}!  Welcome to Noony's Tic Tac Toe Game!\n");

            // prompt user to begin game
            Console.WriteLine("Press any key to begin.");
            Console.ReadLine(); // get user input
            Console.Clear(); // clear screen

            // Step - initialize game
            TicTacToe.DisplayBoard(activeBoard.GameArray); // display game board

            // game plays until winning condition is met
            while (true)
            {
                // Step - prompt Player 1 for input on number selection
                Console.WriteLine($"{playerOne.Name} make your selection! (enter the corresponding digit and press enter)\n");

                // Step - get player's input and place marker on game board
                int input1 = Convert.ToInt32(Console.ReadLine());
                if (input1 >= 0 && input1 <= 8)
                {
                    try
                    {
                        switch (input1)
                        {
                            case 0:
                                activeBoard.GameArray.SetValue("O", 0, 0);
                                break;
                            case 1:
                                activeBoard.GameArray.SetValue("O", 0, 1);
                                break;
                            case 2:
                                activeBoard.GameArray.SetValue("O", 0, 2);
                                break;
                            case 3:
                                activeBoard.GameArray.SetValue("O", 1, 0);
                                break;
                            case 4:
                                activeBoard.GameArray.SetValue("O", 1, 1);
                                break;
                            case 5:
                                activeBoard.GameArray.SetValue("O", 1, 2);
                                break;
                            case 6:
                                activeBoard.GameArray.SetValue("O", 2, 0);
                                break;
                            case 7:
                                activeBoard.GameArray.SetValue("O", 2, 1);
                                break;
                            case 8:
                                activeBoard.GameArray.SetValue("O", 2, 2);
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e} error");
                    }
                    Console.Clear(); // clear the board
                    TicTacToe.DisplayBoard(activeBoard.GameArray); // update the board
                    TicTacToe.WinCheck(activeBoard.GameArray); // check for winning condition
                }
                else
                {
                    return;
                }

                // Step - prompt Player 2 for input on number selection
                Console.WriteLine($"{playerTwo.Name} make your selection! (enter the corresponding digit and press enter)\n");

                // Step - get player's input and place marker on game board
                int input2 = Convert.ToInt32(Console.ReadLine());
                if (input2 >= 0 && input2 <= 8)
                {
                    try
                    {
                        switch (input2)
                        {
                            case 0:
                                activeBoard.GameArray.SetValue("X", 0, 0);
                                break;
                            case 1:
                                activeBoard.GameArray.SetValue("X", 0, 1);
                                break;
                            case 2:
                                activeBoard.GameArray.SetValue("X", 0, 2);
                                break;
                            case 3:
                                activeBoard.GameArray.SetValue("X", 1, 0);
                                break;
                            case 4:
                                activeBoard.GameArray.SetValue("X", 1, 1);
                                break;
                            case 5:
                                activeBoard.GameArray.SetValue("X", 1, 2);
                                break;
                            case 6:
                                activeBoard.GameArray.SetValue("X", 2, 0);
                                break;
                            case 7:
                                activeBoard.GameArray.SetValue("X", 2, 1);
                                break;
                            case 8:
                                activeBoard.GameArray.SetValue("X", 2, 2);
                                break;
                            default:
                                break;
                        }
                        Console.Clear(); // clear the board
                        TicTacToe.DisplayBoard(activeBoard.GameArray); // update the board
                        TicTacToe.WinCheck(activeBoard.GameArray); // check for winning condition
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e} error");
                    }
                }
                else
                {
                    return;
                }
            } // end While(true)

        }
        /* 

                  

                      // Step - increment turnCount
                      turnCount++;

                      // Step - display game board


                      // Step - evaluate game conditions (continue or win)
                      WinCheck(currentArray);
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


                      // Step - evaluate game conditions (continue, win or draw)
                      WinCheck(activeBoard);

                  }

                  // Step - user 2 turn
                  // Step - announce winner and update score tally
                  // Step - ask users to play again (if no, exit game) (if yes, restart game)

                  // Step 10: exit or restart game
              }
        */
    }
}
