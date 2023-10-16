using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LinqClass_Example_14
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int GroupId { get; set; }
            public int pol { get; set; }
              
        }
        class Groups
        {
            public int Id { get; set; }
            public string GropeName { get; set; }
        }
        class Pol
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student {
                Name = "John",
                GroupId = 1,
                pol = 1
                },
                new Student {
                Name = "Candice",
                GroupId = 2,
                pol =2
                },
                new Student {
                Name = "Joey",
                GroupId = 1,
                pol = 1
                },
                new Student {
                Name = "Nicole",
                GroupId =1, pol=2
                }
            };
            Groups[] groups = new Groups[] { new Groups { Id = 1, GropeName = "12343" }, new Groups { Id = 2, GropeName = "128783" } };
            Pol[] pol = new Pol[] { new Pol { Id = 1, Name = "Мужской" }, new Pol { Id = 2, Name = "Женский" } };
            var join1 = (from st in students
                         join gr in groups on st.GroupId equals gr.Id

                         select new
                         {
                             Name = st.Name,
                             GroupName = gr.GropeName,
                             pol = st.pol
                         }).ToList().Join(pol, c => c.pol, p => p.Id, (c, p) => new { Name = c.Name, GroupName = c.GroupName, Sex = p.Name });
                     

            foreach(var item in join1)
            {
                Console.WriteLine(item);
            }







                        }
    }
}
