using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._2023g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chisla: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //a
            Average(numbers);

            //b
            PrintAll(numbers);

            //v
            CountZeros(numbers);

            //d
            PrintNewRow(numbers);
        }

        private static void PrintNewRow(int[] numbers)
        {
            //g
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Chisloto {numbers[i]} se namira na index: {i}");
            }
        }

        private static void CountZeros(int[] numbers)
        {
            byte count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Broyat na 0 v masiva e: {count}");
        }

        private static void PrintAll(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Average(int[] numbers)
        {
            Console.WriteLine($"Avg = {(double)numbers.Average()}");
        }
    }
}
        
    

    


        
    

