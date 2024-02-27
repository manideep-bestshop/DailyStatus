using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallings
{
    internal class Program
    {
        public int a, b, c;

        private void show()
        {
            a = 11;
            b = 13;
            c = a + b;
            Console.WriteLine(c);
        }
        public void display()
        {


            a = 15;
            b = 25;
            c = a + b;
            Console.WriteLine(c);

            show();
        }
        static void Main(string[] args)
        {
            Program p = new Program(); // object /instance
            p.a = 12;
            p.b = 23;
            p.c = p.a + p.b;
            Console.WriteLine(p.c);
            p.display();

        }
    }
}
