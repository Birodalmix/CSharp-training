using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[3][];

            friends[0] = new string[2] { "Erik", "Martha" };
            friends[1] = new string[2] { "Jack", "Naomi" };
            friends[2] = new string[2] { "David", "Barb" };

            Console.WriteLine("Hi we are {0} and {1}. Nice to meets you {2} and {3}!", friends[0][0], friends[0][1], friends[1][0], friends[1][1]);
            Console.WriteLine("Hi we are {0} and {1}. Nice to meets you {2} and {3}!", friends[1][0], friends[1][1], friends[2][0], friends[2][1]);
            Console.WriteLine("Hi we are {0} and {1}. Nice to meets you {2} and {3}!", friends[0][0], friends[0][1], friends[2][0], friends[2][1]);
            Console.ReadKey();
            }
    }
}
