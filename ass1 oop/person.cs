using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_oop
{
    internal struct Person
    {
        public string Name;
        public int Age;

        // Constructor to initialize the Person struct
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
