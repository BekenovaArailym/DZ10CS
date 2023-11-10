using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonL
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Возрост: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return Name == otherPerson.Name && Age == otherPerson.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0) ^ Age;
        }

        public static Person RandomPerson(List<Person> people)
        {
            Random random = new Random();
            int randomIndex = random.Next(people.Count);
            return people[randomIndex];
        }
    }
}
