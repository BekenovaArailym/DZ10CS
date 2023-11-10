using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentL;
using PersonL;
using TeacherL;
using StudentWithAdvisorL;

namespace DZ10CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { Name = "Эрик", Age = 26 };
            var person2 = new Person { Name = "Нурмухаммед", Age = 24 };

            List<Person> people = new List<Person>
            {
                new Person { Name = "Айсултан", Age = 32 },
                new Person { Name = "Айрис", Age = 22 },
                new Person { Name = "Нэнси", Age = 26 }
            };

            Console.WriteLine("Person1 name:");
            person1.Print();
            Console.WriteLine("person1 equals person2: " + person1.Equals(person2));
            Console.WriteLine();

            Console.WriteLine("Person2 name:");
            person2.Print();
            Console.WriteLine("person2 GetHashCode: " + person2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Random Person name: " + Person.RandomPerson(people));
            Console.WriteLine();


            var teacher1 = new Teacher { Name = "Учитель Нэнси", Age = 35, Students = new List<Student>() };
            var teacher2 = new Teacher { Name = "Учитель Айлан", Age = 36, Students = new List<Student>() };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Name = "Айсултан", Age = 32, Students = new List<Student>()  },
                new Teacher { Name = "Айрис", Age = 22, Students = new List<Student>() },
                new Teacher { Name = "Нэнси", Age = 26, Students = new List<Student>()  }
            };

            var student1 = new Student { Name = "Айлана", Age = 21, Course = 3 };
            var student2 = new Student { Name = "Жан", Age = 22, Course = 4 };
            var student3 = new Student { Name = "Алихан", Age = 18, Course = 2 };

            List<Student> students = new List<Student>
            {
                new Student { Name = "Микаса", Age = 21, Course = 3 },
                new Student { Name = "Ерлан", Age = 21, Course = 3 },
                new Student { Name = "Айсулу", Age = 21, Course = 3 }
            };

            var st1 = new StudentWithAdvisor { Teacher = teacher1 };
            var st2 = new StudentWithAdvisor { Teacher = teacher1 };
            var st3 = new StudentWithAdvisor { Teacher = teacher2 };

            teacher1.Students.Add(student1);
            teacher1.Students.Add(student2);
            teacher2.Students.Add(student3);

            Console.WriteLine("Teacher name:");
            teacher1.Print();
            Console.WriteLine("teacher1 equals teacher2: " + teacher1.Equals(teacher2));
            Console.WriteLine("teacher2 GetHashCode: " + teacher2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Random Teacher: " + Teacher.RandomTeacher(teachers));
            Console.WriteLine();

            Console.WriteLine("Student1 name:");
            student1.Print();
            st1.Print();
            Console.WriteLine("student1 equals student2: " + st1.Equals(st2));
            Console.WriteLine("student2 GetHashCode: " + st2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Student2 name:");
            student2.Print();
            st2.Print();
            Console.WriteLine("Random Student name: " + Student.RandomStudent(students));
            Console.WriteLine();
            object[] peopleArray = new object[]
            {
                new Person { Name = "Айсултан", Age = 32 },
                new Student { Name = "Айрис", Age = 22, Course = 2},
                new Teacher { Name = "Нэнси", Age = 26 },
                new Student { Name = "Нуржан", Age = 21, Course = 3}
            };
            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;
            for (int i = 0; i < peopleArray.Length; i++)
            {
                if (peopleArray[i] is Person)
                {
                    personCount++;
                }
                if (peopleArray[i] is Student)
                {
                    studentCount++;
                    Student student = peopleArray[i] as Student;
                    student.Course++;
                    peopleArray[i] = student;
                    Console.WriteLine("Student name: " + peopleArray[i]);
                }
                if (peopleArray[i] is Teacher)
                {
                    teacherCount++;
                }
            }
            Console.WriteLine($"Quantity Person: {personCount}");
            Console.WriteLine($"Quantity Students: {studentCount}");
            Console.WriteLine($"Quantity Teachers: {teacherCount}");
        }
    }
}
