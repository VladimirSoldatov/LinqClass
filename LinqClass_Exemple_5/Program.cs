using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 31, 22, 5, 17, 22, 8, 9, 55, 4, 44, 7 };
            IEnumerable<IGrouping<int, int>> query =
                                     from i in arrayInt
                                     group i % 10 by i;
            foreach (IGrouping<int, int> item in query)
            {
                Console.WriteLine($"{item.Key}\t");
            }
            Console.WriteLine();
            int a, b;
            Console.WriteLine("Enter index,and new value");
            (a, b) = (Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            arrayInt[a] = b;
            foreach (IGrouping<int, int> item in query)
            {
                Console.Write($"{item.Key}\t ");
            }
            Console.WriteLine();
        }
    }
}
