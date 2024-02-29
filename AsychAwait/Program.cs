using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsychAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started..");
            Method1();
            Console.WriteLine("Main method ended");
            Console.ReadKey();
        }
        public static async void Method1()
        {
            Console.WriteLine("Method1 started");
            await method2();
            Console.WriteLine("\n");
            Console.WriteLine("Method1 Ended");
        }

       public static async Task method2()
        {
            await Task.Delay(5000);
            Console.WriteLine("Method2 ended");
        }
    }
}
