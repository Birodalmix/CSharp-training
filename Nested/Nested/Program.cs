using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nested
{
    internal class Program
    {
        static int[,] matrix =
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
        };
        static void Main(string[] args)
        {
            //Printing all item in the matrix with foreach
            foreach (var item in matrix)
            {
                Console.Write(item+" ");
                Console.WriteLine("\n");
            }
            //Printing all item with nested for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2==0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    } 
                }
            }
        }
    }
}
