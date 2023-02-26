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
            string[] field = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool winState = false;
            int wichPlayer = 1;
            string playerResponse;
            PrintingGameStatus();
            WichPlayer();
            while (!winState)
            {
                playerResponse = Console.ReadLine();
                int playerResposeInInt;
                var isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                //biztosan szám-e az adott karakter
                while (!isNumeric || (playerResposeInInt < 1 || 9 < playerResposeInInt) || (playerResponse != field[playerResposeInInt-1])) 
                {
                    if (!isNumeric)
                    {
                        Console.WriteLine("This is not a number!");
                    }
                    else if (playerResposeInInt < 1 || 9 < playerResposeInInt)
                    {
                        Console.WriteLine("This is not a valid number!");
                    }
                    else if (playerResponse != field[playerResposeInInt-1])
                    {
                        Console.WriteLine("This field is already taken!");
                    }
                    playerResponse = Console.ReadLine();
                    isNumeric = int.TryParse(playerResponse, out playerResposeInInt);
                }
                switch (playerResponse)
                {
                    case "1":
                        if (wichPlayer == 1)
                        {
                            field[0] = "x";
                        }
                        else 
                        {
                            field[0] = "o";
                        }
                        break;
                    case "2":
                        if (wichPlayer == 1)
                        {
                            field[1] = "x";
                        }
                        else
                        {
                            field[1] = "o";
                        }
                        break;
                    case "3":
                        if (wichPlayer == 1)
                        {
                            field[2] = "x";
                        }
                        else
                        {
                            field[2] = "o";
                        }
                        break;
                    case "4":
                        if (wichPlayer == 1)
                        {
                            field[3] = "x";
                        }
                        else
                        {
                            field[3] = "o";
                        }
                        break;
                    case "5":
                        if (wichPlayer == 1)
                        {
                            field[4] = "x";
                        }
                        else
                        {
                            field[4] = "o";
                        }
                        break;
                    case "6":
                        if (wichPlayer == 1)
                        {
                            field[5] = "x";
                        }
                        else
                        {
                            field[5] = "o";
                        }
                        break;
                    case "7":
                        if (wichPlayer == 1)
                        {
                            field[6] = "x";
                        }
                        else
                        {
                            field[6] = "o";
                        }
                        break;
                    case "8":
                        if (wichPlayer == 1)
                        {
                            field[7] = "x";
                        }
                        else
                        {
                            field[7] = "o";
                        }
                        break;
                    case "9":
                        if (wichPlayer == 1)
                        {
                            field[8] = "x";
                        }
                        else
                        {
                            field[8] = "o";
                        }
                        break;
                    default:
                        Console.WriteLine("This is not a number!");
                        break;
                }
                PrintingGameStatus();
                WichPlayer();
                //the first player wins
                if (field[0]=="x" && field[1]=="x" & field[2] =="x")
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
                //the second player wins
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
                if (winState)
                {
                    Console.ReadKey();
                }
            }
            void WichPlayer() 
            {
                if (wichPlayer == 1)
                {
                    Console.WriteLine("\n Player 1 round! \n");
                    wichPlayer = 2;
                }
                else
                {
                    Console.WriteLine("\n Player2 round! \n");
                    wichPlayer = 1;
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
        }
    }
}
