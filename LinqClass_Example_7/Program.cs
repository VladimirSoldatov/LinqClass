using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };
            IEnumerable<IGrouping<int, int>> query =
            from i in arrayInt
            group i by i % 10 into res
            where res.Count() > 1
            select res;
            WriteLine("Groups with the number of elements is greater than 1:");
            foreach (IGrouping<int, int> key in query)
            {
                Write($"Key: {key.Key}\nValue:");
                foreach (int item in key)
                {
                    Write($"\t{item}");
                }
                WriteLine();
            }
        }
    }
}