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
            return $"Surname: {LastName}, Name: {FirstName}, Born: { BirthDate.ToLongDateString()}";
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
            WriteLine($"\tThe current date: { DateTime.Now.ToLongDateString()}\n");
            var query = from s in students
            where (DateTime.Now - s.BirthDate).Days / daysOfYear > 20
            select s;
            WriteLine("\tStudents older than 20 years:");
            foreach (var item in query)
            {
                WriteLine(item);
            }
            // код остался прежним
            WriteLine($"\tThe current date: { DateTime.Now.ToLongDateString()}\n");
            var query1 = students.Where(s => (DateTime.Now - s.BirthDate).Days / daysOfYear > 20).Select(s => s);
            WriteLine("\tStudents older than 20 years:");
            foreach (var item in query1)
            {
                WriteLine(item);
            }
        }
    }
}