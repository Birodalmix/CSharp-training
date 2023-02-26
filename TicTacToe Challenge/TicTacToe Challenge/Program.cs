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
            while (!winState)
            {
                PrintingGameStatus();
                WichPlayer();
                playerResponse = Console.ReadLine();
                switch (playerResponse)
                {
                    case "1":
                        
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("This is number 4!");
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        Console.WriteLine("This is number 7!");
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    default:
                        Console.WriteLine("This is not a number!");
                        break;
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
