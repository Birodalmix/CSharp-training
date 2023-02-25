using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {   //declare 2D array 
            string[,] matrix;
            //3D array
            int[,,] threeD;
            // two dimensional array
            int[,] array2D = new int[,]
                {
                    {1,2,3},// row 0
                    {4,5,6},// row 1
                    {7,8,9} // row 2
                };
            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.ReadKey();

            string[,,] array3D = new string[,,]
                {
                    {
                        {"000","001","002"},
                        {"010","011","012"}
                    },
                    {
                        {"100","101","102"},
                        {"110","111","112"}
                    }
                };
            Console.WriteLine("Central value is {0}", array3D[0, 1, 1]);
            Console.ReadKey();

            string[,] array2dString = new string[3, 2]
                {
                    {"one","two"},
                    {"three","four"},
                    { "five","six"}
                };
            array2dString[1, 1]="chicken";
            Console.WriteLine("The Value is {0}",array2dString[1,1]);
            Console.ReadKey();

            //Get back the amount of dimensions
            int dimensions = array2dString.Rank;
            Console.WriteLine(dimensions);
            Console.ReadKey();
            //Another type of declaration
            int[,] array2dr = { {1,2},{1,2} };
        }
    }
}
