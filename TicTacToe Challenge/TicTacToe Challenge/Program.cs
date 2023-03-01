using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setup the field
            string[] field = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool winState = false;
            int whichPlayer = 1;
            int roundCounter = 0;
            int playerResposeInInt;
            string playerResponse;
            const int MINIMUM_ROUND_TO_WIN = 5;
            const int DRAW_ROUND = 9;
            PrintingGameStatus();
            WhichPlayer();
            while (!winState)
            {
                //ask for a number
                playerResponse = Console.ReadLine();
                //if the player response is a number we convert it to int
                var isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                //checks if the input is a number and is it 1-9 and its already taken
                bool isCorrectResponse = false;
                while (!isCorrectResponse)
                {
                    if (!isNumeric)
                    {
                        Console.WriteLine("This is not a number!");
                        playerResponse = Console.ReadLine();
                        isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                    }
                    else if (playerResposeInInt < 1 || 9 < playerResposeInInt)
                    {
                        Console.WriteLine("This is not a valid number!");
                        playerResponse = Console.ReadLine();
                        isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                    }
                    else if (playerResponse != field[playerResposeInInt - 1])
                    {
                        Console.WriteLine("This field is already taken!");
                        playerResponse = Console.ReadLine();
                        isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                    }
                    else
                    {
                        isCorrectResponse = true;
                    }
                }
                //over write the field
                field[playerResposeInInt - 1] = whichPlayer == 1 ? "x" : "o";
                PrintingGameStatus();
                roundCounter++;
                if (roundCounter >= MINIMUM_ROUND_TO_WIN)
                {
                    if (whichPlayer == 1)
                    {
                        IsFirstPlayerWins();
                    }
                    else
                    {
                        IsSecondPlayerWins();
                    }
                }
                if (roundCounter == DRAW_ROUND)
                {
                    Console.WriteLine("Its a draw!");
                    winState = true;
                }
                if (winState)
                {
                    Console.WriteLine("Press enter to continue!");
                    Console.ReadKey();
                }
                else
                {
                    WhichPlayer();
                }
            }
            void WhichPlayer()
            {
                if (whichPlayer == 1)
                {
                    Console.WriteLine("\n Player 1 round! \n");
                    whichPlayer = 2;
                }
                else
                {
                    Console.WriteLine("\n Player 2 round! \n");
                    whichPlayer = 1;
                }
            }
            void PrintingGameStatus()
            {
                Console.WriteLine(" {0} | {1} | {2}", field[0], field[1], field[2]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {0} | {1} | {2}", field[3], field[4], field[5]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {0} | {1} | {2}", field[6], field[7], field[8]);
            }
            void IsFirstPlayerWins()
            {
                if (field[0] == "x" && field[1] == "x" & field[2] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[3] == "x" && field[4] == "x" & field[5] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[6] == "x" && field[7] == "x" & field[8] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[0] == "x" && field[3] == "x" & field[6] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[1] == "x" && field[4] == "x" & field[7] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[2] == "x" && field[5] == "x" & field[8] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[0] == "x" && field[4] == "x" & field[8] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
                else if (field[2] == "x" && field[4] == "x" & field[6] == "x")
                {
                    winState = true;
                    Console.WriteLine("First player wins!");
                }
            }
            void IsSecondPlayerWins()
            {
                if (field[0] == "o" && field[1] == "o" & field[2] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[3] == "o" && field[4] == "o" & field[5] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[6] == "o" && field[7] == "o" & field[8] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[0] == "o" && field[3] == "o" & field[6] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[1] == "o" && field[4] == "o" & field[7] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[2] == "o" && field[5] == "o" & field[8] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[0] == "o" && field[4] == "o" & field[8] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
                else if (field[2] == "o" && field[4] == "o" & field[6] == "o")
                {
                    winState = true;
                    Console.WriteLine("The second player wins!");
                }
            }
        }
    }
}
