using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingApplication
{
    internal class Program
    {
        //meg kell adni egy személyszámot majd választani a lehetőségek közül
        static void Main(string[] args)
        {
            bool quit = false;
            const int FIRST_PARTY = 1;
            const int LAST_PARTY = 5;
            while (!quit)
            {
                Console.WriteLine("Please write your Personal ID number!");
                string personalID = Console.ReadLine();
                Quiting(personalID);
                int voterIDInInt;
                var isNumeric = int.TryParse(personalID, out voterIDInInt);
                bool isIdValid = false;
                while (!isIdValid)
                {
                    if (!isNumeric)
                    {
                        Console.WriteLine("This Id is not a valid number!");
                        personalID = Console.ReadLine();
                        isNumeric = int.TryParse(personalID, out voterIDInInt);
                    }
                    else
                    {
                        Console.WriteLine("Thanks!");
                        isIdValid = true;
                    }
                }
                Console.WriteLine("Please choose one above!\n1.Neo Privilege Party\n2.Southern Uniformity Party\n3.Patriotic Working Class Party\n4.Fanatical Coalition Movement\n5.National Taxpayer League");
                string choosedOption = Console.ReadLine();
                Quiting(choosedOption);
                int voteInInt;
                var isVoteNumeric = int.TryParse(choosedOption, out voteInInt);
                bool isVoteValid = false;
                while (!isVoteValid)
                {
                    if (!isVoteNumeric)
                    {
                        Console.WriteLine("This vote is not valid!");
                        choosedOption = Console.ReadLine();
                        isVoteNumeric = int.TryParse(choosedOption, out voteInInt);
                    }
                    else if (voteInInt<FIRST_PARTY || voteInInt>LAST_PARTY)
                    {
                        Console.WriteLine("This vote is not in a valid range!");
                        choosedOption = Console.ReadLine();
                        isVoteNumeric = int.TryParse(choosedOption, out voteInInt);
                    }
                    else
                    {
                        Console.WriteLine("Thanks! Press Enter to quit!");
                        Console.ReadKey();
                        isVoteValid = true;
                    }
                }
                quit = true;
            }
            void Quiting(string quiting)
            {
                if (quiting == "quit")
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
