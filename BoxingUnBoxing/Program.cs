using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=37;
            object j = i;   //Boxing Value type to reference type  // 
            Console.WriteLine(i+" "+j); // 37 37

            // int k = j; CTE-- need Explicit

            int k = (int)j;  //UnBoxing refernce type to value type
            
        }
    }
}
