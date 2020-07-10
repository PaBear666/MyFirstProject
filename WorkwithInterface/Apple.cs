using System;
using System.Collections.Generic;
using System.Text;

namespace WorkwithInterface
{
    class Apple : IFood
    {
        public string Name
        {
            get
            {
                return "Apple";
            }
        }

        public int Time
        {
            get
            {
                return 300;
            }
        }

        public int Calories 
        { 
            get 
            { 
                return 300; 
            } 
        }

        public bool Permisson(int calories)
        {
            return (calories - Calories) > 0 ? true : false;
        }
    }
}
