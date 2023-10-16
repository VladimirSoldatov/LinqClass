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
            IEnumerable<int> query = from i in arrayInt select i;// from Linq
            foreach(int item in query)
            {
                Console.Write($"{item}\t ");
            }
            Console.WriteLine();
            int index, new_value;
            Console.WriteLine("Enter index,and new value");
            (index, new_value) = (Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()));
            arrayInt[index] = new_value;
            foreach (int item in query)
            {
                Console.Write($"{item}\t ");
            }
            Console.WriteLine();
        }
    }
}
