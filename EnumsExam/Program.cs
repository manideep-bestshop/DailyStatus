using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExam
{
    internal class Program
    {
        enum products
        {
            pens, books, eraser
        }
        static void Main(string[] args)
        {
            int pc = 1, qty = 0, pr = 0, amt = 0;
            products prod = products.pens;
            if (pc == (int)products.pens)
            {
                qty = 12;
                pr = 5;
            }
            else if (pc == (int)products.books)
            {
                qty = 10;
                pr = 9;
                prod = products.books;
            }
            else if (pc == (int)products.eraser)
            {
                qty = 15;
                pr = 5;
                prod = products.eraser;
            }
            amt = qty * pr;

            Console.WriteLine("Product Code=" + pc);
            Console.WriteLine("p name=" + prod);
            Console.WriteLine("Quantity=" + qty);
            Console.WriteLine("price=" + pr);
            Console.WriteLine("Amount=" + amt);
        }
    }
}
