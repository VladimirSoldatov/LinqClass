using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Surname: {LastName}, Name: {FirstName}, Born: {BirthDate.ToLongDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const double daysOfYear = 365.25;
            List<Student> students = new List<Student> {
                new Student {
                FirstName = "John",
                LastName = "Miller",
                BirthDate = new DateTime(1997,3,12)
                },
                new Student {
                FirstName = "Candice",
                LastName = "Leman",
                BirthDate = new DateTime(1998,7,22)
                },
                new Student {
                FirstName = "Joey",
                LastName = "Finch",
                BirthDate = new DateTime(1996,11,30)
                },
                new Student {
                FirstName = "Nicole",
                LastName = "Taylor",
                BirthDate = new DateTime(1996,1,10)
                }
            };
            WriteLine($"\tThe current date:{DateTime.Now.ToLongDateString()}\n");
            // код остался прежним
            WriteLine($"\tThe current date:        { DateTime.Now.ToLongDateString()}\n");
            WriteLine($"\tThe youngest student:");
            var student = from s in students
                          where s.BirthDate ==
                          (from b in students
                           select b.BirthDate).Max()
                          select s;
            foreach (var item in student)
            {
                WriteLine(item);
            }
            WriteLine($"\tThe youngest student:");
            var minAge = (from s in students
                          select s).Min(s => (DateTime.Now -
                          s.BirthDate).Days / daysOfYear);

            WriteLine($"Age: {(int)minAge}");
        }
    }
}