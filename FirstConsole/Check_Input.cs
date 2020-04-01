using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    class Check_Input
    {
        private int _length_circle; //Поле длинны окружности
        public int Length_Circle 
        {
            get { 
                    return _length_circle; 
                }
            set {
                if (value > 0)
                    {
                    _length_circle = value;
                    }
                else
                    {
                    _length_circle = 69;
                    }
                }
        }
    }
}
