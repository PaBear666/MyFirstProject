using System;
using LinkedListString;
namespace Testing
{

    public static class Kata
    {
        static public void Main()
        {
            Console.WriteLine(DigitalRoot(543));
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
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] ap = new int[a.Length];
            int value = a.Length;
            for(int i = 0;i < b.Length; i++)
            {
                int k = 0;
                for (int j = 0;j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        value -= 1;
                        
                    }
                    else
                    {
                        ap[k] = a[j];
                        k++;
                    }

                }
            }
            int[] array = new int[value];
            for(int i = 0;i < value; i++)
            {
                array[i] = ap[i];
            }
            return array;
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
    }

}