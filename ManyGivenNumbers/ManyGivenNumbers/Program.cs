using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyGivenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimum = MinNumb(6,54,-2,5658,200,1,8,5);
            Console.WriteLine("The minimum is: " + minimum);
        }
        public static int MinNumb(params int[] numbers)
        {
            int minimum = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < minimum)
                {
                    minimum = number;
                }
            }
            return minimum;
        }
    }
}
