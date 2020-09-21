using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Person
    {
        public string Name { get;}
        public byte Age { get; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, byte age) : this(name)
        {
            Name = name;
            Age = age;
        }

    }
}
