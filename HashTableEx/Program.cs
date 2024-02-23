using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hashtable ht=new Hashtable();
            ht.Add("Id", 1);
            ht.Add("Name", "Manideep");
            ht.Add("Email", "manideep.n15@gmail.com");
            ht.Add("City", "Hyderabad");

            Console.WriteLine(ht["Email"]);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }
    }
}
