using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>
            {
                new Group { Id = 1, Name = "27PPS11" },
                new Group { Id = 2, Name = "27PPS12" }
            };
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Miller", GroupId = 2 },
                new Student { FirstName = "Candice", LastName = "Leman", GroupId = 1 },
                new Student { FirstName = "Joey", LastName = "Finch", GroupId = 1 },
                new Student { FirstName = "Nicole", LastName = "Taylor", GroupId = 2 }
            };
            IEnumerable<Student> query = from g in groups
                                         join st in students on g.Id equals
                                         st.GroupId into res
                                         from r in res
                                         select r;
            WriteLine("\tStudents in groups:");
            foreach (Student item in query)
            {
                WriteLine($"Surname: {item.LastName}, Name: {item.FirstName}, Group:{groups.First(g => g.Id == item.GroupId).Name}");
            }
        }
    }
}