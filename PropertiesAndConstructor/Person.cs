using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructor
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address) : this(name, age)    
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }
        public Person()
        {
            
        }

    }
}
