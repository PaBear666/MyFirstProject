using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Globalization;
using System.Net.Sockets;

namespace Testing
{

    public static class Kata
    {
        static public void Main()
        {
            Console.WriteLine(Kata.Persistence(39));
        }
        public static string AddBinary(int a, int b)
            {
            return Recurse(a + b);

            }
        public static string Recurse(int c)
            {
                string str;
                if(c == 0 || c == 1)
                {
                    if(c == 0)
                    {
                        str = "0";
                        
                    }
                    else
                    {
                        str = "1";
                    }
                    return str;
                }
                else
                {
                    str = Recurse(c % 2);
                    str = Recurse(c / 2) + str;
                return str;
                }

            }
        public static string Tickets(int[] peopleInLine)
        {
            int a = 0;
            int b = 0;
            bool con = peopleInLine[0] == 25 ? true : false; 
            int i = 0;
            while ((i < peopleInLine.Length) && con)
            {
                switch (peopleInLine[i]) 
                {
                    case 25:
                        a = a + 1;
                        i++;
                        break;
                    case 50:
                        if(a > 0)
                        {
                            a = a - 1;
                            b = b + 1;
                            i++;
                        }
                        else
                        {
                            con = false;
                        }
                        break;
                    case 100:
                        if ((a > 0 && b > 0) || a > 3  || b > 2)
                        {
                            if (a > 0 && b > 0)
                            {
                                b -= 1;
                                a -= 1;
                                i++;
                            }
                            else if (b > 2)
                            {
                                b = b - 2;
                                i++;
                            }else if(a > 3)
                                {
                                a = a - 3;
                                i++;
                                }
                        }
                        else
                        {
                            con = false;
                        }
                        break;
                }
            }
            if(i == peopleInLine.Length && con)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
           
        }
        public static string DuplicateEncode(string word)
        {
            string newword = word.ToLower();
            bool check;
            char[] letter = new char[word.Length];
            string wordreturn = null;
            for(int i = 0;i < (newword.Length - 1); i++)
            {
                for(int j = i + 1;j < newword.Length; j++)
                {
                    if(newword[i] == newword[j])
                    {
                        letter[i] = newword[i];
                        break;
                    }
                }  
            }
            for(int i = 0;i < newword.Length; i++)
            {
                check = true;
                for(int j = 0;j < letter.Length; j++)
                {
                    if(newword[i] == letter[j])
                    {
                        wordreturn = wordreturn + ")";
                        check = false;
                        break;       
                    }
                }
                if(check)
                {
                    wordreturn = wordreturn + "(";
                }

            }
            return wordreturn;
        }
        public static int DigitalRoot(long n)
        {
            long sum = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                sum = n.ToString()[i] - '0' + sum;
            }
            if (n.ToString().Length != 1)
            {
                sum = (long)DigitalRoot(sum);
            }
            return (int)sum;
        }
        public static string Rgb(params long[] rgb)
        {
            for (int i = 0; i < rgb.Length; i++)
            { if (rgb[i] > 255)
                    rgb[i] = 255;
                if (rgb[i] < 0)
                    rgb[i] = 0;
            }
            string str = null;
            for (int i = 0; i < 3; i++)
                if (rgb[i] != 00)
                    if(Convert.ToString(rgb[i], 16).Length == 2)
                    str += Convert.ToString(rgb[i], 16).ToUpper();
                    else
                    str += '0' + Convert.ToString(rgb[i], 16).ToUpper();
                else
                    str += "00";
                
            return str;
        }
        public static string GoodVsEvil(string good, string evil)
        {
            byte[] goodUnits = { 1, 2, 3, 3, 4, 10 };
            byte[] evilUnits = { 1, 2, 2, 2, 3, 5, 10 };
            string[] arrayGood = good.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] arrayEvil = evil.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int goodInt = 0;
            int evilInt = 0;
            for (int i = 0; i < goodUnits.Length; i++)
                goodInt += goodUnits[i] * int.Parse(arrayGood[i]);
            for (int j = 0; j < evilUnits.Length; j++)
                evilInt += evilUnits[j] * int.Parse(arrayEvil[j]);
            if (goodInt > evilInt)
                return "Battle Result: Good triumphs over Evil";
            else if (goodInt < evilInt)
                return "Battle Result: Evil eradicates all trace of Good";
            else
                return "Battle Result: No victor on this battle field";




        }
        public static (int, int)? IsPerfectPower(int n)
        {
            int i = 2;
            while(i < 100000 && Math.Round(Math.Log(n,i),4) % 1 != 0 )
                i++;
            if (i < 100 && (int)Math.Log(n,i) > 1)
              return (i, (int)Math.Round(Math.Log(n, i), 1));
              else
              return null;
        }
        public static string FirstNonRepeatingLetter(string s)
        {
            string str = s.ToUpper();
            if (s.Length != 1)
            {
                int i = 0;
                while(i < str.Length && str.IndexOf(str[i],i + 1) != -1)
                {
                    str = str.Remove(str.IndexOf(str[i],i+1),1);
                    if (str.IndexOf(str[i], i + 1) == -1)
                        i++;
                }
                if (i == str.Length)
                {
                    return "";
                }
                else
                {
                    int j = 0;
                    while (str[i] != char.ToLower(s[j]) && str[i] != char.ToUpper(s[j]) )
                    {
                        j++;
                    }
                    return s[j].ToString();
                }
            }
            else
            {
                return s.Substring(0, 1);
            }
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int length = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Array.IndexOf(b, a[i]) == -1)
                {
                    length++;
                }
            }
            int[] array = new int[length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Array.IndexOf(b, a[i]) == -1)
                {
                    array[j] = a[i];
                    j++;
                }
            }
            return array;
        }
        public static int Persistence(long n)
        {

            int value;
            if (n.ToString().Length != 1)
            {
                long num = 1;
                for (int i = 0; i < n.ToString().Length; i++)
                {
                    num = (n.ToString()[i] - '0') * num;
                }
                
                value = num == n? Persistence(num) + 1 : Persistence(num);
            }
            else
            {
                value = 1;
            }
            return value;

        }


    }

}