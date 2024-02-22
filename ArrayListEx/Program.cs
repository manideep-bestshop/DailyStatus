using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add(18);
            al.Add("HYD");
            al.Add(true);
            al.Add(9.3);
            al.Add('A');
            al.Insert(0, 5.1); // it will insert in 0 place not 18 place
            al.TrimToSize(); // it trim the size (capacity) of array to count size

            Console.WriteLine(al.Capacity); // 6 bacuse we trim it count 6
            al.Add("manideep");
            al.Add(12);
            al.Add(34);
            Console.WriteLine(al.Capacity);// 12  ,count 9
            //method 1
            for (int i=0;i<al.Count;i++)
            {
                Console.Write(al[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");

            //method2
            foreach(var x in al)   // var can accept any type of datatype
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            ArrayList al1 = new ArrayList();
            al1.Add(12);
            al1.Add("Nampally");
            al1.Add(2.3);
            al1.Add(23);
            al1.Add(55);
            al1.Add(3);

            al1.RemoveAt(2);
            al1.RemoveRange(1, 2);
            al1.Remove("Nampally");

            Console.WriteLine();

            foreach (var x in al1)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }
    }
}
