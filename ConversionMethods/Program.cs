using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            string j = Convert.ToString(i);
            Console.WriteLine(j);

            int a = 12;
            string b = Convert.ToString(a);
            Console.WriteLine(b);

            int x = 25;
            object y = x;
            Console.WriteLine(y);

            int z = (int)y;
            Console.WriteLine(z);
        }
    }
}
