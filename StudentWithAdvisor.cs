using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherL;
using PersonL;

namespace StudentWithAdvisorL
{
    public class StudentWithAdvisor : Person
    {
        public Teacher Teacher { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Teacher name: {Teacher.Name}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Teacher name: {Teacher.Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is StudentWithAdvisor otherStudent)
            {
                return base.Equals(obj) && Teacher.Equals(otherStudent.Teacher);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Teacher.GetHashCode();
        }
    }
}
