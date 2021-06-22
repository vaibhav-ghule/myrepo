using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1StudentListStudent;

namespace ConsoleApp1StudentList
{
     
    class Program
    {

        static void Main(string[] args)
        {

            int id;
            string name;
            int age;
            int choise;
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "vaibhav", Age = 21 },
                new Student(){ Id = 2, Name = "kishore", Age = 35 },
                new Student(){ Id = 3, Name = "yogesh", Age = 31 },
                new Student(){ Id = 4, Name = "kiran", Age = 25 },
                new Student(){ Id = 5, Name = "alok", Age = 23 },

            };
            do
            {
                Console.WriteLine("Enter which operation you want on student data:");
                Console.WriteLine("1 : Add new student data");
                Console.WriteLine("2 : Display All students data");
                Console.WriteLine("3 : Serarch student by its name:");
                Console.WriteLine("4 : Sort students by name:");
                Console.WriteLine("0 : Exit");
                        choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    ////////////////////////////ADD NEW OBJECT OF STUDENT//////////////////
                    case 1:
                        {
                            Console.WriteLine("Enter student id name and age:");
                            id = Convert.ToInt32(Console.ReadLine());
                            name = Console.ReadLine();
                            age = Convert.ToInt32(Console.ReadLine());
                            students.Add(new Student() { Id = id, Name = name, Age = age });
                            break;
                        }
                    /////////////////////DISPLAY ALL////////////////////////////////
                    case 2:
                        {
                            foreach (Student std in students)
                            {
                                Console.WriteLine(std.DisplayStudent());
                            }
                            break;
                        }
                    ////////////===========search by name==============////////////
                    case 3:
                        {
                            Student std1 = new Student();
                            var foundStudents = std1.SearchByName(students);
                            foreach (var student in foundStudents)
                                Console.WriteLine(" The student having name:  " + student.Name + "  has id=" + student.Id + " and age=" + student.Age);
                            break;
                        }
                    case 4:
                        {
                            Student ss = new Student();
                            IEnumerable<Student> result = ss.SortByName(students);
                            Console.WriteLine("Students lis in sorted order: ");
                            foreach( var s in result)
                                Console.WriteLine( " has id=" + s.Id + "Name:"+s.Name+" and age=" + s.Age);
                            break;
                        }
                }
            } while (choise != 0);
            Console.ReadLine();
            
        }
        
    }
}
