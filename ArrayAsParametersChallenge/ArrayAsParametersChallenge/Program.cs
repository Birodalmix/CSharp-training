using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAsParametersChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = { 5, 12, 10, 8, 4 };
            SunIsShining(happiness);
            foreach (var item in happiness)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
        static void SunIsShining(int[] increaseble)
        {
            for (int i = 0; i < increaseble.Length; i++)
            {
                increaseble[i] += 2;
            }
        }
    }
}
