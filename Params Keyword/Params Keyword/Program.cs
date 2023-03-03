using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("price is {0}, pi is {1} at is {2}",32 ,3.1415,'@');
            Console.WriteLine();
            Console.ReadKey();
            ParamsMethod("this","is","a","no","idea","lol","what");
        }
        public static void ParamsMethod(params string[] sentence) 
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
        public static void ParamsMethod2(params string[] stuff)
        {
            //for each loop to go through the array of objects
            foreach (object obj in stuff)
            {
                //print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
