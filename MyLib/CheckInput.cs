using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    static public class CheckInput
    {
        static public bool CheckStr(string str)
        {
            int i = default;
            while(i < str.Length && ((Char.ToLower(str[i]) > 'a' && Char.ToLower(str[i]) < 'z') || Char.ToLower(str[i]) > 'а' && Char.ToLower(str[i]) < 'я'))
            {
                i++;
            }
            return i == str.Length;
        } 
    }
}
