using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 2, 5, 7, 8, 9, 55, 4, 4, 7 };
            IEnumerable<int> query = from i in arrayInt 
                                     where i % 2 == 0 
                                     select i;
            foreach (int item in query)
            {
                Console.Write($"{item}\t ");
            }
            Console.WriteLine();
            int a, b;
            Console.WriteLine("Enter index,and new value");
            (a, b) = (Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            arrayInt[a] = b;
            foreach (int item in query)
            {
                Console.Write($"{item}\t ");
            }
            Console.WriteLine();
        }
    }
}
