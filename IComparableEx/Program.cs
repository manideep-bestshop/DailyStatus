using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IComparableEx
{
    class Student:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if(this.Id>other.Id)
                return 1;
            if (this.Id < other.Id)
                return -1;
            else
                return 0;
        }
    }
    class Comparestudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(x.Marks>y.Marks)
                return 1;
            if(x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    internal class Program
    {
        public static int CompareNames(Student s1,Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student { Id = 100, Name = "mani", Class = 10,Marks=435.00f };
            Student s2 = new Student { Id = 103, Name = "deep", Class = 10, Marks = 565.00f };
            Student s3 = new Student { Id = 104, Name = "manideep", Class = 10, Marks = 415.00f };
            Student s4 = new Student { Id = 101, Name = "Nampally", Class = 10, Marks = 585.00f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4 };

            Comparison<Student> comp = new Comparison<Student>(CompareNames);
            students.Sort(comp);
           // Comparestudents obj = new Comparestudents();

            //  students.Sort(obj);
          //  students.Sort(1, 2, obj);
           // students.Reverse();

            foreach (Student s in students)
            {
                Console.WriteLine(s.Id+" "+s.Name+" "+s.Class+" "+s.Marks);
            }
            Console.WriteLine();
        }
    }
}
