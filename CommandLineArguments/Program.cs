using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = a + b;
            Console.WriteLine(c);

            Console.WriteLine("enter n value");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
