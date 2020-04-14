using System;

namespace TypeValueHW
{
    class Person           //Correct
    {
        public string Fio { get; set; }
        public long Number { get; set; }
        public Person(string fio,long number)
        {
            Fio = fio;
            Number = number;

        }
    }
    class Page
    {
        public Person[] Persons { get; set; }
        public char Letter { get; set; }
        public Page(char letter)
        {
            Letter = letter;
            Persons = new Person[10];
        }

    }
    class Book
    {
        public char[] Alp { get; set; } = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'J', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public Page[] Pages { get; set; }
        public Book()
        {
            Pages = new Page[26];
        }       
    }
    
    class Program
    {

        
        static void Main(string[] args)
        {
            
            
            Person[] pr = {
            new Person("Vasilya", 89297170191),
            new Person("Valera", 89297170192),
            new Person("Alpha", 89297170193),
            new Person("Zoy", 89297170194) };
       
            Book book = new Book();
            Distribution(ref book, pr);
            Menu(ref book);

        }
        
        static void Menu(ref Book book)
        {
            Console.WriteLine("1-Узнать номер");
            Console.WriteLine("2-Страницы на букву");
            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Show_Number(book); 
                    break;
                case 2: Show_Page(book);
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
        }
        static void Show_Number(Book book)
        {
            Console.WriteLine("Введите фамилию человека");
            string letter = Console.ReadLine();
            Console.WriteLine("Номер:" + book.Pages[Alp_Value(letter)].Persons[Show_Person(letter, book)].Number);
            
        }
        static void Show_Page(Book book)
        {
            Console.WriteLine("Введите букву");
            string letter = Console.ReadLine();
            int i = 0;
        while(i < book.Pages[Alp_Value(letter)].Persons.Length )
            {
                try
                {
                    Console.Write("Имя:" + book.Pages[Alp_Value(letter)].Persons[i].Fio + " ");
                    Console.Write("Телефон:" + book.Pages[Alp_Value(letter)].Persons[i].Number + " ");
                    Console.WriteLine();
                    i++;
                }
                catch
                {
                    Console.WriteLine("===");
                    break;
                }
            }
        }
        static void Distribution(ref Book book, Person[] pr)
        {
            for (int i = 0; i < book.Alp.Length; i++)
            {
                book.Pages[i] = new Page(book.Alp[i]);
                int k = 0;
                for (int j = 0; j < pr.Length; j++)
                {
                    if (book.Pages[i].Letter == pr[j].Fio[0])
                    {
                        book.Pages[i].Persons[k] = new Person(pr[j].Fio, pr[j].Number);
                        k++;
                    }
                }
            }
        }
        static int Alp_Value(string a)
        { 
            Book book = new Book();
            int value; int i = 0;
            while (!(a[0] == book.Alp[i]))
            {
                i++;
            }
            value = i;
            return value;
        }
        static int Show_Person(string letter, Book book)
        {
            int i = 0;
            int number;
           
                while (!(book.Pages[Alp_Value(letter)].Persons[i].Fio == letter))
                {
                    i++;
                }
            
           
            number = i;
            return number;
        }

    }
    
}

