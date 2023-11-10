using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonL;
using StudentL;

namespace TeacherL
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }

        public override void Print()
        {
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public override string ToString()
        {
            var studentList = string.Join(", ", Students);
            return base.ToString() + $", Students: [{studentList}]";
        }

        public override bool Equals(object obj)
        {
            if (obj is Teacher otherTeacher)
            {
                return base.Equals(obj) && Students.Count == otherTeacher.Students.Count;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Students.Count;
        }

        public static Teacher RandomTeacher(List<Teacher> teachers)
        {
            Random random = new Random();
            int randomIndex = random.Next(teachers.Count);
            return teachers[randomIndex];
        }
    }
}
