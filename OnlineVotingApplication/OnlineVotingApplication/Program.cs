using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingApplication
{
    internal class Program
    {
        //Vedd fel a pártokat objektumonként
        //mentsd el a szavazót és a szavazatot majd ellenőrizd hogy szavaztak-e már ezzel a személyi számmal
        //a végén írd ki hogy mennyi lett a szvazatok száma pártonként

        static void Main(string[] args)
        {
            Partys[] PoliticalParty = new Partys[5];
            PoliticalParty[0] = new Partys(1, "Neo Privilege Party", 0);
            PoliticalParty[1] = new Partys(2, "Southern Uniformity Party", 0);
            PoliticalParty[2] = new Partys(3, "Patriotic Working Class Party", 0);
            PoliticalParty[3] = new Partys(4, "Fanatical Coalition Movement", 0);
            PoliticalParty[4] = new Partys(5, "National Taxpayer League", 0);
            ArrayList usedPersonalIds = new ArrayList();
            bool quit = false;
            const int FIRST_PARTY = 1;
            const int LAST_PARTY = 5;
            const int PERSONAL_ID_LENGHT = 8;
            while (!quit)
            {
                Console.WriteLine("Please write your Personal ID number!");
                string personalID = Console.ReadLine();
                Quiting(personalID);
                Votes(personalID);
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
                    else if (voterIDInInt != PERSONAL_ID_LENGHT)
                    {
                        Console.WriteLine("This Id not has a valid number lenght!");
                        personalID = Console.ReadLine();
                        isNumeric = int.TryParse(personalID, out voterIDInInt);
                    }
                    else
                    {
                        foreach (int id in usedPersonalIds)
                        {
                            if (id == voterIDInInt)
                            {
                                Console.WriteLine("You are already voted!");
                            }
                        }
                    }
                    Console.WriteLine("Thanks!");
                    isIdValid = true;
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
                    else if (voteInInt < FIRST_PARTY || voteInInt > LAST_PARTY)
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
            void Votes(string votes)
            {
                if (votes == "votes")
                {
                    foreach (object vote in PoliticalParty)
                    {
                        //pörgesd ki a tömböt
                        Console.WriteLine(vote);
                    }
                }
            }
        }

    }
    class Partys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Votes { get; set; }
        public Partys(int id, string name, int votes)
        {
            this.Id = id;
            this.Name = name;
            this.Votes = votes;
        }
    }
}
