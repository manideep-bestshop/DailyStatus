using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 19,20,33,34,5},
                            { 1,2,3,4,5},
                            {4,5,6,8,9 }
                         };
            Console.WriteLine(arr.Length+" =Length");
            Console.WriteLine(arr.GetLength(0)+" =Rows");
            Console.WriteLine(arr.GetLength(1)+" =cols");

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write(arr[r, c] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
