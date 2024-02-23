using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericClass
{
    class Generics1<T>
    {
        public void Add(T a,T b)
        {
            dynamic d1 = a;  // we can declare by variables by dynamic and it will decide type at run time
            dynamic d2= b;
            Console.WriteLine(d1+d2);
        }
        public void Sub(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1-d2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics1<int> generics1 = new Generics1<int>();
            generics1.Add(23, 12);
            generics1.Sub(23, 12);

            List<Customer> list = new List<Customer>();
            Customer c1 = new Customer { Id = 1, Name = "Mani", Address = "Hyd" };
            Customer c2 = new Customer { Id = 2, Name = "Manideep", Address = "KNR" };

            list.Add(c1);
            list.Add(c2);

            foreach (Customer c in list)
            {
                Console.WriteLine(c.Id + " " + c.Name + " " + c.Address);
            }
        }
    }
}
