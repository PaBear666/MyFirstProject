using System;
using System.Collections.Generic;
using System.Text;

namespace Class_work
{
    public class Student
    {
        private string fio;
        private byte[] marks;
        public string Fio
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }
        public byte[] Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
        public Student(string name,byte[] marks)
        {
            Fio = name;
            Marks = marks;
        }


    }

    public class Group
    {
        private string groupid;
        private string[] subjects;
        private Student[] students;
        public string Groupid
        {
            get
            {
                return groupid;
            }
            set
            {
                groupid = value;
            }

        }
        public string[] Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
            }

        }
        public Student[] Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }
        public Group(string group,string[] subjects)
        {
            Groupid = group; 
            Subjects = subjects;
            Students = new Student[3]; 
        }
    }

    public class Course
    {
        private string courseId;
        private Group[] groups;
        
        public string CourseId
        {
            get
            {
                return courseId;
            }
            set
            {
                courseId = value;
            }
        }
        public Group[] Groups
        {
            get { return groups; }
            set { groups = value; }
                
        }
        public  Course(string courseId)
        {
            CourseId = courseId;
            Groups = new Group[2];
        }

        public void Print()
        {
            for(int i = 0; i < Groups.Length; i++)
            {
                for (int j = 0; j < Groups[i].Students.Length;j++)
                {
                    for (int k = 0; k < Groups[i].Students[j].Marks.Length;k++)
                    {
                        if (Groups[i].Students[j].Marks[k] == 2)
                        {
                            Console.WriteLine(Groups[i].Students[j].Fio);
                            Console.WriteLine(Groups[i].Groupid);
                            Console.WriteLine(Groups[i].Subjects[k]);
                        }
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Student st1 = new Student("Антонов", new byte[] { 5, 4, 3, 2 });
            Student st2 = new Student("Борисов", new byte[] { 4, 4, 4, 4 });
            Student st3 = new Student("Яковлев", new byte[] { 2, 3, 4, 2 });
            Group gr1 = new Group("6101 (Ивт)", new string[] { "матан", "физика", "Программирование", "История" });
            gr1.Students[1] = st2;
            gr1.Students[2] = st3;
            Student st4 = new Student("Васильев", new byte[] { 2, 3, 4, 5 });
            Student st5 = new Student("Васильев", new byte[] { 5, 4, 3, 2 });
            Student st6 = new Student("Васильев", new byte[] { 2, 3, 3, 2 });
            Group gr2 = new Group("6108 (ПМИ)", new string[] { "матан", "алгебра", "Программирование", "История" });
            gr2.Students[0] = st4;
            gr2.Students[1] = st5;
            gr2.Students[2] = st6;
            Course cr = new Course("1-курс");
            cr.Groups[0] = gr1;
            cr.Groups[1] = gr2;
            cr.Print();

        }
    }
}
