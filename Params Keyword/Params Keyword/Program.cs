using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price,pi,at,book);
            ParamsMethod2("Hello",5.3,'$');
            ParamsMethod();
        }
        public static void ParamsMethod(params string[] sentence) 
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
        public static void ParamsMethod2(params object[] stuff)
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
