using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PersonL;

namespace StudentL
{
    public class Student : Person
    {
        public int Course { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Course: {Course}";
        }

        public static Student RandomStudent(List<Student> students)
        {
            Random random = new Random();
            int randomIndex = random.Next(students.Count);
            return students[randomIndex];
        }
    }
}
