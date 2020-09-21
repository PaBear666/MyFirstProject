using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Doctor <T> : Person
    {
        private T number;

        public T Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value.ToString().Length > 10)
                {
                    throw new ArgumentException();
                }
                number = value;
            }

        }

        public Doctor(string name, byte age,T number) : base(name,age)
        {
            Number = number;
        }
    }
}
