using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Non_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //undefined amount of object
            ArrayList myArrayList = new ArrayList();
            //defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello0");
            myArrayList.Add(13.78);
            myArrayList.Add(1233);
            myArrayList.Add(-236);
            myArrayList.Add(143);

            //delete element with specific value from the arraylist
            myArrayList.Remove(13.78);

            //delete element at specific position
            myArrayList.RemoveAt(0);

            //list how many items we have
            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                } 
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
