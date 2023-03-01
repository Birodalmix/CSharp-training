using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 1, 5, 3, 4, 1, 1, 1, 4, 3, 5 };
            double averageResult = GetAverage(studentsGrades);
            foreach (var grade in studentsGrades)
            {
                Console.WriteLine(grade);
            } 
            Console.WriteLine("The average is: {0}!",averageResult);
            Console.ReadKey();
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
