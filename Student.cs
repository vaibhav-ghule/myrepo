using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1StudentListStudent
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Class { get; set; }


        public string DisplayStudent()
        {
            return "Id=" + this.Id + "   name=" + this.Name + "   age=" + this.Age;
        }

        public IEnumerable<Student> SearchByName(List<Student> students)
        {
            Console.WriteLine("enter the student name which info you want:");
            string name = Console.ReadLine();
            var value = from s in students
                        where s.Name == name
                        select s;

            return value;
        }

        public IEnumerable<Student> SortByName(List<Student> students)
        {
            var result = from std in students
                         orderby std.Name ,
                         std.Age
                         select std;
            return result;
        }

    }
}
